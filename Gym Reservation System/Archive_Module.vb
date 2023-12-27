Imports System.Data.OleDb
Imports ClosedXML.Excel
Imports Excel = Microsoft.Office.Interop.Excel

Public Class Archive_Module
    'DBConnection
    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim source As String = "Data Source=C:\Users\Yves\source\repos\Gym Reservation System\Gym Reservation System\Reservation_System_Database.accdb;"
    Dim connect As New OleDbConnection
    'DataGridView
    Dim comm As New OleDbCommand
    Dim da, da1 As New OleDbDataAdapter
    Dim dt As New DataTable
    Dim dset As New DataSet
    'Etc
    Public ExportArchive = False
    Public SignOutArch = False
    Dim empty = False

    Private Sub Export_Module_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.ReservationArchiveTableAdapter.Fill(Me.Reservation_System_DatabaseDataSet.ReservationArchive)
        empty = False
        connect.ConnectionString = provider & source

        dgvExport.DataSource = Nothing
        dgvExport.Refresh()
        dt.Clear()
        dset.Clear()
        da = Nothing

        If Homepage_Module.authority = True Then
            btnReturn2.Show()
        Else
            btnReturn2.Hide()
        End If

        refreshdataview()

        If dgvExport.RowCount < 1 Then
            empty = True
        End If

        ExportArchive = False

    End Sub

    Function populate()
        connect.Open()
        da = New OleDbDataAdapter("Select * from ReservationArchive", connect)
        dset = New DataSet
        da.Fill(dset, "ReservationArchive")
        dgvExport.DataSource = dset.Tables("ReservationArchive").DefaultView
        dgvExport.ClearSelection()
        connect.Close()
        Return True
    End Function

    Private Sub refreshdataview()

        'Update/Refresh DataSet
        Dim archiveDataSet As New Reservation_System_DatabaseDataSet

        archiveDataSet.Clear()

        da1 = New OleDbDataAdapter("SELECT * FROM ReservationArchive", connect)
        da1.Fill(archiveDataSet, "ReservationArchive")

        dgvExport.DataSource = Nothing
        dgvExport.Refresh()

        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = provider & source

        End If

        Dim cmd As OleDbCommand
        cmd = connect.CreateCommand
        cmd.CommandType = CommandType.Text

        da = New OleDbDataAdapter("Select * from ReservationArchive", connect)
        da.Fill(dt)
        dgvExport.DataSource = dt
        populate()

        dgvExport.ClearSelection()

        'Me.ReservationArchiveTableAdapter.Fill(Me.Reservation_System_DatabaseDataSet.ReservationArchive)

        If dgvExport.RowCount > 1 Then
            dgvExport.FirstDisplayedScrollingRowIndex = dgvExport.RowCount - 1
        End If

        connect.Close()
    End Sub

    'panel move
    Private Property MoveForm2 As Boolean
    Private Property MoveForm_MousePosition2 As Point

    Private Sub PanelExport_MouseDown(sender As Object, e As MouseEventArgs) Handles PanelExport.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm2 = True
            Me.Cursor = Cursors.Default
            MoveForm_MousePosition2 = e.Location
        End If
    End Sub
    Private Sub PanelExport_MouseUp(sender As Object, e As MouseEventArgs) Handles PanelExport.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm2 = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub PanelExport_PousePlove(sender As Object, e As MouseEventArgs) Handles PanelExport.MouseMove
        If MoveForm2 Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition2)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        Reservation_Module.PanelLogBook.Hide()
        Reservation_Module.PanelReservation.Show()
        Reservation_Module.Show()
        txtSearchBar.Text = Nothing
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim bm As New Bitmap(Me.dgvExport.Width, Me.dgvExport.Height)
        dgvExport.DrawToBitmap(bm, New Rectangle(30, 30, Me.dgvExport.Width, Me.dgvExport.Height))
        e.Graphics.DrawImage(bm, 0, 0)

    End Sub

    Private Sub btnPrintOut_Click(sender As Object, e As EventArgs)

        PrintPreviewDialog1.ShowDialog()
        'PrintDocument1.Print()

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        If Staff_Module.exportStaff = True Then

            Reservation_Module.ExportRes = False

            Export_Module.btnReturn2.Hide()

        End If

        Reservation_Module.ExportRes = False
        ExportArchive = True
        txtSearchBar.Text = Nothing

        Export_Module.Show()
        Me.Close()

    End Sub

    Private Sub txtSearchBar_TextChanged(sender As Object, e As EventArgs) Handles txtSearchBar.TextChanged

        'auto capital first letter
        Dim ss As Integer = txtSearchBar.SelectionStart
        Dim sl As Integer = txtSearchBar.SelectionLength
        txtSearchBar.Text = StrConv(txtSearchBar.Text, VbStrConv.ProperCase)
        txtSearchBar.SelectionStart = ss
        txtSearchBar.SelectionLength = sl

        da = New OleDbDataAdapter("SELECT * FROM ReservationArchive where Identification like '" & txtSearchBar.Text & "%' or 
                                  BookingDate like '%" & txtSearchBar.Text & "%' or 
                                  PName like '%" & txtSearchBar.Text & "%' or 
                                  Status like '" & txtSearchBar.Text & "%'", connect)
        dset = New DataSet
        da.Fill(dset, "ReservationArchive")
        dgvExport.DataSource = dset.Tables("ReservationArchive").DefaultView

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim ans As Integer = MessageBox.Show("Are you sure?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If ans = DialogResult.Yes Then

            Threading.Thread.Sleep(1000)

            Homepage_Module.login()

            If Reservation_Module.ExportRes = True Then

                Reservation_Module.ExportRes = False

            ElseIf ExportArchive = True Then

                ExportArchive = False

            ElseIf Staff_Module.exportStaff = True Then

                Staff_Module.exportStaff = False

            End If

            SignOutArch = True
            Homepage_Module.Show()
            txtSearchBar.Text = Nothing
            Me.Close()

        End If

        Homepage_Module.ModuleDisable()
        Homepage_Module.chkShowPass.CheckState = CheckState.Unchecked
        Homepage_Module.authority = False

    End Sub

    Private Sub btnReturn2_Click(sender As Object, e As EventArgs) Handles btnReturn2.Click

        If ExportArchive = True Then

            ExportArchive = False

        End If

        Staff_Module.Show()
        Me.Close()

    End Sub

    Private Sub PictureBox14_Click(sender As Object, e As EventArgs) Handles PictureBox14.Click
        If Homepage_Module.authority = False Then

            Me.Close()
            Homepage_Module.Show()

        ElseIf Homepage_Module.authority = True Then

            Me.Close()
            Staff_Module.Show()

        End If
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        If empty = False Then
            connect.Open()
            Dim ans As Integer = MessageBox.Show("This will entirely erase all data from your Archive. Are you sure you want to continue anyway?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If ans = DialogResult.Yes Then
                Dim command As New OleDbCommand("DELETE FROM ReservationArchive", connect)
                command.ExecuteNonQuery()
                MessageBox.Show("Deleted all records successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                connect.Close()
                refreshdataview()
            Else
                connect.Close()
            End If
        Else

        End If
    End Sub
End Class