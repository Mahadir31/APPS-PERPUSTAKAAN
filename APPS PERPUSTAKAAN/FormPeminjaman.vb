Imports MySql.Data.MySqlClient
Public Class FormPeminjaman
    Sub Tampilkan()
        Call MunculKodeAnggota()
        LblNama.Text = ""
        LblKelamin.Text = ""
        LblAlamat.Text = ""
        LblTelpon.Text = ""
        LblBuku.Text = ""
        kodeanggota.Text = ""
        LblPengarang.Text = ""
        LblTotalBuku.Text = "0"
        txtKode.Text = ""
        txtJumlah.Text = ""
        LblPenerbit.Text = ""
        Lbltelahpinjam.Text = "0"
        txtKode.Enabled = True
        kodeanggota.Enabled = True
        input.Enabled = True
        txtJumlah.Enabled = True
        dgPinjam.Rows.Clear()
    End Sub
    Sub Mati()
        Call NoOtomatis()
        Call BuatKolom()
        LblNama.Enabled = False
        LblKelamin.Enabled = False
        LblAlamat.Enabled = False
        LblTelpon.Enabled = False
        LblBuku.Enabled = False
        kodeanggota.Enabled = False
        LblPengarang.Enabled = False
        LblTotalBuku.Enabled = False
        txtKode.Enabled = False
        txtJumlah.Enabled = False
        LblPenerbit.Enabled = False
        input.Enabled = False

        LblNamaPetugas.Text = FrmMenuUtama.NamaPetugas.Text

        Tambah.Text = "TAMBAH"
        Keluar.Text = "KELUAR"

        kodeanggota.Text = ""
        LblNama.Text = ""
        LblKelamin.Text = ""
        LblAlamat.Text = ""
        LblTelpon.Text = ""
        LblBuku.Text = ""
        kodeanggota.Text = ""
        LblPengarang.Text = ""
        LblTotalBuku.Text = ""
        txtKode.Text = ""
        txtJumlah.Text = ""
        LblPenerbit.Text = ""
        Lbltelahpinjam.Text = ""
        dgPinjam.Rows.Clear()
        dgtelahpinjam.Columns.Clear()
    End Sub
    Sub NoOtomatis()
        Call OpenConn()
        Cmd = New MySqlCommand("select NoPinjam from tblpinjam order by NoPinjam desc", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows = True Then
            LblNoPinjam.Text = "PJ" + Format(Today, "yyMMdd") + "01"
        Else
            If Microsoft.VisualBasic.Mid(Rd.Item("NoPinjam"), 3, 6) = Format(Today, "yyMMdd") Then
                LblNoPinjam.Text = "PJ" + Format(Microsoft.VisualBasic.Right(Rd.Item("NoPinjam"), 8) + 1, "00")
            Else
                LblNoPinjam.Text = "PJ" + Format(Today, "yyMMdd") + "01"
            End If
        End If
    End Sub
    Sub MunculKodeAnggota()
        Call OpenConn()
        kodeanggota.Items.Clear()
        Cmd = New MySqlCommand("select * from tblanggota", Conn)
        Rd = Cmd.ExecuteReader
        Do While Rd.Read
            kodeanggota.Items.Add(Rd.Item(0))
        Loop
    End Sub
    Sub CekPinjaman()
        Call OpenConn()
        Da = New MySqlDataAdapter("select tblbuku.KodeBuku,JudulBuku,JumlahBuku from tblanggota,tblpinjam,tblbuku,tbldetailpinjam where tblbuku.KodeBuku = tbldetailpinjam.KodeBuku And tblpinjam.NoPinjam = tbldetailpinjam.NoPinjam And tblanggota.KodeAnggota = tblpinjam.KodeAnggota And tblanggota.KodeAnggota = '" & kodeanggota.Text & "' AND tbldetailpinjam.JumlahBuku>0", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Detail")
        dgtelahpinjam.DataSource = Ds.Tables("Detail")
        Lbltelahpinjam.Text = dgtelahpinjam.Rows.Count - 1
        dgtelahpinjam.ReadOnly = True
    End Sub
    Sub BuatKolom()
        dgPinjam.Columns.Clear()
        dgPinjam.Columns.Add("Kode", "Kode Buku")
        dgPinjam.Columns.Add("Judul", "Judul Buku")
        dgPinjam.Columns.Add("Pengarang", "Pengarang Buku")
        dgPinjam.Columns.Add("Penerbit", "Penerbit")
        dgPinjam.Columns.Add("Jumlah", "Jumlah Buku")
    End Sub
    Private Sub FormPeminjaman_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Mati()
        kodeanggota.Text = ""
        lbltanggal.Text = Today
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lbljam.Text = TimeOfDay
    End Sub

    Private Sub kodeanggota_SelectedIndexChanged(sender As Object, e As EventArgs) Handles kodeanggota.SelectedIndexChanged
        Call OpenConn()
        Cmd = New MySqlCommand("Select * from tblanggota where KodeAnggota='" & kodeanggota.Text & "'", Conn)
        Rd = Cmd.ExecuteReader()
        Rd.Read()
        If Not Rd.HasRows Then
            MsgBox("Data tidak ada")
        Else
            LblNama.Text = Rd.Item("NamaAnggota")
            LblKelamin.Text = Rd.Item("JenisKelamin")
            LblAlamat.Text = Rd.Item("AlamatAnggota")
            LblTelpon.Text = Rd.Item("TelponAnggota")
            Call CekPinjaman()
        End If
    End Sub
    Private Sub txtKode_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtKode.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            Cmd = New MySqlCommand("Select * from tblbuku where KodeBuku='" & txtKode.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data tidak ada")
                txtKode.Focus()
                txtKode.Text = ""
            Else
                txtKode.Text = Rd.Item("KodeBuku")
                LblBuku.Text = Rd.Item("JudulBuku")
                LblPengarang.Text = Rd.Item("PengarangBuku")
                LblPenerbit.Text = Rd.Item("Penerbit")
                txtJumlah.Text = True
                txtJumlah.Text = "1"
            End If
        End If
    End Sub

    Private Sub input_Click(sender As Object, e As EventArgs) Handles input.Click
        If Val(Lbltelahpinjam.Text) + (LblTotalBuku.Text) >= 5 Or Val(LblTotalBuku.Text) + Val(txtJumlah.Text) > 5 Then
            MsgBox("Buku Yang Dpinjam Melebihi Maksimal !!!")
        Else
            If txtKode.Text = "" Or txtJumlah.Text = "" Then
                MsgBox("Silahkan masukkan Kode Buku Dan Tekan ENTER !!!")
                txtKode.Focus()
            Else
                dgPinjam.Rows.Add(New String() {txtKode.Text, LblBuku.Text, LblPengarang.Text, LblPenerbit.Text, txtJumlah.Text})
                txtKode.Text = ""
                LblBuku.Text = ""
                LblPengarang.Text = ""
                LblPenerbit.Text = ""
                txtJumlah.Text = ""
                Dim sum As Decimal = 0
                For i = 0 To dgPinjam.Rows.Count - 1
                    sum += dgPinjam.Rows(i).Cells(4).Value
                Next
                LblTotalBuku.Text = sum
            End If
        End If
    End Sub

    Private Sub Tambah_Click(sender As Object, e As EventArgs) Handles Tambah.Click
        If Tambah.Text = "TAMBAH" Then
            Tambah.Text = "SIMPAN"
            Keluar.Text = "&CANCEL"
            Call Tampilkan()
        Else
            If kodeanggota.Text = "" Or LblTotalBuku.Text = "0" Then
                MsgBox("Transaksi Tidak Ada, silahkan lakukan transaksi terlebih dhulu")
            Else
                Call OpenConn()
                Dim tglmysql = Format(Today, "yyyy-MM-dd")
                Dim PinjamBuku As String = "Insert into tblpinjam values ('" & LblNoPinjam.Text & "', '" & tglmysql & "', '" & lbljam.Text & "', '" & kodeanggota.Text & "', '" & LblTotalBuku.Text & "', '" & LblTotalBuku.Text & "', '" & FrmMenuUtama.KodePetugas.Text & "')"
                Cmd = New MySqlCommand(PinjamBuku, Conn)
                Cmd.ExecuteNonQuery()

                For Baris As Integer = 0 To dgPinjam.Rows.Count - 2
                    Call OpenConn()
                    Dim SimpanDetailPinjam As String = "Insert into tbldetailpinjam values ('" & LblNoPinjam.Text & "', '" & dgPinjam.Rows(Baris).Cells(0).Value & "', '" & dgPinjam.Rows(Baris).Cells(4).Value & "')"
                    Cmd = New MySqlCommand(SimpanDetailPinjam, Conn)
                    Cmd.ExecuteNonQuery()
                    Call OpenConn()
                    Cmd = New MySqlCommand("select * from tblbuku where KodeBuku = '" & dgPinjam.Rows(Baris).Cells(0).Value & "'", Conn)
                    Rd = Cmd.ExecuteReader
                    Rd.Read()
                    Call OpenConn()
                    Dim KurangiStok As String = "update tblbuku set StokBuku = '" & Rd.Item("StokBuku") - dgPinjam.Rows(Baris).Cells(4).Value & "' where KodeBuku = '" & dgPinjam.Rows(Baris).Cells(0).Value & "'"
                    Cmd = New MySqlCommand(KurangiStok, Conn)
                    Cmd.ExecuteNonQuery()
                Next
                MsgBox("Transaksi Telah Berhasil Disimpan")
                Call Mati()
            End If
        End If
    End Sub

    Private Sub Keluar_Click(sender As Object, e As EventArgs) Handles Keluar.Click
        If Keluar.Text = "KELUAR" Then
            Me.Close()
        Else
            Call Mati()
        End If
    End Sub

    Private Sub FormPeminjaman_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        dgtelahpinjam.Columns.Clear()
    End Sub
End Class