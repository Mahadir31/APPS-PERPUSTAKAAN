Imports MySql.Data.MySqlClient
Public Class FormPengembalian
    Sub Tampil()
        KodeBuku.Text = ""
        JumlahPinjam.Text = ""
        LblNamaAnggota.Text = ""
        LblTglKembali.Text = ""
        LblJudulBuku.Text = ""
        LblNoPinjam.Text = ""
        LblTglPinjam.Text = ""
        LblLamaPjm.Text = ""
        LblDenda.Text = ""
        LblTotalDenda.Text = ""
        txtBayar.Text = ""
        lblKembalian.Text = ""
        KodeAnggota.Text = ""
        LblTelahPinjam.Text = ""
        LblTotalKembali.Text = ""
        Keluar.Text = "KELUAR"
    End Sub
    Sub TampilGrid1()
        dgpengembalian.Columns.Clear()
        dgpengembalian.Columns.Add("Kode", "Kode Buku")
        dgpengembalian.Columns.Add("Nomor", "Nomor Pinjam")
        dgpengembalian.Columns.Add("Judul", "Judul Buku")
        dgpengembalian.Columns.Add("Jumlah", "Jumlah Pinjam")
        dgpengembalian.Columns.Add("Tanggal", "Tanggal Pinjam")
        dgpengembalian.Columns.Add("Lama", "Lama Pinjam")
        dgpengembalian.Columns.Add("Denda", "Denda")
        dgpengembalian.Columns(2).Width = 175
        dgpengembalian.Columns(4).Width = 75
        dgpengembalian.Columns(6).Width = 75
    End Sub
    Sub TampilGrid2()
        dgKembali.Columns.Clear()
        dgKembali.Columns.Add("Kode", "Kode Buku")
        dgKembali.Columns.Add("judul", "Judul Buku")
        dgKembali.Columns.Add("Jumlah", "Jumlah Buku")
    End Sub

    Sub NoOtomatis()
        Call OpenConn()
        Cmd = New MySqlCommand("select NoKembali from tblkembali order by NoKembali desc", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Not Rd.HasRows = True Then
            LblNomorKembali.Text = "NK" + Format(Today, "yyMMdd") + "01"
        Else
            If Microsoft.VisualBasic.Mid(Rd.Item("NoKembali"), 3, 6) = Format(Today, "yyMMdd") Then
                LblNomorKembali.Text = "NK" + Format(Microsoft.VisualBasic.Right(Rd.Item("NoKembali"), 8) + 1, "00")
            Else
                LblNomorKembali.Text = "NK" + Format(Today, "yyMMdd") + "01"
            End If
        End If
    End Sub
    Private Sub FormPengembalian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Tampil()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        LblJam.Text = TimeOfDay
    End Sub
    Sub Pinjaman()
        Call OpenConn()
        Da = New MySqlDataAdapter("select tblbuku.KodeBuku,JudulBuku,JumlahBuku from tblanggota,tblpinjam,tblbuku,tbldetailpinjam where tblbuku.KodeBuku = tbldetailpinjam.KodeBuku And tblpinjam.NoPinjam = tbldetailpinjam.NoPinjam And tblanggota.KodeAnggota = tblpinjam.KodeAnggota And tblanggota.KodeAnggota = '" & KodeAnggota.Text & "' AND tbldetailpinjam.JumlahBuku>0", Conn)
        Ds = New DataSet
        Ds.Clear()
        Da.Fill(Ds, "Detail")
        dgKembali.DataSource = Ds.Tables("Detail")
        dgKembali.ReadOnly = True
        dgKembali.Columns(0).Width = 80
        dgKembali.Columns(1).Width = 300
        dgKembali.Columns(2).Width = 100
    End Sub
    Sub CariData()
        Call OpenConn()
        Cmd = New MySqlCommand("select * from tblanggota where KodeAnggota = '" & KodeAnggota.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            LblNamaAnggota.Text = Rd.Item("NamaAnggota")
            Call OpenConn()
            Cmd = New MySqlCommand("select KodeAnggota from tblpinjam where KodeAnggota = '" & KodeAnggota.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Call OpenConn()
                Cmd = New MySqlCommand("Select SUM(TotalPinjam) As meet from tblpinjam where KodeAnggota = '" & KodeAnggota.Text & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                LblTelahPinjam.Text = Rd.Item(0)
                Call Pinjaman()
            End If
            KodeBuku.Focus()
        End If
    End Sub
    Private Sub KodeAnggota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles KodeAnggota.KeyPress
        Keluar.Text = "&BATAL"
        If e.KeyChar = Chr(13) Then
            Call CariData()
        Else
            dgKembali.Columns.Clear()
        End If
    End Sub

    Private Sub FormPengembalian_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Call NoOtomatis()
        Call TampilGrid1()
        KodeAnggota.Focus()
        LblTglKembali.Text = Today
        LblPetugas.Text = FrmMenuUtama.NamaPetugas.Text
    End Sub
    Private Sub KodeBuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles KodeBuku.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            Cmd = New MySqlCommand("select distinct tblbuku.KodeBuku,tbldetailpinjam.NoPinjam,JudulBuku,JumlahBuku,TglPinjam from tblanggota,tblpinjam,tblbuku,tbldetailpinjam where tblbuku.KodeBuku = tbldetailpinjam.KodeBuku And tblpinjam.NoPinjam = tbldetailpinjam.NoPinjam And tblanggota.KodeAnggota = tblpinjam.KodeAnggota And tblanggota.KodeAnggota = '" & KodeAnggota.Text & "' AND tbldetailpinjam.KodeBuku = '" & KodeBuku.Text & "' and tbldetailpinjam.JumlahBuku>0", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Kode Buku Bukan Yang Di Pinjam !!!")
                Call CariData()
            Else
                LblNoPinjam.Text = Rd.Item(1)
                LblJudulBuku.Text = Rd.Item(2)
                JumlahPinjam.Text = Rd.Item(3)
                LblTglPinjam.Text = Rd.Item(4)
                LblLamaPjm.Text = DateDiff(DateInterval.Day, Rd.Item(4), Today())
                If LblLamaPjm.Text > 5 Then
                    LblDenda.Text = Val((LblLamaPjm.Text) - 5) * 1000
                Else
                    LblDenda.Text = 0
                End If
                Input.Focus()
            End If
        End If
    End Sub

    Private Sub Input_Click(sender As Object, e As EventArgs) Handles Input.Click
        Keluar.Text = "&BATAL"
        If KodeAnggota.Text = "" Or KodeBuku.Text = "" Or JumlahPinjam.Text = "" Then
            MsgBox("Pastikan Buku Yang Mau di Kembalikan !!!")
        Else
            dgpengembalian.Rows.Add(New String() {KodeBuku.Text, LblNoPinjam.Text, LblJudulBuku.Text, JumlahPinjam.Text, LblTglPinjam.Text, LblLamaPjm.Text, LblDenda.Text})
            Call Hapus()
            Call TotalDenda()
            Call TotalKembali()
            KodeBuku.Focus()
        End If
    End Sub
    Sub Hapus()
        KodeBuku.Text = ""
        LblJudulBuku.Text = ""
        LblNoPinjam.Text = ""
        LblTglPinjam.Text = ""
        LblLamaPjm.Text = ""
        LblDenda.Text = ""
    End Sub
    Sub TotalDenda()
        Dim subtot As Integer = 0
        For I As Integer = 0 To dgpengembalian.Rows.Count - 1
            subtot += Val(dgpengembalian.Rows(I).Cells(6).Value)
            LblTotalDenda.Text = subtot
        Next
    End Sub
    Sub TotalKembali()
        Dim subtot As Integer = 0
        For I As Integer = 0 To dgpengembalian.Rows.Count - 1
            subtot += Val(dgpengembalian.Rows(I).Cells(3).Value)
            LblTotalKembali.Text = subtot
        Next
    End Sub
    Private Sub txtBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBayar.KeyPress
        If e.KeyChar = Chr(13) Then
            If Val(txtBayar.Text) < Val(LblDenda.Text) Then
                MsgBox("Pembayaran Kurang")
                txtBayar.Focus()
            ElseIf Val(txtBayar.Text) = Val(LblDenda.Text) Then
                lblKembalian.Text = 0
                Simpan.Focus()
            Else
                lblKembalian.Text = Val(LblDenda.Text) - Val(txtBayar.Text)
                lblKembalian.Text = 0
                Simpan.Focus()
            End If
        End If
    End Sub

    Private Sub Simpan_Click(sender As Object, e As EventArgs) Handles Simpan.Click
        If KodeAnggota.Text = "" Or LblTotalDenda.Text = "" Or lblKembalian.Text = "" Then
            MsgBox("Transaksi Tidak Ada, Silahkan lakukan Transaksi Terlebih Dahulu !!!")
        Else
            Call OpenConn()
            Dim tglmysql = Format(Today, "yyyy-MM-dd")
            Dim BukuKembali As String = "Insert into tblkembali (NoKembali,TglKembali,TotalKembali,Denda,DiBayar,Kembali,KodeAnggota,KodePetugas) values ('" & LblNomorKembali.Text & "', '" & tglmysql & "', '" & LblTotalKembali.Text & "', '" & LblDenda.Text & "', '" & txtBayar.Text & "', '" & lblKembalian.Text & "','" & KodeAnggota.Text & "', '" & FrmMenuUtama.KodePetugas.Text & "')"
            Cmd = New MySqlCommand(BukuKembali, Conn)
            Cmd.ExecuteNonQuery()

            For Baris As Integer = 0 To dgpengembalian.Rows.Count - 2
                Call OpenConn()
                Dim SimpanDetailPinjam As String = "Insert into tbldetailkembali(NoKembali,KodeBuku,JumlahBuku) values ('" & LblNomorKembali.Text & "', '" & dgpengembalian.Rows(Baris).Cells(0).Value & "', '" & dgpengembalian.Rows(Baris).Cells(3).Value & "')"
                Cmd = New MySqlCommand(SimpanDetailPinjam, Conn)
                Cmd.ExecuteNonQuery()
                Call OpenConn()
                Cmd = New MySqlCommand("select * from tblbuku where KodeBuku = '" & dgpengembalian.Rows(Baris).Cells(0).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                Call OpenConn()
                Dim KurangiStok As String = "update tblbuku set StokBuku = '" & Rd.Item("StokBuku") + dgpengembalian.Rows(Baris).Cells(3).Value & "' where KodeBuku = '" & dgpengembalian.Rows(Baris).Cells(0).Value & "'"
                Cmd = New MySqlCommand(KurangiStok, Conn)
                Cmd.ExecuteNonQuery()
                Call OpenConn()
                Cmd = New MySqlCommand("select JumlahBuku from tbldetailpinjam where KodeBuku= '" & dgpengembalian.Rows(Baris).Cells(0).Value & "' and NoPinjam= '" & dgpengembalian.Rows(Baris).Cells(1).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    Call OpenConn()
                    Dim UpdateDetailPinjam As String = "update tbldetailpinjam set JumlahBuku= '" & Rd.Item(0) - dgpengembalian.Rows(Baris).Cells(3).Value & "' Where KodeBuku= '" & dgpengembalian.Rows(Baris).Cells(0).Value & "' and NoPinjam= '" & dgpengembalian.Rows(Baris).Cells(1).Value & "'"
                    Cmd = New MySqlCommand(UpdateDetailPinjam, Conn)
                    Cmd.ExecuteNonQuery()
                End If
                Call OpenConn()
                Cmd = New MySqlCommand("select totalPinjam from tblpinjam where NoPinjam= '" & dgpengembalian.Rows(Baris).Cells(1).Value & "'", Conn)
                Rd = Cmd.ExecuteReader
                Rd.Read()
                If Rd.HasRows Then
                    Call OpenConn()
                    Dim UpdatePinjam As String = "update tblpinjam set totalPinjam= '" & Rd.Item(0) - dgpengembalian.Rows(Baris).Cells(3).Value & "' where NoPinjam= '" & dgpengembalian.Rows(Baris).Cells(1).Value & "'"
                    Cmd = New MySqlCommand(UpdatePinjam, Conn)
                    Cmd.ExecuteNonQuery()
                End If
            Next
            Call Tampil()
            Call NoOtomatis()
            dgpengembalian.Columns.Clear()
            dgKembali.Columns.Clear()
            MsgBox("Transaksi Telah Berhasil Disimpan")
        End If
    End Sub

    Private Sub Keluar_Click(sender As Object, e As EventArgs) Handles Keluar.Click
        If Keluar.Text = "KELUAR" Then
            Me.Close()
        Else
            Call Tampil()
            Call TampilGrid1()
            dgKembali.Columns.Clear()
            KodeAnggota.Focus()
        End If
    End Sub
End Class