Imports System.Data.OleDb 'for database connection
Imports System.ComponentModel 'for sorting dgv
'for excel export
Imports ClosedXML.Excel
Imports Excel = Microsoft.Office.Interop.Excel


Public Class Reservation_Module
    'DBConnection Reservation and Logbook
    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim source As String = "Data Source=C:\Users\Yves\source\repos\Gym Reservation System\Gym Reservation System\Reservation_System_Database.accdb;"
    'Dim connection As New OleDbConnection(My.Settings.Reservation_System_DatabaseConnectionString)
    'Dim source As String = "Data Source=" & Application.StartupPath & "\Reservation_System_Database.accdb;"
    Dim command As String
    Dim connect As New OleDbConnection
    'DataGridView
    Dim comm As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim dt As New DataTable
    Dim dset As New DataSet
    'Date
    Dim StrDate As String = Date.Now.ToString("dd/MM/yyyy")
    'etc
    Dim cnt = 0
    Dim cntAvailability = False
    Public SignOutRes = False
    'Reservation
    Dim cntReserve As Integer
    Dim cntR As Integer
    'check availability
    Dim cntTime = 1
    Dim unavailable = False
    'Export
    Public ExportRes = False
    'CheckBox
    Private headerChk As CheckBox = New CheckBox()
    Private chk As CheckBox = New CheckBox()

    Private Sub refreshdataview()
        dt.Clear()
        dset.Clear()
        da = Nothing

        dgvLogBook.DataSource = Nothing
        dgvLogBook.Refresh()

        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = provider & source

        End If

        Dim cmd As OleDbCommand
        cmd = connect.CreateCommand
        cmd.CommandType = CommandType.Text

        da = New OleDbDataAdapter("Select * from StudentReservation", connect)
        da.Fill(dt)
        dgvLogBook.DataSource = dt
        populate()

        autoscrollrows()

        connect.Close()
    End Sub

    Private Sub Reservation_Module_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Reservation_System_DatabaseDataSet.StudentReservation' table. You can move, or remove it, as needed.
        'Me.StudentReservationTableAdapter.Fill(Me.Reservation_System_DatabaseDataSet.StudentReservation)

        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = provider & source
        End If

        dgvLogBook.Height = 325

        PanelLogBook.Hide()
        HdrLogbook1.Hide()
        PanelReservation.Show()
        cboTime.Text = "Select"
        cboStatus.Text = "Select"
        cboSearch.Text = "Search by:"
        chkToday.Checked = CheckState.Unchecked
        PanelDetails.Hide()
        PanelEmployee.Hide()
        PanelOutsider.Hide()
        PanelRNum.Hide()
        PanelAvailable.Hide()
        PanelNAvailable.Hide()
        PanelReserved.Hide()

        refreshdataview()

        'checkbox
        Dim chkbox1 As New DataGridViewCheckBoxColumn
        chkbox1.Width = 35
        chkbox1.Name = "chk"
        chkbox1.HeaderText = " "

        dgvLogBook.Columns.Insert(0, chkbox1)

        autocompID()
        autocompName()

        txtStudentID.Text = StrConv(txtStudentID.Text, vbProperCase)

        'checkbox header
        Dim headerlocation As Point = dgvLogBook.GetCellDisplayRectangle(0, -1, True).Location
        chk.Location = New Point(headerlocation.X + 62, headerlocation.Y + 5)
        chk.Size = New Size(15, 15)
        chk.BackColor = Color.White
        AddHandler chk.Click, AddressOf chk_Clicked
        dgvLogBook.Controls.Add(chk)

        'date
        dtpDate.Format = DateTimePickerFormat.Custom
        dtpDate.CustomFormat = "yyyy/MM/dd"

        ExportRes = False

    End Sub

    Sub chk_Clicked(sender As Object, e As EventArgs)
        dgvLogBook.EndEdit()
        For Each row As DataGridViewRow In dgvLogBook.Rows
            Dim chkbox2 As DataGridViewCheckBoxCell = (TryCast(row.Cells("chk"), DataGridViewCheckBoxCell))
            chkbox2.Value = chk.Checked
        Next
    End Sub

    Sub autoscrollrows()
        If cntR > 1 Then
            dgvLogBook.FirstDisplayedScrollingRowIndex = dgvLogBook.RowCount - 1
        End If
    End Sub

    Sub autocompName()
        'txtName
        Dim command3 As New OleDbCommand("SELECT PName FROM StudentReservation", connect)
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(command3)
        ds.Clear()
        da.Fill(ds, "PName")
        Dim column1 As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            column1.Add(ds.Tables(0).Rows(i)("PName").ToString())
        Next
        txtName.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtName.AutoCompleteCustomSource = column1
        txtName.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub

    Sub autocompID()
        'txtName
        Dim command3 As New OleDbCommand("SELECT Identification FROM StudentReservation", connect)
        Dim ds As New DataSet
        Dim da As New OleDbDataAdapter(command3)
        ds.Clear()
        da.Fill(ds, "Identification")
        Dim column1 As New AutoCompleteStringCollection
        Dim i As Integer
        For i = 0 To ds.Tables(0).Rows.Count - 1
            column1.Add(ds.Tables(0).Rows(i)("Identification").ToString())
        Next
        txtStudentID.AutoCompleteSource = AutoCompleteSource.CustomSource
        txtStudentID.AutoCompleteCustomSource = column1
        txtStudentID.AutoCompleteMode = AutoCompleteMode.SuggestAppend
    End Sub

    Function populate()
        dset.Clear()
        da = New OleDbDataAdapter("Select * from StudentReservation", connect)
        dset = New DataSet
        da.Fill(dset, "StudentReservation")
        dgvLogBook.DataSource = dset.Tables("StudentReservation").DefaultView
        Return True
    End Function

    Public Sub clearLogbook()
        comboboxTime.Text = ""
        txtPName.Text = ""
        comboboxStatus.Text = ""
        txtIdentification.Text = ""
    End Sub

    Public Sub clearReservation()
        cboTime.Text = "Select"
        txtName.Text = Nothing
        cboStatus.Text = "Select"
        txtStudentID.Text = Nothing
        txtEmpID.Text = Nothing
        txtOutsiderID.Text = Nothing
    End Sub

    'move panel
    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point
    Private Sub Homepage_MouseDown(sender As Object, e As MouseEventArgs) Handles HdrReservation.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.Default
            MoveForm_MousePosition = e.Location
        End If
    End Sub
    Private Sub Homepage_MouseUp(sender As Object, e As MouseEventArgs) Handles HdrReservation.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Homepage_PousePlove(sender As Object, e As MouseEventArgs) Handles HdrReservation.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Private Sub btnHome_Click(sender As Object, e As EventArgs)
        'Me.StudentReservationTableAdapter.Fill(Me.Reservation_System_DatabaseDataSet.StudentReservation)
        Homepage_Module.Show()
        PanelAvailable.Hide()
        PanelNAvailable.Hide()
        txtSearchBar.Text = Nothing
        Me.Close()
    End Sub

    Private Sub btnReserve_Click(sender As Object, e As EventArgs) Handles btnReserve.Click

        'Reservation Section

        If connect.State = ConnectionState.Closed Then
            connect.Open()
        End If

        If unavailable = True Then
            MessageBox.Show("Invalid Reservation. The Date and Time you've chosen are unavailable", "University of Makati", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            PanelAvailable.Hide()
            PanelNAvailable.Hide()
            cboStatus.Text = "Select"
            cboTime.Text = "Select"
            txtName.Text = Nothing
            PanelEmployee.Hide()
            PanelOutsider.Hide()
            unavailable = False
        ElseIf cntAvailability = False Then
            MessageBox.Show("Please check your schedule's Availability.", "University of Makati", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cboTime.Text = "Select"
            PanelAvailable.Hide()
            PanelNAvailable.Hide()
        ElseIf cboTime.Text = "Select" Or txtName.Text = Nothing Or cboStatus.Text = "Select" Or cboTime.Text = Nothing Or cboStatus.Text = Nothing And cntAvailability = True Then
            MessageBox.Show("Entries cannot be empty.", "University of Makati", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            PanelAvailable.Hide()
            PanelNAvailable.Hide()
            cboTime.Text = "Select"
            cboStatus.Text = "Select"
            cntAvailability = False
        ElseIf cboTime.Text <> "Select" Or txtName.Text <> Nothing Or cboStatus.Text <> "Select" Or cnt < 3 Then
            Try

                If cboStatus.SelectedItem.ToString = "Employee" Or cboStatus.SelectedItem.ToString = "Outsider" Then
                    txtStudentID.Text = "123456789"
                End If

                If txtStudentID.Text = Nothing Then
                    MessageBox.Show("Entries cannot be empty.", "University of Makati", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    PanelAvailable.Hide()
                    PanelNAvailable.Hide()
                    cboTime.Text = "Select"
                    cboStatus.Text = "Select"
                ElseIf txtStudentID.Text.Length > 9 Or txtStudentID.Text.Length <= 1 Or txtStudentID.Text.Length < 9 Or cnt = 3 Then
                    cnt = cnt + 1
                    If cnt = 3 Then
                        MessageBox.Show("Invalid Student Identification.", "University of Makati", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        clearReservation()
                        cnt = 0
                    Else
                        MessageBox.Show("Invalid Student Identification.", "University of Makati", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                        txtStudentID.Text = Nothing
                        'MsgBox(cnt)
                    End If
                Else
                    Dim readerR As OleDbDataReader = Nothing
                    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Yves\source\repos\Gym Reservation System\Gym Reservation System\Reservation_System_Database.accdb;")
                    con.Open()
                    Dim query1 As String = "Select ReserveNum from StudentReservation"
                    Dim command1 As New OleDbCommand(query1, con)

                    readerR = command1.ExecuteReader

                    cntR = Nothing

                    'Check Slots Date
                    While readerR.Read
                        cntR += 1
                    End While

                    'If cntR = 11 Then
                    '    cntR += 1
                    'End If

                    Using create As New OleDbCommand("INSERT INTO StudentReservation([ReserveNum],[Identification],[BookingDate],[BookingTime],[PName],[Status])VALUES(@ReserveNum,@Identification,@BookingDate,@BookingTIme,@PName,@Status)", connect)

                        Dim cntRead
                        cntRead = cntR + 1

                        create.Parameters.AddWithValue("@ReserveNum", OleDbType.VarChar).Value = cntRead

                        If cboStatus.SelectedItem.ToString = "Student" Then
                            create.Parameters.AddWithValue("@Identification", OleDbType.VarChar).Value = txtStudentID.Text.Trim
                        ElseIf cboStatus.SelectedItem.ToString = "Employee" Then
                            create.Parameters.AddWithValue("@Identification", OleDbType.VarChar).Value = txtEmpID.Text.Trim
                        ElseIf cboStatus.SelectedItem.ToString = "Outsider" Then
                            create.Parameters.AddWithValue("@Identification", OleDbType.VarChar).Value = txtOutsiderID.Text.Trim
                        End If

                        create.Parameters.AddWithValue("@BookingDate", OleDbType.VarChar).Value = dtpDate.Text.Trim
                        create.Parameters.AddWithValue("@BookingTime", OleDbType.VarChar).Value = cboTime.SelectedItem.Trim
                        create.Parameters.AddWithValue("@PName", OleDbType.VarChar).Value = txtName.Text.Trim
                        create.Parameters.AddWithValue("@Status", OleDbType.VarChar).Value = cboStatus.SelectedItem.Trim
                        If create.ExecuteNonQuery() Then

                            Me.StudentReservationTableAdapter.Fill(Reservation_System_DatabaseDataSet.StudentReservation)

                            'MessageBox.Show("Student Reserved", "University of Makati", MessageBoxButtons.OK, MessageBoxIcon.Information)
                            cboTime.Text = "Select"
                            txtName.Clear()
                            cboStatus.Text = "Select"
                            txtStudentID.Clear()
                            txtEmpID.Clear()
                            txtOutsiderID.Clear()
                            PanelEmployee.Hide()
                            PanelOutsider.Hide()
                            PanelAvailable.Hide()
                            PanelNAvailable.Hide()
                            PanelReserved.Show()
                            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
                            'PanelReserved.Hide()
                        End If
                    End Using
                End If

            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnLogbook_Click(sender As Object, e As EventArgs) Handles btnLogbook.Click

        If txtStudentID.Text = Nothing And cboTime.Text = "Select" And txtName.Text = Nothing And cboStatus.Text = "Select" Or (cboTime.Text = Nothing And cboStatus.Text = Nothing) Then
            refreshdataview()

            HdrLogbook1.Show()
            PanelLogBook.Show()
            'dgvLogBook.Sort(dgvLogBook.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
            PanelReservation.Hide()
        ElseIf txtStudentID.Text <> Nothing Or cboTime.Text <> "Select" Or txtName.Text <> Nothing Or cboStatus.Text <> "Select" Or cboTime.Text <> Nothing Or cboStatus.Text <> Nothing Then

            Dim ans As Integer = MessageBox.Show("Do you want to save your entries?", "University of Makati GYM", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If ans = DialogResult.No Then
                refreshdataview()

                HdrLogbook1.Show()
                PanelLogBook.Show()
                'dgvLogBook.Sort(dgvLogBook.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                PanelReservation.Hide()
                clearReservation()
            ElseIf ans = DialogResult.Yes Then
                refreshdataview()

                HdrLogbook1.Show()
                PanelLogBook.Show()
                'dgvLogBook.Sort(dgvLogBook.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
                PanelReservation.Hide()
            End If
        End If
        dgvLogBook.ClearSelection()
        PanelAvailable.Hide()
        PanelNAvailable.Hide()
        PanelReserved.Hide()
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click

        PanelReserved.Hide()
        PanelNAvailable.Hide()
        PanelAvailable.Hide()

        cntTime = Nothing
        Dim readerTime As OleDbDataReader = Nothing
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Yves\source\repos\Gym Reservation System\Gym Reservation System\Reservation_System_Database.accdb;")

        'Time
        con.Open()
        Dim query2 As String = "Select BookingDate,BookingTime from StudentReservation where BookingDate='" & dtpDate.Text & "' And BookingTime='" & cboTime.Text & "'"
        Dim command2 As New OleDbCommand(query2, con)

        readerTime = command2.ExecuteReader

        'Check Slots Time
        While readerTime.Read
            cntTime += 1
        End While

        'MsgBox(cntTime)

        If cboTime.Text = Nothing Or cboTime.Text = "Select" Then
            MessageBox.Show("Entries cannot be empty.", "University of Makati", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboTime.Text = "Select"
        ElseIf cboTime.Text = "8:30 - 10:00 AM" Or cboTime.Text = "10:00 - 11:30 AM" Or cboTime.Text = "1:30 - 2:30 PM" Or cboTime.Text = "2:30 - 3:30 PM" Then
            If cntTime = 20 Then
                PanelNAvailable.Show()
                My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
                unavailable = True
                'MessageBox.Show("Please choose another Date and Time", "FULL SLOT", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                PanelAvailable.Show()
                My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Asterisk)
                'MessageBox.Show("Available.", "University of Makati", MessageBoxButtons.OK, MessageBoxIcon.Information)
                cntAvailability = True
            End If
        Else
            MessageBox.Show("Invalid Entry.", "University of Makati", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboTime.Text = "Select"
        End If


    End Sub

    Private Sub txtName_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged
        Dim ss As Integer = txtName.SelectionStart
        Dim sl As Integer = txtName.SelectionLength
        txtName.Text = StrConv(txtName.Text, VbStrConv.ProperCase)
        txtName.SelectionStart = ss
        txtName.SelectionLength = sl
    End Sub

    Private Sub txtStudentID_TextChanged(sender As Object, e As EventArgs) Handles txtStudentID.TextChanged
        Dim ss As Integer = txtStudentID.SelectionStart
        Dim sl As Integer = txtStudentID.SelectionLength
        txtStudentID.Text = StrConv(txtStudentID.Text, VbStrConv.ProperCase)
        txtStudentID.SelectionStart = ss
        txtStudentID.SelectionLength = sl
    End Sub

    Private Sub cboStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboStatus.SelectedIndexChanged

        If cboStatus.SelectedItem.ToString = "Student" Then
            PanelEmployee.Hide()
            PanelOutsider.Hide()
        End If

        If cboStatus.SelectedItem.ToString = "Employee" Then
            PanelEmployee.Show()
            PanelOutsider.Hide()
            txtEmpID.Text = "Default"
            txtEmpID.Enabled = False
        End If

        If cboStatus.SelectedItem.ToString = "Outsider" Then
            PanelOutsider.Show()
            txtOutsiderID.Text = "Default"
            txtOutsiderID.Enabled = False
        End If
    End Sub

    Private Sub btnReturn_Click_1(sender As Object, e As EventArgs) Handles btnReturn.Click
        'reservation section
        PanelReservation.Show()
        cboSearch.Text = "Search by:"
        'logbook section

        dgvLogBook.Height = 325

        PanelLogBook.Hide()
        HdrLogbook1.Hide()
        PanelDetails.Hide()
        txtRNum.Clear()
        txtSearchBar.Clear()

        If cboStatus.Text = "Select" Then
            PanelEmployee.Hide()
            PanelOutsider.Hide()
        End If

        autocompID()
        autocompName()

    End Sub

    Private Sub txtSearchBar_TextChanged_1(sender As Object, e As EventArgs) Handles txtSearchBar.TextChanged
        clearLogbook()

        If txtSearchBar.Text = Nothing Then
            cboSearch.Text = "Search by:"
            refreshdataview()
        End If

        'auto capital first letter
        Dim ss As Integer = txtSearchBar.SelectionStart
        Dim sl As Integer = txtSearchBar.SelectionLength
        txtSearchBar.Text = StrConv(txtSearchBar.Text, VbStrConv.ProperCase)
        txtSearchBar.SelectionStart = ss
        txtSearchBar.SelectionLength = sl

        Dim searchby As Boolean = False

        'cboSearch.Text = Nothing
        'cboSearch.Text = "Search by:"
        If cboSearch.Text = "Search by:" Then
            da = New OleDbDataAdapter("SELECT * FROM StudentReservation where Identification like '" & txtSearchBar.Text & "%' or 
                                  BookingDate like '%" & txtSearchBar.Text & "%' or 
                                  PName like '%" & txtSearchBar.Text & "%' or 
                                  Status like '" & txtSearchBar.Text & "%'", connect)
            dset = New DataSet
            da.Fill(dset, "StudentReservation")
            dgvLogBook.DataSource = dset.Tables("StudentReservation").DefaultView
            searchby = True
        ElseIf cboSearch.Text = Nothing Then
            cboSearch.Text = "Search by:"
        End If


        If cboSearch.Text = "Student ID" Then
            da = New OleDbDataAdapter("SELECT * FROM StudentReservation where Identification like '" & txtSearchBar.Text & "%'", connect)
            dset = New DataSet
            da.Fill(dset, "StudentReservation")
            dgvLogBook.DataSource = dset.Tables("StudentReservation").DefaultView
        ElseIf cboSearch.Text = "Booking Date" Then
            da = New OleDbDataAdapter("SELECT * FROM StudentReservation where BookingDate like '" & txtSearchBar.Text & "%'", connect)
            dset = New DataSet
            da.Fill(dset, "StudentReservation")
            dgvLogBook.DataSource = dset.Tables("StudentReservation").DefaultView
        ElseIf cboSearch.Text = "Student Name" Then
            da = New OleDbDataAdapter("SELECT * FROM StudentReservation where PName like '%" & txtSearchBar.Text & "%'", connect)
            dset = New DataSet
            da.Fill(dset, "StudentReservation")
            dgvLogBook.DataSource = dset.Tables("StudentReservation").DefaultView
        ElseIf cboSearch.Text = "Status" Then
            da = New OleDbDataAdapter("SELECT * FROM StudentReservation where Status like '" & txtSearchBar.Text & "%'", connect)
            dset = New DataSet
            da.Fill(dset, "StudentReservation")
            dgvLogBook.DataSource = dset.Tables("StudentReservation").DefaultView
        ElseIf searchby = False Then
            'MessageBox.Show("Search by Unrecognized by the System.", "University of Makati", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cboSearch.Text = "Search by:"
            da = New OleDbDataAdapter("SELECT * FROM StudentReservation where Identification like '" & txtSearchBar.Text & "%' or 
                                  BookingDate like '%" & txtSearchBar.Text & "%' or 
                                  PName like '%" & txtSearchBar.Text & "%' or 
                                  Status like '" & txtSearchBar.Text & "%'", connect)
            dset = New DataSet
            da.Fill(dset, "StudentReservation")
            dgvLogBook.DataSource = dset.Tables("StudentReservation").DefaultView
        End If
        'cboSearch.SelectedItem.ToString <> "Search by:" And cboSearch.SelectedItem.ToString <> "Student ID" And cboSearch.SelectedItem.ToString <> "Booking Date" And cboSearch.SelectedItem.ToString <> "Student Name" And cboSearch.SelectedItem.ToString <> "Status"
    End Sub

    Private Sub chkToday_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkToday.CheckedChanged
        'MsgBox(StrDate)
        If chkToday.CheckState = CheckState.Checked Then
            da = New OleDbDataAdapter("SELECT * FROM StudentReservation where BookingDate like '" & StrDate & "'", connect)
            dset = New DataSet
            da.Fill(dset, "StudentReservation")
            dgvLogBook.DataSource = dset.Tables("StudentReservation").DefaultView
        ElseIf chkToday.CheckState = CheckState.Unchecked Then
            refreshdataview()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        'DBConnection Archive
        If connect.State = ConnectionState.Closed Then

            connect.ConnectionString = provider & source

        End If

        Dim ans As Integer = MessageBox.Show("Do you want to delete this data?", "University of Makati GYM", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = DialogResult.No Then
            dgvLogBook.ClearSelection()
            clearLogbook()
        ElseIf ans = DialogResult.Yes Then
            Try
                If connect.State = ConnectionState.Closed Then
                    connect.Open()
                End If

                For Each row As DataGridViewRow In dgvLogBook.Rows

                    Dim selectt As Boolean = Convert.ToBoolean(row.Cells("chk").Value)

                    If selectt Then
                        'Delete
                        Dim command As New OleDbCommand("DELETE FROM StudentReservation WHERE ReserveNum = @ReserveNum", connect)
                        command.Parameters.AddWithValue("@ReserveNum", row.Cells("DataGridViewTextBoxColumn2").Value)
                        command.ExecuteNonQuery()
                        'Archived
                        Dim Archived As String = "INSERT INTO ReservationArchive([ReserveNum],[Identification],[BookingDate],[BookingTime],[PName],[Status])VALUES(@ReserveNum,@Identification,@BookingDate,@BookingTIme,@PName,@Status)"
                        Dim create2 As New OleDbCommand(Archived, connect)

                        create2.Parameters.AddWithValue("@ReserveNum", row.Cells("DataGridViewTextBoxColumn2").Value)
                        create2.Parameters.AddWithValue("@Identification", row.Cells("IdentificationDataGridViewTextBoxColumn").Value)
                        create2.Parameters.AddWithValue("@BookingDate", row.Cells("DataGridViewTextBoxColumn3").Value)
                        create2.Parameters.AddWithValue("@BookingTime", row.Cells("DataGridViewTextBoxColumn4").Value)
                        create2.Parameters.AddWithValue("@PName", row.Cells("PNameDataGridViewTextBoxColumn").Value)
                        create2.Parameters.AddWithValue("@Status", row.Cells("DataGridViewTextBoxColumn6").Value)

                        create2.ExecuteNonQuery()
                    End If
                Next

                'comm = New OleDbCommand
                'comm.Connection = connect

                'comm.CommandText = "DELETE FROM StudentReservation WHERE ReserveNum='" & txtRNum.Text & "'"
                'MessageBox.Show("Record Deleted", "University of Makati GYM", MessageBoxButtons.OK, MessageBoxIcon.Information)

                'Delete
                Dim command2 As New OleDbCommand("DELETE FROM StudentReservation WHERE ReserveNum='" & txtRNum.Text & "'", connect)
                command2.ExecuteNonQuery()
                'Archived
                Dim Archived2 As String = "INSERT INTO ReservationArchive([ReserveNum],[Identification],[BookingDate],[BookingTime],[PName],[Status])VALUES(@ReserveNum,@Identification,@BookingDate,@BookingTIme,@PName,@Status)"
                Dim create3 As New OleDbCommand(Archived2, connect)

                'create3.Parameters.AddWithValue("@ReserveNum", row.Cells("DataGridViewTextBoxColumn2").Value)
                'create3.Parameters.AddWithValue("@Identification", row.Cells("IdentificationDataGridViewTextBoxColumn").Value)
                'create3.Parameters.AddWithValue("@BookingDate", row.Cells("DataGridViewTextBoxColumn3").Value)
                'create3.Parameters.AddWithValue("@BookingTime", row.Cells("DataGridViewTextBoxColumn4").Value)
                'create3.Parameters.AddWithValue("@PName", row.Cells("PNameDataGridViewTextBoxColumn").Value)
                'create3.Parameters.AddWithValue("@Status", row.Cells("DataGridViewTextBoxColumn6").Value)

                create3.Parameters.AddWithValue("@ReserveNum", OleDbType.VarChar).Value = txtRNum.Text.Trim
                create3.Parameters.AddWithValue("@Identification", OleDbType.VarChar).Value = txtIdentification.Text.Trim
                create3.Parameters.AddWithValue("@BookingDate", OleDbType.VarChar).Value = dtpBookingDate.Text.Trim
                create3.Parameters.AddWithValue("@BookingTime", OleDbType.VarChar).Value = comboboxTime.SelectedItem.Trim
                create3.Parameters.AddWithValue("@PName", OleDbType.VarChar).Value = txtPName.Text.Trim
                create3.Parameters.AddWithValue("@Status", OleDbType.VarChar).Value = comboboxStatus.SelectedItem.Trim
                create3.ExecuteNonQuery()

                MessageBox.Show("Record Deleted", "University of Makati GYM", MessageBoxButtons.OK, MessageBoxIcon.Information)

                dgvLogBook.ClearSelection()
                headerChk = Nothing
                clearLogbook()
                refreshdataview()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try
        End If
    End Sub

    Private Sub btnUpdate_Click_1(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try
            If connect.State = ConnectionState.Closed Then
                connect.Open()
            End If
            comm = New OleDbCommand
            comm.Connection = connect
            comm.CommandText = "Update StudentReservation set Identification ='" & txtIdentification.Text & "', PName = '" & txtPName.Text & "', BookingTime = '" & comboboxTime.Text & "', Status = '" & comboboxStatus.Text & "', BookingDate= '" & dtpBookingDate.Text & "' WHERE ReserveNum='" & txtRNum.Text & "'"
            comm.ExecuteNonQuery()
            MessageBox.Show("Record Updated", "University of Makati", MessageBoxButtons.OK, MessageBoxIcon.Information)
            populate()
            refreshdataview()
            'dgvLogBook.Sort(dgvLogBook.Columns(1), System.ComponentModel.ListSortDirection.Ascending)
            clearLogbook()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub dgvLogBook_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvLogBook.CellClick

        'Show selected data from dgv
        dgvLogBook.Height = 240
        PanelDetails.Show()
        PanelRNum.Show()
        txtRNum.Enabled = False

        Try
            txtRNum.Text = dgvLogBook.Rows(e.RowIndex).Cells(1).Value.ToString
            txtIdentification.Text = dgvLogBook.Rows(e.RowIndex).Cells(2).Value.ToString
            dtpBookingDate.Text = dgvLogBook.Rows(e.RowIndex).Cells(3).Value.ToString
            comboboxTime.Text = dgvLogBook.Rows(e.RowIndex).Cells(4).Value.ToString
            txtPName.Text = dgvLogBook.Rows(e.RowIndex).Cells(5).Value.ToString
            comboboxStatus.Text = dgvLogBook.Rows(e.RowIndex).Cells(6).Value.ToString
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub cboTime_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboTime.SelectedIndexChanged
        cntAvailability = False
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        If Staff_Module.exportStaff = True Then

            Archive_Module.ExportArchive = False

            Export_Module.btnReturn2.Hide()

        End If

        ExportRes = True

        Export_Module.Show()
        txtSearchBar.Text = Nothing
        Me.Close()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        PanelLogBook.Hide()
        PanelReservation.Show()
    End Sub

    Private Sub btnArchive_Click(sender As Object, e As EventArgs) Handles btnArchive.Click
        clearReservation()

        Archive_Module.Show()
        txtSearchBar.Text = Nothing
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage

        Dim bm As New Bitmap(Me.dgvLogBook.Width, Me.dgvLogBook.Height)
        dgvLogBook.DrawToBitmap(bm, New Rectangle(30, 30, Me.dgvLogBook.Width, Me.dgvLogBook.Height))
        e.Graphics.DrawImage(bm, 0, 0)

    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim ans As Integer = MessageBox.Show("Are you sure?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If ans = DialogResult.Yes Then

            SignOutRes = True

            Homepage_Module.login()

            If ExportRes = True Then

                ExportRes = False

            ElseIf Archive_Module.ExportArchive = True Then

                Archive_Module.ExportArchive = False

            ElseIf Staff_Module.exportStaff = True Then

                Staff_Module.exportStaff = False

            End If

            clearReservation()
            Homepage_Module.Show()
            PanelAvailable.Hide()
            PanelNAvailable.Hide()
            txtSearchBar.Text = Nothing
            Me.Close()

        End If

        Homepage_Module.ModuleDisable()
        Homepage_Module.chkShowPass.CheckState = CheckState.Unchecked
        Homepage_Module.authority = False

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
End Class