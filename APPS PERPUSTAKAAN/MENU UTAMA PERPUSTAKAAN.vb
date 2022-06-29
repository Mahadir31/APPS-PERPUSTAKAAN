﻿Public Class FrmMenuUtama
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
        FormLogin.ShowDialog()
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

    Private Sub MASTER_Click(sender As Object, e As EventArgs) Handles MASTER.Click

    End Sub

    Private Sub Petugas_Click(sender As Object, e As EventArgs) Handles Petugas.Click
        FormPetugas.ShowDialog()
    End Sub

    Private Sub Anggota_Click(sender As Object, e As EventArgs) Handles Anggota.Click
        FormAnggota.ShowDialog()
    End Sub

    Private Sub Buku_Click(sender As Object, e As EventArgs) Handles Buku.Click
        FormBuku.ShowDialog()
    End Sub

    Private Sub Peminjaman_Click(sender As Object, e As EventArgs) Handles Peminjaman.Click
        FormPeminjaman.ShowDialog()
    End Sub
End Class
