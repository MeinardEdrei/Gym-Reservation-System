Imports System.Data.OleDb 'for database connection
Imports System.ComponentModel 'for sorting dgv
'for excel export
Imports ClosedXML.Excel
Imports Excel = Microsoft.Office.Interop.Excel
'pdf

Public Class Export_Module

    'DBConnection Reservation and Logbook
    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim source As String = "Data Source=C:\Users\Yves\source\repos\Gym Reservation System\Gym Reservation System\Reservation_System_Database.accdb;"
    'Dim connection As New OleDbConnection(My.Settings.Reservation_System_DatabaseConnectionString)
    'Dim source As String = "Data Source=" & Application.StartupPath & "\Reservation_System_Database.accdb;"
    Dim command As String
    Dim connect As New OleDbConnection
    'DataGridView
    Dim comm As New OleDbCommand
    Dim da, da1, da2, da3 As New OleDbDataAdapter
    Dim dt, dt1, dt2, dt3 As New DataTable
    Dim dset, dset2, dset3 As New DataSet
    'etc
    Public SignOutExport = False
    Dim Res = False, Arch = False
    'Printing Documents
    Private mRow As Integer = 0
    Private newPage As Boolean = True
    Dim pageCount = 1

    Public Sub Export_Module_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Reservation_System_DatabaseDataSet6.AuditLog' table. You can move, or remove it, as needed.
        Me.AuditLogTableAdapter.Fill(Me.Reservation_System_DatabaseDataSet6.AuditLog)
        'TODO: This line of code loads data into the 'Reservation_System_DatabaseDataSet4.ReservationArchive' table. You can move, or remove it, as needed.
        Me.ReservationArchiveTableAdapter.Fill(Me.Reservation_System_DatabaseDataSet4.ReservationArchive)
        'TODO: This line of code loads data into the 'Reservation_System_DatabaseDataSetStudRes.StudentReservation' table. You can move, or remove it, as needed.
        Me.StudentReservationTableAdapter.Fill(Me.Reservation_System_DatabaseDataSetStudRes.StudentReservation)
        'MsgBox("Staff Mod: " & Staff_Module.exportStaff & " Archive Mod: " & Archive_Module.ExportArchive & " Reservation Mod: " & Reservation_Module.ExportRes)
        'panelPreview.Controls.Add(Me.PrintPreviewControl1)

        'btnreturn2 for employees
        btnReturn2.Hide()
        'panelPreview.Hide()

        RefreshDB()

        With Me.ReportViewer1.LocalReport
            .DataSources.Clear()
            .ReportPath = "C:\Users\Yves\source\repos\Gym Reservation System\Gym Reservation System\ResReport.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt1))
        End With
        Me.ReportViewer1.RefreshReport()

        With Me.ReportViewer2.LocalReport
            .DataSources.Clear()
            .ReportPath = "C:\Users\Yves\source\repos\Gym Reservation System\Gym Reservation System\ArchReport.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet2", dt2))
        End With
        Me.ReportViewer2.RefreshReport()

        With Me.ReportViewer3.LocalReport
            .DataSources.Clear()
            .ReportPath = "C:\Users\Yves\source\repos\Gym Reservation System\Gym Reservation System\StaffReport.rdlc"
            .DataSources.Add(New Microsoft.Reporting.WinForms.ReportDataSource("DataSet3", dt3))
        End With
        Me.ReportViewer3.RefreshReport()

        If Reservation_Module.ExportRes = True And Staff_Module.exportStaff = True Then
            labelSection.Text = "LOGBOOK EXPORT SECTION"

            btnReturn2.Hide()
            'dgvArchive.Hide()
            'dgvRecords.Hide()
            'dgvLogBook.Show()
            btnReturn.Show()
            ReportViewer1.Show()
            ReportViewer2.Hide()
            ReportViewer3.Hide()

            refreshdataview()

        ElseIf Archive_Module.ExportArchive = True And Staff_Module.exportStaff = True Then
            labelSection.Text = "ARCHIVE EXPORT SECTION"

            btnReturn2.Hide()
            'dgvRecords.Hide()
            'dgvLogBook.Hide()
            'dgvArchive.Show()
            btnReturn.Show()
            ReportViewer2.Show()
            ReportViewer1.Hide()
            ReportViewer3.Hide()

            refreshdataview()
        ElseIf Reservation_Module.ExportRes = True And Staff_Module.exportStaff = False And Archive_Module.ExportArchive = False Then
            labelSection.Text = "LOGBOOK EXPORT SECTION"

            'dgvArchive.Hide()
            'dgvRecords.Hide()
            btnReturn.Hide()
            'dgvLogBook.Show()
            btnReturn2.Show()
            ReportViewer1.Show()
            ReportViewer2.Hide()
            ReportViewer3.Hide()

            refreshdataview()
            'MsgBox("Gumagana")
        ElseIf Archive_Module.ExportArchive = True And Staff_Module.exportStaff = False And Reservation_Module.ExportRes = False Then
            labelSection.Text = "ARCHIVE EXPORT SECTION"

            'dgvRecords.Hide()
            btnReturn.Hide()
            'dgvLogBook.Hide()
            'dgvArchive.Show()
            btnReturn2.Show()
            ReportViewer2.Show()
            ReportViewer1.Hide()
            ReportViewer3.Hide()

            refreshdataview()
            'MsgBox("Gumagana")
        ElseIf Staff_Module.exportStaff = True Then
            labelSection.Text = "STAFF EXPORT SECTION"

            'dgvRecords.Show()
            btnReturn.Show()
            'dgvLogBook.Hide()
            'dgvArchive.Hide()
            ReportViewer3.Show()
            ReportViewer1.Hide()
            ReportViewer2.Hide()

            refreshdataview()

        End If

        'dgvLogBook.ClearSelection()
        'dgvArchive.ClearSelection()
        'dgvRecords.ClearSelection()

        refreshdataview()

        If Archive_Module.ExportArchive = True Then
            Arch = True
        ElseIf Reservation_Module.ExportRes = True Then
            Res = True
        End If

    End Sub

    Private Sub RefreshDB()
        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = provider & source
        End If
        connect.Open()
        da1 = New OleDbDataAdapter("SELECT * FROM StudentReservation", connect)
        da2 = New OleDbDataAdapter("SELECT * FROM ReservationArchive", connect)
        da3 = New OleDbDataAdapter("SELECT * FROM AuditLog", connect)
        da1.Fill(dt1)
        da2.Fill(dt2)
        da3.Fill(dt3)
    End Sub

    Private Sub refreshdataview()
        dt.Clear()
        dset.Clear()
        da = Nothing

        'dgvLogBook.DataSource = Nothing
        'dgvLogBook.Refresh()

        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = provider & source
        End If

        Dim cmd As OleDbCommand
        cmd = connect.CreateCommand
        cmd.CommandType = CommandType.Text

        da = New OleDbDataAdapter("Select * from StudentReservation", connect)
        da.Fill(dt)
        'dgvLogBook.DataSource = dt

        If Reservation_Module.ExportRes = True Then

            populate()

        ElseIf Archive_Module.ExportArchive = True Then

            populate2()

        ElseIf Staff_Module.exportStaff = True Then

            populate3()

        End If

        autoscrollrows()

        connect.Close()
    End Sub

    Sub autoscrollrows()

        'dgvLogBook.FirstDisplayedScrollingRowIndex = dgvLogBook.RowCount - 1
        'dgvArchive.FirstDisplayedScrollingRowIndex = dgvArchive.RowCount - 1
        'dgvRecords.FirstDisplayedScrollingRowIndex = dgvRecords.RowCount - 1

    End Sub

    Function populate()
        dset.Clear()
        da = New OleDbDataAdapter("Select * from StudentReservation", connect)
        dset = New DataSet
        da.Fill(dset, "StudentReservation")
        'dgvLogBook.DataSource = dset.Tables("StudentReservation").DefaultView
        Return True
    End Function

    Function populate2()
        dset.Clear()
        da = New OleDbDataAdapter("Select * from ReservationArchive", connect)
        dset = New DataSet
        da.Fill(dset, "ReservationArchive")
        'dgvArchive.DataSource = dset.Tables("ReservationArchive").DefaultView
        Return True
    End Function

    Function populate3()
        dset.Clear()
        da = New OleDbDataAdapter("Select * from AuditLog", connect)
        dset = New DataSet
        da.Fill(dset, "AuditLog")
        'dgvRecords.DataSource = dset.Tables("AuditLog").DefaultView
        Return True
    End Function

    Private Sub btnExcel_Click(sender As Object, e As EventArgs) Handles btnExcel.Click

        'Update/Refresh DataSet
        Dim logbookDataSet As New Reservation_System_DatabaseDataSetStudRes
        Dim archiveDataSet As New Reservation_System_DatabaseDataSet4
        Dim auditlogDataSet As New Reservation_System_DatabaseDataSet6

        logbookDataSet.Clear()
        archiveDataSet.Clear()
        auditlogDataSet.Clear()

        da1 = New OleDbDataAdapter("SELECT * FROM StudentReservation", connect)
        da2 = New OleDbDataAdapter("SELECT * FROM ReservationArchive", connect)
        da3 = New OleDbDataAdapter("SELECT * FROM AuditLog", connect)

        da1.Fill(logbookDataSet, "StudentReservation")
        da2.Fill(archiveDataSet, "ReservationArchive")
        da3.Fill(auditlogDataSet, "AuditLog")

        'Export to Excel
        If Reservation_Module.ExportRes = True Then
            Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
                If sfd.ShowDialog() = DialogResult.OK Then
                    Try
                        Using workbook As XLWorkbook = New XLWorkbook()
                            workbook.Worksheets.Add(logbookDataSet.StudentReservation.CopyToDataTable(), "StudentReservation")
                            workbook.SaveAs(sfd.FileName)
                        End Using
                        MessageBox.Show("Exported to Excel Successfully.", "University of Makati", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try
                End If
            End Using
        ElseIf Archive_Module.ExportArchive = True Then
            Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
                If sfd.ShowDialog() = DialogResult.OK Then
                    Try
                        Using workbook As XLWorkbook = New XLWorkbook()
                            workbook.Worksheets.Add(archiveDataSet.ReservationArchive.CopyToDataTable(), "ReservationArchive")
                            workbook.SaveAs(sfd.FileName)
                        End Using
                        MessageBox.Show("Exported to Excel Successfully.", "University of Makati", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            End Using
        ElseIf Staff_Module.exportStaff = True Then
            Using sfd As SaveFileDialog = New SaveFileDialog() With {.Filter = "Excel Workbook|*.xlsx"}
                If sfd.ShowDialog() = DialogResult.OK Then
                    Try
                        Using workbook As XLWorkbook = New XLWorkbook()
                            workbook.Worksheets.Add(auditlogDataSet.AuditLog.CopyToDataTable(), "AuditLog")
                            workbook.SaveAs(sfd.FileName)
                        End Using
                        MessageBox.Show("Exported to Excel Successfully.", "University of Makati", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Catch ex As Exception
                        MsgBox(ex.ToString)
                    End Try
                End If
            End Using
        End If

    End Sub

    'Private Sub btnPreview_Click(sender As Object, e As EventArgs) Handles btnPreview.Click
    '    'MsgBox("Staff Mod: " & Staff_Module.exportStaff & " Archive Mod: " & Archive_Module.ExportArchive & " Reservation Mod: " & Reservation_Module.ExportRes)
    '    If Reservation_Module.ExportRes = True And Staff_Module.exportStaff = True Or Res = True Then

    '        'PrintPreviewDialog1.WindowState = FormWindowState.Maximized
    '        'PrintPreviewDialog1.StartPosition = FormStartPosition.CenterScreen
    '        'PrintPreviewDialog1.ShowDialog()

    '        'PrintPreviewDialog3.WindowState = FormWindowState.Maximized
    '        'PrintPreviewDialog3.ShowDialog()

    '        mRow = 0
    '        pageCount = 1
    '        newPage = True

    '        PrintPreviewControl1.Rows = 1
    '        PrintPreviewControl1.Document = PrintDocument3
    '        panelPreview.Show()

    '    ElseIf Archive_Module.ExportArchive = True And Staff_Module.exportStaff = True Or Arch = True Then

    '        'PrintPreviewDialog4.WindowState = FormWindowState.Maximized
    '        'PrintPreviewDialog4.ShowDialog()

    '        mRow = 0
    '        pageCount = 1
    '        newPage = True

    '        PrintPreviewControl1.Rows = 1
    '        PrintPreviewControl1.Document = PrintDocument4
    '        panelPreview.Show()

    '    ElseIf Staff_Module.exportStaff = True And Archive_Module.ExportArchive = False And Reservation_Module.ExportRes = False Then

    '        'PrintPreviewDialog5.WindowState = FormWindowState.Maximized
    '        'PrintPreviewDialog5.ShowDialog()

    '        mRow = 0
    '        pageCount = 1
    '        newPage = True

    '        PrintPreviewControl1.Rows = 1
    '        PrintPreviewControl1.Document = PrintDocument5
    '        panelPreview.Show()

    '    End If

    'End Sub

    'Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

    '    Dim bm As New Bitmap(Me.dgvLogBook.Width, Me.dgvLogBook.Height)
    '    dgvLogBook.DrawToBitmap(bm, New Rectangle(11, 11, Me.dgvLogBook.Width, Me.dgvLogBook.Height))
    '    'dgvLogBook.DrawToBitmap(bm, New Rectangle(0, 10, Me.dgvLogBook.Width, Me.dgvLogBook.Height))
    '    e.Graphics.DrawImage(bm, 0, 0)

    'End Sub

    'Private Sub PrintDocument2_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument2.PrintPage

    '    Dim bmm As New Bitmap(Me.dgvArchive.Width, Me.dgvArchive.Height)
    '    dgvArchive.DrawToBitmap(bmm, New Rectangle(11, 11, Me.dgvArchive.Width, Me.dgvArchive.Height))
    '    e.Graphics.DrawImage(bmm, 0, 0)

    'End Sub


    'Private Sub PrintDocument3_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument3.PrintPage

    '    ' Setting the Format

    '    Dim fnt As New Font("Arial", 11, FontStyle.Regular)
    '    Dim fnt2 As New Font("Arial", 13, FontStyle.Bold)

    '    Dim format As New StringFormat
    '    format.Alignment = StringAlignment.Center

    '    e.Graphics.DrawString("Page " & pageCount, New Font("Times New Roman", 11, FontStyle.Regular),
    '            Brushes.Black, New Point(800, 30), format) 'x, y
    '    e.Graphics.DrawString("University Of Makati", New Font("Times New Roman", 15, FontStyle.Bold),
    '            Brushes.Black, New Point(425, 80), format) 'x, y
    '    e.Graphics.DrawString("UMak Fitness Gym", New Font("Times New Roman", 15, FontStyle.Bold),
    '            Brushes.Black, New Point(425, 105), format) 'x, y
    '    e.Graphics.DrawString("Reservation Logbook", New Font("Times New Roman", 17, FontStyle.Bold),
    '            Brushes.Black, New Point(425, 170), format) 'x, y
    '    e.Graphics.DrawString("This data was generated at exactly " & DateAndTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"), New Font("Arial", 11, FontStyle.Regular),
    '            Brushes.Black, New Point(425, 1045), format) 'x, y

    '    Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
    '    fmt.LineAlignment = StringAlignment.Center
    '    fmt.Trimming = StringTrimming.EllipsisCharacter
    '    fmt.Alignment = StringAlignment.Center

    '    Dim y As Integer = 230
    '    Dim x As Integer = 150
    '    Dim h As Integer = 0

    '    Dim rc As Rectangle
    '    Dim row As DataGridViewRow

    '    If newPage Then
    '        row = dgvLogBook.Rows(mRow)
    '        x = 16

    '        ' Print Out Header 

    '        Dim umak As Image = My.Resources.ResourceManager.GetObject("umak_logo")
    '        Dim hsu As Image = My.Resources.ResourceManager.GetObject("hsu-logo")
    '        e.Graphics.DrawImage(umak, 170, 70, umak.Width - 260, umak.Height - 260) ' x, y
    '        e.Graphics.DrawImage(hsu, 600, 70, hsu.Width - 1340, hsu.Height - 1340) ' x, y

    '        For Each cell As DataGridViewCell In row.Cells

    '            If cell.Visible Then
    '                rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height + 10)
    '                e.Graphics.FillRectangle(Brushes.Black, rc)
    '                e.Graphics.DrawRectangle(Pens.Black, rc)

    '                e.Graphics.DrawString(dgvLogBook.Columns(cell.ColumnIndex).HeaderText, fnt2, Brushes.White, rc, fmt)

    '                x += rc.Width
    '                h = Math.Max(h, rc.Height)
    '            End If

    '        Next
    '        y += h
    '    End If

    '    newPage = False

    '    ' Print Out Data from DataGridView

    '    Dim displayNow As Integer
    '    For displayNow = mRow To dgvLogBook.RowCount - 1

    '        row = dgvLogBook.Rows(displayNow)
    '        x = 16
    '        h = 0

    '        For Each cell As DataGridViewCell In row.Cells
    '            If cell.Visible Then
    '                rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height + 10)
    '                e.Graphics.DrawRectangle(Pens.Black, rc)

    '                fmt.Alignment = StringAlignment.Near
    '                rc.Offset(10, 0)

    '                e.Graphics.DrawString(cell.FormattedValue.ToString(), fnt, Brushes.Black, rc, fmt)

    '                x += rc.Width
    '                h = Math.Max(h, rc.Height)

    '            End If
    '        Next
    '        y += h

    '        mRow = displayNow

    '        If y + h > e.MarginBounds.Bottom Then
    '            e.HasMorePages = True
    '            newPage = True
    '            pageCount += 1

    '            PrintPreviewControl1.Rows = pageCount
    '            Return
    '        End If
    '    Next
    'End Sub


    'Private Sub txtSearchBar1_TextChanged(sender As Object, e As EventArgs) 

    '    'auto capital first letter
    '    Dim ss As Integer = txtSearchBar1.SelectionStart
    '    Dim sl As Integer = txtSearchBar1.SelectionLength
    '    txtSearchBar1.Text = StrConv(txtSearchBar1.Text, VbStrConv.ProperCase)
    '    txtSearchBar1.SelectionStart = ss
    '    txtSearchBar1.SelectionLength = sl


    '    If Reservation_Module.ExportRes = True Then

    '        da = New OleDbDataAdapter("SELECT * FROM StudentReservation where Identification like '" & txtSearchBar1.Text & "%' or 
    '                              BookingDate like '%" & txtSearchBar1.Text & "%' or 
    '                              PName like '%" & txtSearchBar1.Text & "%' or 
    '                              Status like '" & txtSearchBar1.Text & "%'", connect)
    '        dset = New DataSet
    '        da.Fill(dset, "StudentReservation")
    '        dgvLogBook.DataSource = dset.Tables("StudentReservation").DefaultView

    '    ElseIf Archive_Module.ExportArchive = True Then

    '        da2 = New OleDbDataAdapter("SELECT * FROM ReservationArchive where Identification like '" & txtSearchBar1.Text & "%' or 
    '                              BookingDate like '%" & txtSearchBar1.Text & "%' or 
    '                              PName like '%" & txtSearchBar1.Text & "%' or 
    '                              Status like '" & txtSearchBar1.Text & "%'", connect)
    '        dset2 = New DataSet
    '        da2.Fill(dset2, "ReservationArchive")
    '        dgvArchive.DataSource = dset2.Tables("ReservationArchive").DefaultView

    '    ElseIf Staff_Module.exportStaff = True Then

    '        da3 = New OleDbDataAdapter("SELECT * FROM AuditLog where [Time] like '" & txtSearchBar1.Text & "%' or 
    '                              Account like '%" & txtSearchBar1.Text & "%' or 
    '                              [Position] like '%" & txtSearchBar1.Text & "%'", connect)
    '        dset2 = New DataSet
    '        da3.Fill(dset2, "AuditLog")
    '        dgvRecords.DataSource = dset2.Tables("AuditLog").DefaultView

    '    End If

    'End Sub

    'Private Sub PrintDocument4_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument4.PrintPage

    '    ' Setting the Format

    '    Dim fnt As New Font("Arial", 11, FontStyle.Regular)
    '    Dim fnt2 As New Font("Arial", 13, FontStyle.Bold)

    '    Dim format As New StringFormat
    '    format.Alignment = StringAlignment.Center

    '    e.Graphics.DrawString("Page " & pageCount, New Font("Times New Roman", 11, FontStyle.Regular),
    '            Brushes.Black, New Point(800, 30), format) 'x, y
    '    e.Graphics.DrawString("University Of Makati", New Font("Times New Roman", 15, FontStyle.Bold),
    '            Brushes.Black, New Point(425, 80), format) 'x, y
    '    e.Graphics.DrawString("UMak Fitness Gym", New Font("Times New Roman", 15, FontStyle.Bold),
    '            Brushes.Black, New Point(425, 105), format) 'x, y
    '    e.Graphics.DrawString("Logbook Archive Records", New Font("Times New Roman", 17, FontStyle.Bold),
    '            Brushes.Black, New Point(425, 170), format) 'x, y
    '    e.Graphics.DrawString("This data was generated at exactly " & DateAndTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"), New Font("Arial", 11, FontStyle.Regular),
    '            Brushes.Black, New Point(425, 1045), format) 'x, y

    '    Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
    '    fmt.LineAlignment = StringAlignment.Center
    '    fmt.Trimming = StringTrimming.EllipsisCharacter
    '    fmt.Alignment = StringAlignment.Center

    '    Dim y As Integer = 230
    '    Dim x As Integer = 150
    '    Dim h As Integer = 0

    '    Dim rc As Rectangle
    '    Dim row As DataGridViewRow

    '    If newPage Then
    '        row = dgvArchive.Rows(mRow)
    '        x = 16

    '        ' Print Out Header 

    '        Dim umak As Image = My.Resources.ResourceManager.GetObject("umak_logo")
    '        Dim hsu As Image = My.Resources.ResourceManager.GetObject("hsu-logo")
    '        e.Graphics.DrawImage(umak, 170, 70, umak.Width - 260, umak.Height - 260) ' x, y
    '        e.Graphics.DrawImage(hsu, 600, 70, hsu.Width - 1340, hsu.Height - 1340) ' x, y

    '        For Each cell As DataGridViewCell In row.Cells

    '            If cell.Visible Then
    '                rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height + 10)
    '                e.Graphics.FillRectangle(Brushes.Black, rc)
    '                e.Graphics.DrawRectangle(Pens.Black, rc)

    '                e.Graphics.DrawString(dgvArchive.Columns(cell.ColumnIndex).HeaderText, fnt2, Brushes.White, rc, fmt)

    '                x += rc.Width
    '                h = Math.Max(h, rc.Height)
    '            End If

    '        Next
    '        y += h
    '    End If

    '    newPage = False

    '    ' Print Out Data from DataGridView

    '    Dim displayNow As Integer
    '    For displayNow = mRow To dgvArchive.RowCount - 1

    '        row = dgvArchive.Rows(displayNow)
    '        x = 16
    '        h = 0

    '        For Each cell As DataGridViewCell In row.Cells
    '            If cell.Visible Then
    '                rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height + 10)
    '                e.Graphics.DrawRectangle(Pens.Black, rc)

    '                fmt.Alignment = StringAlignment.Near
    '                rc.Offset(10, 0)

    '                e.Graphics.DrawString(cell.FormattedValue.ToString(), fnt, Brushes.Black, rc, fmt)

    '                x += rc.Width
    '                h = Math.Max(h, rc.Height)

    '            End If
    '        Next
    '        y += h

    '        mRow = displayNow

    '        If y + h > e.MarginBounds.Bottom Then
    '            e.HasMorePages = True
    '            newPage = True
    '            pageCount += 1

    '            PrintPreviewControl1.Rows = pageCount
    '            Return
    '        End If
    '    Next
    'End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnReturn2_Click(sender As Object, e As EventArgs) Handles btnReturn2.Click

        Reservation_Module.ExportRes = False
            Archive_Module.ExportArchive = False
            Me.Close()
        Homepage_Module.Show()

    End Sub

    'Private Sub btnPReturn_Click(sender As Object, e As EventArgs) 
    '    panelPreview.Hide()
    'End Sub

    Private Sub btnSummary_Click(sender As Object, e As EventArgs)

        If Reservation_Module.ExportRes = True Then

            mRow = 0
            pageCount = 1
            newPage = True
            PrintDocument3.Print()

        ElseIf Archive_Module.ExportArchive = True Then

            mRow = 0
            pageCount = 1
            newPage = True
            PrintDocument4.Print()

        ElseIf Staff_Module.exportStaff = True Then

            mRow = 0
            pageCount = 1
            newPage = True
            PrintDocument5.Print()

        End If
    End Sub

    'Private Sub btnZoomIn_Click(sender As Object, e As EventArgs) 
    '    PrintPreviewControl1.Zoom += 0.25
    'End Sub

    'Private Sub btnZoomOut_Click(sender As Object, e As EventArgs) 
    '    PrintPreviewControl1.Zoom -= 0.25
    'End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnArchive_Click(sender As Object, e As EventArgs) Handles btnArchive.Click

        If Reservation_Module.ExportRes = True Then

            Reservation_Module.ExportRes = False

        ElseIf Archive_Module.ExportArchive = True Then

            Archive_Module.ExportArchive = False

        ElseIf Staff_Module.exportStaff = True Then

            'Staff_Module.exportStaff = False

        End If

        Archive_Module.Show()
        Me.Close()

    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click

        If Reservation_Module.ExportRes = True Then

            Reservation_Module.ExportRes = False
            'dgvLogBook.Hide()

        ElseIf Archive_Module.ExportArchive = True Then

            Archive_Module.ExportArchive = False
            'dgvArchive.Hide()

        ElseIf Staff_Module.exportStaff = True Then

            'Staff_Module.exportStaff = False
            'dgvRecords.Hide()

        End If

        Reservation_Module.PanelLogBook.Hide()
        Reservation_Module.PanelReservation.Show()
        Reservation_Module.Show()
        Me.Close()

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim ans As Integer = MessageBox.Show("Are you sure?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If ans = DialogResult.Yes Then

            Threading.Thread.Sleep(1000)

            SignOutExport = True

            Homepage_Module.login()

            If Reservation_Module.ExportRes = True Then

                Reservation_Module.ExportRes = False

            ElseIf Archive_Module.ExportArchive = True Then

                Archive_Module.ExportArchive = False

            ElseIf Staff_Module.exportStaff = True Then

                Staff_Module.exportStaff = False

            End If

            Homepage_Module.Show()
            Me.Close()

        End If

        Homepage_Module.ModuleDisable()
        Homepage_Module.chkShowPass.CheckState = CheckState.Unchecked
        Homepage_Module.authority = False

    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click

        If Reservation_Module.ExportRes = True Then

            Reservation_Module.ExportRes = False

        ElseIf Archive_Module.ExportArchive = True Then

            Archive_Module.ExportArchive = False

        ElseIf Staff_Module.exportStaff = True Then

            Staff_Module.exportStaff = False

        End If

        Staff_Module.panelRecords.Hide()
        Staff_Module.dgvRecords.Hide()
        Staff_Module.panelStaff.Show()
        Staff_Module.dgvAccounts.Show()
        Staff_Module.dgvAccounts.Height = 447
        Staff_Module.refreshdataview()
        Staff_Module.Show()
        Me.Close()

    End Sub


    'Private Sub PrintDocument5_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument5.PrintPage

    '    ' Setting the Format

    '    Dim fnt As New Font("Arial", 11, FontStyle.Regular)
    '    Dim fnt2 As New Font("Arial", 13, FontStyle.Bold)

    '    Dim format As New StringFormat
    '    format.Alignment = StringAlignment.Center

    '    e.Graphics.DrawString("Page " & pageCount, New Font("Times New Roman", 11, FontStyle.Regular),
    '            Brushes.Black, New Point(800, 30), format) 'x, y
    '    e.Graphics.DrawString("University Of Makati", New Font("Times New Roman", 15, FontStyle.Bold),
    '            Brushes.Black, New Point(425, 80), format) 'x, y
    '    e.Graphics.DrawString("UMak Fitness Gym", New Font("Times New Roman", 15, FontStyle.Bold),
    '            Brushes.Black, New Point(425, 105), format) 'x, y
    '    e.Graphics.DrawString("Staff Audit Log", New Font("Times New Roman", 17, FontStyle.Bold),
    '            Brushes.Black, New Point(425, 170), format) 'x, y
    '    e.Graphics.DrawString("This data was generated at exactly " & DateAndTime.Now.ToString("dd/MM/yyyy hh:mm:ss tt"), New Font("Arial", 11, FontStyle.Regular),
    '            Brushes.Black, New Point(425, 1045), format) 'x, y
    '    '440

    '    Dim fmt As StringFormat = New StringFormat(StringFormatFlags.LineLimit)
    '    fmt.LineAlignment = StringAlignment.Center
    '    fmt.Trimming = StringTrimming.EllipsisCharacter
    '    fmt.Alignment = StringAlignment.Center

    '    Dim y As Integer = 230
    '    Dim x As Integer = 150
    '    Dim h As Integer = 0

    '    Dim rc As Rectangle
    '    Dim row As DataGridViewRow

    '    If newPage Then
    '        row = dgvRecords.Rows(mRow)
    '        x = 100

    '        ' Print Out Header 

    '        Dim umak As Image = My.Resources.ResourceManager.GetObject("umak_logo")
    '        Dim hsu As Image = My.Resources.ResourceManager.GetObject("hsu-logo")
    '        e.Graphics.DrawImage(umak, 170, 70, umak.Width - 260, umak.Height - 260) ' x, y
    '        e.Graphics.DrawImage(hsu, 600, 70, hsu.Width - 1340, hsu.Height - 1340) ' x, y

    '        For Each cell As DataGridViewCell In row.Cells

    '            If cell.Visible Then

    '                rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height + 10)
    '                e.Graphics.FillRectangle(Brushes.Black, rc) 'header fill color
    '                e.Graphics.DrawRectangle(Pens.Black, rc)

    '                fmt.Alignment = StringAlignment.Center
    '                rc.Offset(10, 0)

    '                e.Graphics.DrawString(dgvRecords.Columns(cell.ColumnIndex).HeaderText, fnt2, Brushes.White, rc, fmt) ' header text 

    '                x += rc.Width
    '                h = Math.Max(h, rc.Height)
    '            End If

    '        Next
    '        y += h
    '    End If

    '    newPage = False

    '    ' Print Out Data from DataGridView

    '    Dim displayNow As Integer = 0
    '    For displayNow = mRow To dgvRecords.RowCount - 1

    '        row = dgvRecords.Rows(displayNow)
    '        x = 100
    '        h = 0

    '        For Each cell As DataGridViewCell In row.Cells

    '            If cell.Visible Then

    '                rc = New Rectangle(x, y, cell.Size.Width, cell.Size.Height + 10)
    '                e.Graphics.DrawRectangle(Pens.Black, rc)

    '                fmt.Alignment = StringAlignment.Near
    '                rc.Offset(10, 0)

    '                e.Graphics.DrawString(cell.FormattedValue.ToString(), fnt, Brushes.Black, rc, fmt)

    '                x += rc.Width
    '                h = Math.Max(h, rc.Height)

    '            End If
    '        Next
    '        y += h

    '        'mRow = displayNow + 1 out of range index
    '        mRow = displayNow

    '        If y + h > e.MarginBounds.Bottom Then
    '            e.HasMorePages = True
    '            newPage = True
    '            pageCount += 1

    '            PrintPreviewControl1.Rows = pageCount

    '            Return
    '        End If
    '    Next
    'End Sub
End Class