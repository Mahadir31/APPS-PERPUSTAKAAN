Imports MySql.Data.MySqlClient
Public Class FormPetugas
    Sub Isi()
        kodepetugas.Enabled = True
        namapetugas.Enabled = True
        passpetugas.Enabled = True
        statuspetugas.Enabled = True
    End Sub
    Sub tampilkan()
        Call OpenConn()
        Da = New MySqlDataAdapter("Select * from tblpetugas", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblpetugas")
        dgPetugas.DataSource = Ds.Tables("tblpetugas")
        dgPetugas.AlternatingRowsDefaultCellStyle.BackColor = Color.Silver

        kodepetugas.Text = ""
        namapetugas.Text = ""
        passpetugas.Text = ""
        statuspetugas.Text = ""

        kodepetugas.Enabled = False
        namapetugas.Enabled = False
        passpetugas.Enabled = False
        statuspetugas.Enabled = False

        Input.Enabled = True
        Input.Text = "INPUT"
        Update.Enabled = True
        Update.Text = "UPDATE"
        Delete.Enabled = True
        Delete.Text = "DELETE"
        Keluar.Text = "KELUAR"
    End Sub
    Private Sub FormPetugas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilkan()
    End Sub
    Private Sub Input_Click(sender As Object, e As EventArgs) Handles Input.Click
        If Input.Text = "INPUT" Then
            Input.Text = "SIMPAN"
            Update.Enabled = False
            Delete.Enabled = False
            Keluar.Text = "&CANCEL"
            Call Isi()
            kodepetugas.Focus()
        Else
            If kodepetugas.Text = "" Or namapetugas.Text = "" Or passpetugas.Text = "" Or statuspetugas.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim InputData As String = "insert into tblpetugas values ('" & kodepetugas.Text & "','" & namapetugas.Text & "','" & passpetugas.Text & "','" & statuspetugas.Text & "')"
                    Cmd = New MySqlCommand(InputData, Conn)
                    Cmd.ExecuteNonQuery()
                    MsgBox("Data Berhasil dI Simpan !!!")
                    Call tampilkan()
                Catch ex As Exception
                    MsgBox("Data Gagal di Simpan......Periksa Koneksi!!!", MsgBoxStyle.MsgBoxRight, "pesan")
                End Try
            End If
        End If
    End Sub

    Private Sub dgPetugas_Click(sender As Object, e As EventArgs) Handles dgPetugas.Click
        If dgPetugas.RowCount > 0 Then
            Dim baris As Integer
            With dgPetugas
                baris = .CurrentRow.Index
                kodepetugas.Text = dgPetugas.Item(0, baris).Value
                namapetugas.Text = dgPetugas.Item(1, baris).Value
                passpetugas.Text = dgPetugas.Item(2, baris).Value
                statuspetugas.Text = dgPetugas.Item(3, baris).Value
                kodepetugas.Focus()
            End With
        End If
    End Sub

    Private Sub Update_Click(sender As Object, e As EventArgs) Handles Update.Click
        If Update.Text = "UPDATE" Then
            Update.Text = "UBAH"
            Input.Enabled = False
            Delete.Enabled = False
            Keluar.Text = "&CANCEL"
            Call Isi()
            kodepetugas.Focus()
        Else
            If kodepetugas.Text = "" Or namapetugas.Text = "" Or passpetugas.Text = "" Or statuspetugas.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim UpdateData As String = "update tblpetugas set NamaPetugas='" & namapetugas.Text & "', passwordPetugas='" & passpetugas.Text & "', StatusPetugas='" & statuspetugas.Text & "' where KodePetugas='" & kodepetugas.Text & "'"
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
            kodepetugas.Focus()
        Else
            If kodepetugas.Text = "" Or namapetugas.Text = "" Or passpetugas.Text = "" Or statuspetugas.Text = "" Then
                MsgBox("Pastikan Semua Filed Terisi")
            Else
                Try
                    Call OpenConn()
                    Dim DeleteData As String = "delete from tblpetugas where KodePetugas='" & kodepetugas.Text & "'"
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

    Private Sub kodepetugas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles kodepetugas.KeyPress
        If e.KeyChar = Chr(13) Then
            Call OpenConn()
            Cmd = New MySqlCommand("Select * from tblpetugas where KodePetugas='" & kodepetugas.Text & "'", Conn)
            Rd = Cmd.ExecuteReader()
            Rd.Read()
            If Not Rd.HasRows Then
                MsgBox("Data tidak ada")
            Else
                namapetugas.Text = Rd.Item("NamaPetugas")
                passpetugas.Text = Rd.Item("PasswordPetugas")
                statuspetugas.Text = Rd.Item("StatusPetugas")
            End If
        End If
    End Sub

    Private Sub passpetugas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles passpetugas.KeyPress
        If e.KeyChar = Chr(13) Then
            statuspetugas.Focus()
        End If
    End Sub
    Private Sub statuspetugas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles statuspetugas.KeyPress
        If e.KeyChar = Chr(13) Then
            Input.Focus()
            Update.Focus()
            Delete.Focus()
        End If
    End Sub

    Private Sub namapetugas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles namapetugas.KeyPress
        If e.KeyChar = Chr(13) Then
            passpetugas.Focus()
        End If
    End Sub
End Class