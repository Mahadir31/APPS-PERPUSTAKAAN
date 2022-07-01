<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenuUtama
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FILE = New System.Windows.Forms.ToolStripMenuItem()
        Me.Login = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOut = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitTool = New System.Windows.Forms.ToolStripMenuItem()
        Me.MASTER = New System.Windows.Forms.ToolStripMenuItem()
        Me.Petugas = New System.Windows.Forms.ToolStripMenuItem()
        Me.Anggota = New System.Windows.Forms.ToolStripMenuItem()
        Me.Buku = New System.Windows.Forms.ToolStripMenuItem()
        Me.TRANSAKSI = New System.Windows.Forms.ToolStripMenuItem()
        Me.Peminjaman = New System.Windows.Forms.ToolStripMenuItem()
        Me.Pengembalian = New System.Windows.Forms.ToolStripMenuItem()
        Me.LAPORAN = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.StatusPetugas = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripStatusLabel1 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel2 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tgl_jam = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel3 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.KodePetugas = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel4 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.NamaPetugas = New System.Windows.Forms.ToolStripStatusLabel()
        Me.ToolStripStatusLabel5 = New System.Windows.Forms.ToolStripStatusLabel()
        Me.tmtgl_jam = New System.Windows.Forms.Timer(Me.components)
        Me.CETAKLAPORAN = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FILE, Me.MASTER, Me.TRANSAKSI, Me.LAPORAN})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(956, 24)
        Me.MenuStrip1.TabIndex = 6
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FILE
        '
        Me.FILE.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Login, Me.LogOut, Me.ToolStripMenuItem1, Me.ExitTool})
        Me.FILE.Name = "FILE"
        Me.FILE.Size = New System.Drawing.Size(40, 20)
        Me.FILE.Text = "FILE"
        '
        'Login
        '
        Me.Login.Name = "Login"
        Me.Login.Size = New System.Drawing.Size(114, 22)
        Me.Login.Text = "Login"
        '
        'LogOut
        '
        Me.LogOut.Name = "LogOut"
        Me.LogOut.Size = New System.Drawing.Size(114, 22)
        Me.LogOut.Text = "LogOut"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(111, 6)
        '
        'ExitTool
        '
        Me.ExitTool.Name = "ExitTool"
        Me.ExitTool.Size = New System.Drawing.Size(114, 22)
        Me.ExitTool.Text = "Exit"
        '
        'MASTER
        '
        Me.MASTER.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Petugas, Me.Anggota, Me.Buku})
        Me.MASTER.Name = "MASTER"
        Me.MASTER.Size = New System.Drawing.Size(63, 20)
        Me.MASTER.Text = "MASTER"
        '
        'Petugas
        '
        Me.Petugas.Name = "Petugas"
        Me.Petugas.Size = New System.Drawing.Size(120, 22)
        Me.Petugas.Text = "Petugas"
        '
        'Anggota
        '
        Me.Anggota.Name = "Anggota"
        Me.Anggota.Size = New System.Drawing.Size(120, 22)
        Me.Anggota.Text = "Anggota"
        '
        'Buku
        '
        Me.Buku.Name = "Buku"
        Me.Buku.Size = New System.Drawing.Size(120, 22)
        Me.Buku.Text = "Buku"
        '
        'TRANSAKSI
        '
        Me.TRANSAKSI.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Peminjaman, Me.Pengembalian})
        Me.TRANSAKSI.Name = "TRANSAKSI"
        Me.TRANSAKSI.Size = New System.Drawing.Size(79, 20)
        Me.TRANSAKSI.Text = "TRANSAKSI"
        '
        'Peminjaman
        '
        Me.Peminjaman.Name = "Peminjaman"
        Me.Peminjaman.Size = New System.Drawing.Size(150, 22)
        Me.Peminjaman.Text = "Peminjaman"
        '
        'Pengembalian
        '
        Me.Pengembalian.Name = "Pengembalian"
        Me.Pengembalian.Size = New System.Drawing.Size(150, 22)
        Me.Pengembalian.Text = "Pengembalian"
        '
        'LAPORAN
        '
        Me.LAPORAN.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CETAKLAPORAN})
        Me.LAPORAN.Name = "LAPORAN"
        Me.LAPORAN.Size = New System.Drawing.Size(73, 20)
        Me.LAPORAN.Text = "LAPORAN"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.LightGray
        Me.Label1.Font = New System.Drawing.Font("Stencil", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(475, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(397, 32)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "MENU UTAMA PERPUSTAKAAN"
        '
        'StatusPetugas
        '
        Me.StatusPetugas.Name = "StatusPetugas"
        Me.StatusPetugas.Size = New System.Drawing.Size(0, 17)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.White
        Me.StatusStrip1.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripStatusLabel1, Me.ToolStripStatusLabel2, Me.tgl_jam, Me.ToolStripStatusLabel3, Me.KodePetugas, Me.ToolStripStatusLabel4, Me.NamaPetugas, Me.ToolStripStatusLabel5, Me.StatusPetugas})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 428)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(956, 22)
        Me.StatusStrip1.TabIndex = 8
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripStatusLabel1
        '
        Me.ToolStripStatusLabel1.BackColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel1.LinkColor = System.Drawing.Color.DarkBlue
        Me.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1"
        Me.ToolStripStatusLabel1.Size = New System.Drawing.Size(170, 17)
        Me.ToolStripStatusLabel1.Text = "Pemrograman Visual Dasar I /"
        '
        'ToolStripStatusLabel2
        '
        Me.ToolStripStatusLabel2.BackColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2"
        Me.ToolStripStatusLabel2.Size = New System.Drawing.Size(113, 17)
        Me.ToolStripStatusLabel2.Text = "Kelompok II Kls A /"
        '
        'tgl_jam
        '
        Me.tgl_jam.BackColor = System.Drawing.Color.White
        Me.tgl_jam.Name = "tgl_jam"
        Me.tgl_jam.Size = New System.Drawing.Size(10, 17)
        Me.tgl_jam.Text = " "
        '
        'ToolStripStatusLabel3
        '
        Me.ToolStripStatusLabel3.BackColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3"
        Me.ToolStripStatusLabel3.Size = New System.Drawing.Size(53, 17)
        Me.ToolStripStatusLabel3.Text = "/ KODE :"
        '
        'KodePetugas
        '
        Me.KodePetugas.BackColor = System.Drawing.Color.White
        Me.KodePetugas.Name = "KodePetugas"
        Me.KodePetugas.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel4
        '
        Me.ToolStripStatusLabel4.BackColor = System.Drawing.Color.White
        Me.ToolStripStatusLabel4.Name = "ToolStripStatusLabel4"
        Me.ToolStripStatusLabel4.Size = New System.Drawing.Size(49, 17)
        Me.ToolStripStatusLabel4.Text = "NAMA :"
        '
        'NamaPetugas
        '
        Me.NamaPetugas.Name = "NamaPetugas"
        Me.NamaPetugas.Size = New System.Drawing.Size(0, 17)
        '
        'ToolStripStatusLabel5
        '
        Me.ToolStripStatusLabel5.Name = "ToolStripStatusLabel5"
        Me.ToolStripStatusLabel5.Size = New System.Drawing.Size(56, 17)
        Me.ToolStripStatusLabel5.Text = "STATUS :"
        '
        'tmtgl_jam
        '
        Me.tmtgl_jam.Enabled = True
        '
        'CETAKLAPORAN
        '
        Me.CETAKLAPORAN.Name = "CETAKLAPORAN"
        Me.CETAKLAPORAN.Size = New System.Drawing.Size(180, 22)
        Me.CETAKLAPORAN.Text = "CETAK LAPORAN"
        '
        'FrmMenuUtama
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.APPS_PERPUSTAKAAN.My.Resources.Resources.bg_perpus_1
        Me.ClientSize = New System.Drawing.Size(956, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "FrmMenuUtama"
        Me.ShowInTaskbar = False
        Me.Text = "MENU UTAMA PERPUSTAKAAN"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FILE As ToolStripMenuItem
    Friend WithEvents Login As ToolStripMenuItem
    Friend WithEvents LogOut As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripSeparator
    Friend WithEvents ExitTool As ToolStripMenuItem
    Friend WithEvents MASTER As ToolStripMenuItem
    Friend WithEvents Petugas As ToolStripMenuItem
    Friend WithEvents Anggota As ToolStripMenuItem
    Friend WithEvents Buku As ToolStripMenuItem
    Friend WithEvents TRANSAKSI As ToolStripMenuItem
    Friend WithEvents Peminjaman As ToolStripMenuItem
    Friend WithEvents Pengembalian As ToolStripMenuItem
    Friend WithEvents LAPORAN As ToolStripMenuItem
    Friend WithEvents Label1 As Label
    Friend WithEvents StatusPetugas As ToolStripStatusLabel
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents ToolStripStatusLabel1 As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel2 As ToolStripStatusLabel
    Friend WithEvents tgl_jam As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel3 As ToolStripStatusLabel
    Friend WithEvents KodePetugas As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel4 As ToolStripStatusLabel
    Friend WithEvents NamaPetugas As ToolStripStatusLabel
    Friend WithEvents ToolStripStatusLabel5 As ToolStripStatusLabel
    Friend WithEvents tmtgl_jam As Timer
    Friend WithEvents CETAKLAPORAN As ToolStripMenuItem
End Class
