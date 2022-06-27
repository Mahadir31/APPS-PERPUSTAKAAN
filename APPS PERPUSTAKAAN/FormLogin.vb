Imports MySql.Data.MySqlClient
Public Class FormLogin
    Sub Terbuka()
        FrmMenuUtama.Login.Enabled = False
        FrmMenuUtama.LogOut.Enabled = True
        FrmMenuUtama.MASTER.Enabled = True
        FrmMenuUtama.TRANSAKSI.Enabled = True
        FrmMenuUtama.LAPORAN.Enabled = True
    End Sub
    Private Sub FormLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Call OpenConn()
        Cmd = New MySqlCommand("select * from tblpetugas where KodePetugas = '" & kodepetugas.Text & "' and PasswordPetugas ='" & Password.Text & "'", Conn)
        Rd = Cmd.ExecuteReader
        Rd.Read()
        If Rd.HasRows Then
            Me.Close()
            Call Terbuka()
            FrmMenuUtama.KodePetugas.Text = Rd!KodePetugas
            FrmMenuUtama.NamaPetugas.Text = Rd!NamaPetugas
            FrmMenuUtama.StatusPetugas.Text = Rd!StatusPetugas
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            Password.PasswordChar = ""
        Else
            Password.PasswordChar = "x"
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub
    Private Sub kodepetugas_KeyPress(sender As Object, e As KeyPressEventArgs) Handles kodepetugas.KeyPress
        If e.KeyChar = Chr(13) Then
            Password.Focus()
        End If
    End Sub
    Private Sub Password_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Password.KeyPress
        If e.KeyChar = Chr(13) Then
            btnLogin.Focus()
        End If
    End Sub

    Private Sub FormLogin_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        kodepetugas.Focus()
    End Sub
End Class