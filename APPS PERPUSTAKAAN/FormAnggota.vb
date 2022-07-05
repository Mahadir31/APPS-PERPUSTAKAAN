Imports MySql.Data.MySqlClient
Public Class FormAnggota
    Sub tampilkan()
        Call OpenConn()
        Da = New MySqlDataAdapter("Select * from tblanggota", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblanggota")
        dgAnggota.DataSource = Ds.Tables("tblanggota")
        dgAnggota.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver

        Input.Text = "INPUT"
        Update.Enabled = True
        Update.Text = "UPDATE"
        Delete.Enabled = True
        Delete.Text = "DELETE"
        Keluar.Text = "KELUAR"

        kodeanggota.Text = ""
        namaanggota.Text = ""
        jeniskelamin.Text = ""
        alamatanggota.Text = ""
        telponanggota.Text = ""

        kodeanggota.Enabled = False
        namaanggota.Enabled = False
        jeniskelamin.Enabled = False
        alamatanggota.Enabled = False
        telponanggota.Enabled = False
    End Sub
    Sub Isi()
        kodeanggota.Enabled = True
        namaanggota.Enabled = True
        jeniskelamin.Enabled = True
        alamatanggota.Enabled = True
        telponanggota.Enabled = True
    End Sub
    Private Sub FormAnggota_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilkan()
    End Sub

    Private Sub Input_Click(sender As Object, e As EventArgs) Handles Input.Click
        If Input.Text = "INPUT" Then
            Input.Text = "SIMPAN"
            Update.Enabled = False
            Delete.Enabled = False
            Keluar.Text = "&CANCEL"
            Call Isi()
            kodeanggota.Focus()
        Else
            If kodeanggota.Text = "" Or namaanggota.Text = "" Or jeniskelamin.Text = "" Or alamatanggota.Text = "" Or telponanggota.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
                kodeanggota.Focus()
            Else
                Try
                    Call OpenConn()
                    Dim InputData As String = "insert into tblanggota values ('" & kodeanggota.Text & "','" & namaanggota.Text & "','" & jeniskelamin.Text & "','" & alamatanggota.Text & "', '" & telponanggota.Text & "')"
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
            kodeanggota.Focus()
        Else
            If kodeanggota.Text = "" Or namaanggota.Text = "" Or jeniskelamin.Text = "" Or alamatanggota.Text = "" Or telponanggota.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
                kodeanggota.Focus()
            Else
                Try
                    Call OpenConn()
                    Dim UpdateData As String = "update tblanggota set NamaAnggota='" & namaanggota.Text & "', JenisKelamin='" & jeniskelamin.Text & "', AlamatAnggota='" & alamatanggota.Text & "' where KodeAnggota='" & kodeanggota.Text & "'"
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
            kodeanggota.Focus()
        Else
            If kodeanggota.Text = "" Or namaanggota.Text = "" Or jeniskelamin.Text = "" Or alamatanggota.Text = "" Or telponanggota.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
                kodeanggota.Focus()
            Else
                Try
                    Call OpenConn()
                    Dim DeleteData As String = "delete from tblanggota where KodeAnggota='" & kodeanggota.Text & "'"
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

    Private Sub namaanggota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles namaanggota.KeyPress
        If e.KeyChar = Chr(13) Then
            jeniskelamin.Focus()
        End If
    End Sub

    Private Sub jeniskelamin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles jeniskelamin.KeyPress
        If e.KeyChar = Chr(13) Then
            alamatanggota.Focus()
        End If
    End Sub

    Private Sub alamatanggota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles alamatanggota.KeyPress
        If e.KeyChar = Chr(13) Then
            telponanggota.Focus()
        End If
    End Sub

    Private Sub telponanggota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles telponanggota.KeyPress
        If e.KeyChar = Chr(13) Then
            Input.Focus()
            Update.Focus()
            Delete.Focus()
        End If
    End Sub

    Private Sub kodeanggota_KeyPress(sender As Object, e As KeyPressEventArgs) Handles kodeanggota.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            Cmd = New MySqlCommand("Select * from tblanggota where KodeAnggota='" & kodeanggota.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data tidak ada")
            Else
                namaanggota.Text = Rd.Item("NamaAnggota")
                jeniskelamin.Text = Rd.Item("JenisKelamin")
                alamatanggota.Text = Rd.Item("AlamatAnggota")
                telponanggota.Text = Rd.Item("TelponAnggota")
            End If
        End If
    End Sub

    Private Sub kodeanggota_KeyDown(sender As Object, e As KeyEventArgs) Handles kodeanggota.KeyDown
        If e.KeyCode = Keys.Enter Then
            namaanggota.Focus()
        End If
    End Sub
End Class