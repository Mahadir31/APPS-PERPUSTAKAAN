﻿Imports MySql.Data.MySqlClient
Imports Microsoft.Reporting.WinForms
Public Class FormLaporan
    Private Sub FormLaporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call LoadReport()
        Me.ReportViewer1.RefreshReport()
    End Sub
    Sub LoadReport()
        'LAPORAN DATA PETUGAS
        ReportViewer1.RefreshReport()
        Dim DataPetugas As ReportDataSource
        With ReportViewer1.LocalReport
            .ReportPath = ""
            .DataSources.Clear()
        End With

        Da = New MySqlDataAdapter("Select * from tblpetugas", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblpetugas")

        DataPetugas = New ReportDataSource("DataSet1", Ds.Tables("tblpetugas"))
        ReportViewer1.LocalReport.DataSources.Add(DataPetugas)
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

        'LAPORAN DATA ANGGOTA
        Dim DataAnggota As ReportDataSource
        Da = New MySqlDataAdapter("Select * from tblanggota", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblanggota")

        DataAnggota = New ReportDataSource("DataSet2", Ds.Tables("tblanggota"))
        ReportViewer1.LocalReport.DataSources.Add(DataAnggota)
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

        'LAPORAN DATA BUKU
        Dim DataBuku As ReportDataSource
        Da = New MySqlDataAdapter("Select * from tblbuku", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblbuku")

        DataBuku = New ReportDataSource("DataSet3", Ds.Tables("tblbuku"))
        ReportViewer1.LocalReport.DataSources.Add(DataBuku)
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

        'LAPORAN DATA PINJAM
        Dim DataPinjam As ReportDataSource
        Da = New MySqlDataAdapter("Select * from tblpinjam", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblpinjam")

        DataPinjam = New ReportDataSource("DataSet4", Ds.Tables("tblpinjam"))
        ReportViewer1.LocalReport.DataSources.Add(DataPinjam)
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

        'LAPORAN DATA DETAIL PINJAM
        Dim DataDetailPinjam As ReportDataSource
        Da = New MySqlDataAdapter("Select * from tbldetailpinjam", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbldetailpinjam")

        DataDetailPinjam = New ReportDataSource("DataSet5", Ds.Tables("tbldetailpinjam"))
        ReportViewer1.LocalReport.DataSources.Add(DataDetailPinjam)
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

        'LAPORAN DATA KEMBALI
        Dim DataKembali As ReportDataSource
        Da = New MySqlDataAdapter("Select * from tblkembali", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tblkembali")

        DataKembali = New ReportDataSource("DataSet6", Ds.Tables("tblkembali"))
        ReportViewer1.LocalReport.DataSources.Add(DataKembali)
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)

        'LAPORAN DATA DETAIL KEMBALI
        Dim DataDetailKembali As ReportDataSource
        Da = New MySqlDataAdapter("Select * from tbldetailkembali", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "tbldetailkembali")

        DataDetailKembali = New ReportDataSource("DataSet7", Ds.Tables("tbldetailkembali"))
        ReportViewer1.LocalReport.DataSources.Add(DataDetailKembali)
        ReportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout)
    End Sub
End Class