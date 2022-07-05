<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormLaporan
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource2 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource4 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource5 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource6 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Dim ReportDataSource7 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.TblbukuBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.TblpetugasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New APPS_PERPUSTAKAAN.DataSet1()
        Me.TblanggotaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblpinjamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TbldetailpinjamBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblkembaliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet11 = New APPS_PERPUSTAKAAN.DataSet1()
        Me.TbldetailkembaliBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.TblbukuBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblpetugasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblanggotaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblpinjamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldetailpinjamBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblkembaliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TbldetailkembaliBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.TblpetugasBindingSource
        ReportDataSource2.Name = "DataSet2"
        ReportDataSource2.Value = Me.TblanggotaBindingSource
        ReportDataSource3.Name = "DataSet3"
        ReportDataSource3.Value = Me.TblbukuBindingSource
        ReportDataSource4.Name = "DataSet4"
        ReportDataSource4.Value = Me.TblpinjamBindingSource
        ReportDataSource5.Name = "DataSet5"
        ReportDataSource5.Value = Me.TbldetailpinjamBindingSource
        ReportDataSource6.Name = "DataSet6"
        ReportDataSource6.Value = Me.TblkembaliBindingSource
        ReportDataSource7.Name = "DataSet7"
        ReportDataSource7.Value = Me.TbldetailkembaliBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource2)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource4)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource5)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource6)
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource7)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "APPS_PERPUSTAKAAN.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(426, 342)
        Me.ReportViewer1.TabIndex = 0
        '
        'TblpetugasBindingSource
        '
        Me.TblpetugasBindingSource.DataMember = "tblpetugas"
        Me.TblpetugasBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblanggotaBindingSource
        '
        Me.TblanggotaBindingSource.DataMember = "tblanggota"
        Me.TblanggotaBindingSource.DataSource = Me.DataSet1
        '
        'TblpinjamBindingSource
        '
        Me.TblpinjamBindingSource.DataMember = "tblpinjam"
        Me.TblpinjamBindingSource.DataSource = Me.DataSet1
        '
        'TbldetailpinjamBindingSource
        '
        Me.TbldetailpinjamBindingSource.DataMember = "tbldetailpinjam"
        Me.TbldetailpinjamBindingSource.DataSource = Me.DataSet1
        '
        'TblkembaliBindingSource
        '
        Me.TblkembaliBindingSource.DataMember = "tblkembali"
        Me.TblkembaliBindingSource.DataSource = Me.DataSet1
        '
        'DataSet11
        '
        Me.DataSet11.DataSetName = "DataSet1"
        Me.DataSet11.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TbldetailkembaliBindingSource
        '
        Me.TbldetailkembaliBindingSource.DataMember = "tbldetailkembali"
        Me.TbldetailkembaliBindingSource.DataSource = Me.DataSet11
        '
        'FormLaporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(426, 342)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormLaporan"
        Me.Text = "FormLaporan"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.TblbukuBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblpetugasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblanggotaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblpinjamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldetailpinjamBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblkembaliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TbldetailkembaliBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents TblpetugasBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents TblanggotaBindingSource As BindingSource
    Friend WithEvents TblbukuBindingSource As BindingSource
    Friend WithEvents TblpinjamBindingSource As BindingSource
    Friend WithEvents TbldetailpinjamBindingSource As BindingSource
    Friend WithEvents TblkembaliBindingSource As BindingSource
    Friend WithEvents TbldetailkembaliBindingSource As BindingSource
    Friend WithEvents DataSet11 As DataSet1
End Class
