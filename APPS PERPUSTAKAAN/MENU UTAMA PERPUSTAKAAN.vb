Public Class FrmMenuUtama
    Sub Terkunci()
        Login.Enabled = True
        LogOut.Enabled = False
        ExitTool.Enabled = False
        MASTER.Enabled = False
        TRANSAKSI.Enabled = False
        LAPORAN.Enabled = False
    End Sub
    Private Sub FrmMenuUtama_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Terkunci()
    End Sub

    Private Sub Login_Click(sender As Object, e As EventArgs) Handles Login.Click
        FormLogin.Show()
    End Sub

    Private Sub LogOut_Click(sender As Object, e As EventArgs) Handles LogOut.Click
        Call Terkunci()
        ExitTool.Enabled = True
    End Sub

    Private Sub ExitTool_Click(sender As Object, e As EventArgs) Handles ExitTool.Click
        End
    End Sub

    Private Sub tmtgl_jam_Tick(sender As Object, e As EventArgs) Handles tmtgl_jam.Tick
        tgl_jam.Text = Format(Now, "dd/MMMM/yyyy") & " | " & Format(Now, "HH:mm:ss")
    End Sub
End Class
