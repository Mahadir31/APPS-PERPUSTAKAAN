Imports MySql.Data.MySqlClient
Public Class FormBuku
    Sub tampilkan()
        Call OpenConn()
        Da = New MySqlDataAdapter("Select * from tblbuku", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblbuku")
        dgBuku.DataSource = Ds.Tables("tblbuku")
        dgBuku.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver

        Input.Enabled = True
        Input.Text = "INPUT"
        Update.Enabled = True
        Update.Text = "UPDATE"
        Delete.Enabled = True
        Delete.Text = "DELETE"
        Keluar.Text = "KELUAR"

        kodebuku.Text = ""
        judulbuku.Text = ""
        pengarangbuku.Text = ""
        penerbit.Text = ""
        tahunbuku.Text = ""
        stokbuku.Text = ""

        kodebuku.Enabled = False
        judulbuku.Enabled = False
        pengarangbuku.Enabled = False
        penerbit.Enabled = False
        tahunbuku.Enabled = False
        stokbuku.Enabled = False

        Dim Tahun As String
        Tahun = Date.Now().Year
        tahunbuku.Items.Clear()
        With tahunbuku
            While Tahun >= 2010
                .Items.Add(Tahun)
                Tahun = Tahun - 1
            End While
        End With
    End Sub
    Sub Isi()
        kodebuku.Enabled = True
        judulbuku.Enabled = True
        pengarangbuku.Enabled = True
        penerbit.Enabled = True
        tahunbuku.Enabled = True
        stokbuku.Enabled = True
    End Sub
    Private Sub FormBuku_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilkan()
    End Sub

    Private Sub Input_Click(sender As Object, e As EventArgs) Handles Input.Click
        If Input.Text = "INPUT" Then
            Input.Text = "SIMPAN"
            Update.Enabled = False
            Delete.Enabled = False
            Keluar.Text = "&CANCEL"
            Call Isi()
            kodebuku.Focus()
        Else
            If kodebuku.Text = "" Or judulbuku.Text = "" Or pengarangbuku.Text = "" Or penerbit.Text = "" Or tahunbuku.Text = "" Or stokbuku.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
                kodebuku.Focus()
            Else
                Try
                    Call OpenConn()
                    Dim InputData As String = "insert into tblbuku values ('" & kodebuku.Text & "','" & judulbuku.Text & "','" & pengarangbuku.Text & "','" & penerbit.Text & "', '" & tahunbuku.Text & "'.'" & stokbuku.Text & "')"
                    Cmd = New MySqlCommand(InputData, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil di Simpan !!!")
                    Call tampilkan()
                Catch ex As Exception
                    MsgBox("Data Gagal di Simpan......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End Try
            End If
        End If
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        If Update.Text = "UPDATE" Then
            Update.Text = "UBAH"
            Input.Enabled = False
            Delete.Enabled = False
            Keluar.Text = "&CANCEL"
            Call Isi()
            kodebuku.Focus()
        Else
            If kodebuku.Text = "" Or judulbuku.Text = "" Or pengarangbuku.Text = "" Or penerbit.Text = "" Or tahunbuku.Text = "" Or stokbuku.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
                kodebuku.Focus()
            Else
                Try
                    Call OpenConn()
                    Dim UpdateData As String = "update tblbuku set JudulBuku='" & judulbuku.Text & "', PengarangBuku='" & pengarangbuku.Text & "', Penerbit='" & penerbit.Text & "', TahunBuku='" & tahunbuku.Text & "', StokBuku='" & stokbuku.Text & "' where KodeBuku='" & kodebuku.Text & "'"
                    Cmd = New MySqlCommand(UpdateData, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil di Ubah", MsgBoxStyle.MsgBoxRight, "Message")
                    Call tampilkan()
                Catch ex As Exception
                    MsgBox("Data Gagal di Ubah......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End Try
            End If
        End If
    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        If Delete.Text = "DELETE" Then
            Delete.Text = "HAPUS"
            Input.Enabled = False
            Update.Enabled = False
            Keluar.Text = "&CANCEL"
            Call Isi()
            kodebuku.Focus()
        Else
            If kodebuku.Text = "" Or judulbuku.Text = "" Or pengarangbuku.Text = "" Or penerbit.Text = "" Or tahunbuku.Text = "" Or stokbuku.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
                kodebuku.Focus()
            Else
                Try
                    Call OpenConn()
                    Dim DeleteData As String = "delete * from tblbuku where KodeBuku='" & kodebuku.Text & "'"
                    Cmd = New MySqlCommand(DeleteData, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil di Hapus", MsgBoxStyle.MsgBoxRight, "Message")
                    Call tampilkan()
                Catch ex As Exception
                    MsgBox("Data Gagal di Hapus......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End Try
            End If
        End If
    End Sub

    Private Sub Keluar_Click(sender As Object, e As EventArgs) Handles Keluar.Click
        If Keluar.Text = "KELUAR" Then
            Me.Close()
        Else
            Call tampilkan()
        End If
    End Sub
    Private Sub kodebuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles kodebuku.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            Cmd = New MySqlCommand("Select * from tblbuku where KodeBuku='" & kodebuku.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data tidak ada")
            Else
                judulbuku.Text = Rd.Item("JudulBuku")
                pengarangbuku.Text = Rd.Item("PengarangBuku")
                penerbit.Text = Rd.Item("Penerbit")
                tahunbuku.Text = Rd.Item("TahunBuku")
                stokbuku.Text = Rd.Item("StokBuku")
            End If
        End If
    End Sub
    Private Sub kodebuku_KeyDown(sender As Object, e As KeyEventArgs) Handles kodebuku.KeyDown
        If e.KeyCode = Keys.Enter Then
            judulbuku.Focus()
        End If
    End Sub

    Private Sub judulbuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles judulbuku.KeyPress
        If e.KeyChar = Chr(13) Then
            pengarangbuku.Focus()
        End If
    End Sub
    Private Sub pengarangbuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pengarangbuku.KeyPress
        If e.KeyChar = Chr(13) Then
            penerbit.Focus()
        End If
    End Sub
    Private Sub penerbit_KeyPress(sender As Object, e As KeyPressEventArgs) Handles penerbit.KeyPress
        If e.KeyChar = Chr(13) Then
            tahunbuku.Focus()
        End If
    End Sub
    Private Sub tahunbuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tahunbuku.KeyPress
        If e.KeyChar = Chr(13) Then
            stokbuku.Focus()
        End If
    End Sub
    Private Sub stokbuku_KeyPress(sender As Object, e As KeyPressEventArgs) Handles stokbuku.KeyPress
        If e.KeyChar = Chr(13) Then
            Input.Focus()
            Update.Focus()
            Delete.Focus()
        End If
    End Sub
End Class