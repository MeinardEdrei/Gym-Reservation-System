Imports System.Data.OleDb 'for database connection
Imports System.ComponentModel 'for sorting dgv
Imports System.Net.Mail
Public Class Staff_Module
    'DBConnection Reservation and Logbook
    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim source As String = "Data Source=C:\Users\Yves\source\repos\Gym Reservation System\Gym Reservation System\Reservation_System_Database.accdb;"
    Dim connection As New OleDbConnection(My.Settings.Reservation_System_DatabaseConnectionString)
    'Dim source As String = "Data Source=" & Application.StartupPath & "\Reservation_System_Database.accdb;"
    Dim command As String
    Dim connect As New OleDbConnection
    'DataGridView
    Dim comm As New OleDbCommand
    Dim da As New OleDbDataAdapter
    Dim dt As New DataTable
    Dim dset As New DataSet
    'etc
    Dim cntID
    Public SignOutStaff = False
    Public exportStaff = False
    Public ReturnStaff = False
    Dim empty = False
    'CheckBox
    Private headerChk As CheckBox = New CheckBox()
    Private chk As CheckBox = New CheckBox()

    Public Sub refreshdataview()
        dt.Clear()
        dset.Clear()
        da = Nothing

        dgvAccounts.DataSource = Nothing
        dgvAccounts.Refresh()

        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = provider & source

        End If

        Dim cmd As OleDbCommand
        cmd = connect.CreateCommand
        cmd.CommandType = CommandType.Text

        da = New OleDbDataAdapter("Select * from UserAccounts", connect)
        da.Fill(dt)
        dgvAccounts.DataSource = dt

        If ReturnStaff = False Then
            populate2()
        Else
            populate()
        End If


        If ReturnStaff = True Then
            autoscrollrows2()
        Else
            autoscrollrows()
        End If


        connect.Close()

    End Sub

    Function populate()
        dset.Clear()
        da = New OleDbDataAdapter("Select * from UserAccounts", connect)
        dset = New DataSet
        da.Fill(dset, "UserAccounts")
        dgvAccounts.DataSource = dset.Tables("UserAccounts").DefaultView
        Return True
    End Function

    Function populate2()
        dset.Clear()
        da = New OleDbDataAdapter("Select * from AuditLog", connect)
        dset = New DataSet
        da.Fill(dset, "AuditLog")
        dgvRecords.DataSource = dset.Tables("AuditLog").DefaultView
        Return True
    End Function

    Sub autoscrollrows()
        If dgvRecords.RowCount > 1 Then
            dgvRecords.FirstDisplayedScrollingRowIndex = dgvRecords.RowCount - 1
        Else

        End If
    End Sub
    Sub autoscrollrows2()

        dgvAccounts.FirstDisplayedScrollingRowIndex = dgvAccounts.RowCount - 1

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        exportStaff = True
        Reservation_Module.PanelLogBook.Hide()
        Reservation_Module.PanelReservation.Show()
        Reservation_Module.Show()
        Me.Hide()
    End Sub

    Private Sub Staff_Module_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Reservation_System_DatabaseDataSet5.AuditLog' table. You can move, or remove it, as needed.
        Me.AuditLogTableAdapter.Fill(Me.Reservation_System_DatabaseDataSet5.AuditLog)
        'TODO: This line of code loads data into the 'Reservation_System_DatabaseDataSet1.UserAccounts' table. You can move, or remove it, as needed.
        Me.UserAccountsTableAdapter.Fill(Me.Reservation_System_DatabaseDataSet1.UserAccounts)

        Timer1.Enabled = True
        refreshdataview()

        dgvAccounts.Height = 447 '465

        panelRecords.Hide()
        dgvRecords.Hide()
        panelRegister.Hide()
        PanelDetails.Hide()
        panelID.Hide()
        labelPass.Hide()
        dgvAccounts.Show()
        panelStaff.Show()

        dgvAccounts.ClearSelection()

        'checkbox
        Dim chkbox1 As New DataGridViewCheckBoxColumn
        chkbox1.Width = 35
        chkbox1.Name = "chk"
        chkbox1.HeaderText = " "

        dgvAccounts.Columns.Insert(0, chkbox1)

        labelUser.Text = Homepage_Module.txtUsername.Text
        labelUser.Text = labelUser.Text + "!"

        dgvAccounts.ClearSelection()

        exportStaff = True
        empty = False

    End Sub

    Private Sub clearEntries()

        txtRPassword1.Text = Nothing
        txtRPassword2.Text = Nothing
        txtRUsername.Text = Nothing
        cboPosition.Text = Nothing

    End Sub

    Private Sub clearDetails()
        txtUsername.Text = Nothing
        txtPassword.Text = Nothing
        comboboxPosition.Text = Nothing
    End Sub

    Private Sub btnSignup_Click(sender As Object, e As EventArgs) Handles btnSignup.Click

        connect.Open()

        Dim readerR As OleDbDataReader = Nothing
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Yves\source\repos\Gym Reservation System\Gym Reservation System\Reservation_System_Database.accdb;")
        con.Open()
        Dim query1 As String = "Select ID from UserAccounts"
        Dim command1 As New OleDbCommand(query1, con)

        readerR = command1.ExecuteReader

        cntID = Nothing

        'Check Slots Date
        While readerR.Read
            cntID += 1
        End While


        'Username
        Dim cmd1 As New OleDbCommand("SELECT COUNT(*) FROM UserAccounts WHERE [Username]=@Username", connect)
        cmd1.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txtRUsername.Text

        Dim count1 = Convert.ToInt32(cmd1.ExecuteScalar)

        'Password
        Dim cmd2 As New OleDbCommand("SELECT COUNT(*) FROM UserAccounts WHERE [Password]=@Password", connect)
        cmd2.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtRPassword1.Text

        Dim count2 = Convert.ToInt32(cmd2.ExecuteScalar)

        'Position
        Dim cmd3 As New OleDbCommand("SELECT COUNT(*) FROM UserAccounts WHERE [Position]=@Position", connect)
        cmd3.Parameters.AddWithValue("@Position", OleDbType.VarChar).Value = "Head"

        Dim count3 = Convert.ToInt32(cmd3.ExecuteScalar)

        'Restriction
        If txtRUsername.Text = Nothing Or txtRPassword1.Text = Nothing Or txtRPassword2.Text = Nothing Then
            MessageBox.Show("Required Information must not be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ElseIf txtRUsername.Text.Length < 5 Then
            MessageBox.Show("Username must contain atleast minimum 5 characters.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtRPassword1.Text.Length < 7 And txtRPassword2.Text.Length < 7 Then
            MessageBox.Show("Password must contain atleast minimum 7 characters.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtRUsername.Text.Length > 10 Then
            MessageBox.Show("Please choose a shorter Username.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtRPassword1.Text.Length > 10 Or txtRPassword2.Text.Length > 10 Then
            MessageBox.Show("Please choose a shorter Password.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf cboPosition.Text = Nothing Then
            MessageBox.Show("Please choose a Position.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtRUsername.Text = txtRPassword1.Text Then
            MessageBox.Show("Username and Password cannot be the same.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf count1 > 0 And count2 > 0 Then
            MessageBox.Show("An account is already in use.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf count1 > 0 Then 'Username
            MessageBox.Show("Username is already taken.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf count2 > 0 Then 'Password
            MessageBox.Show("Password is already taken.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf txtRPassword2.Text <> txtRPassword1.Text Then
            labelPass.Show()
            My.Computer.Audio.PlaySystemSound(System.Media.SystemSounds.Exclamation)
        ElseIf count3 = 1 And cboPosition.Text = "Head" Then 'Position
            'MsgBox("Count1:" & count1 & "Count2:" & count2 & "Count3:" & count3)
            MessageBox.Show("Head Position is already taken.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else

            labelPass.Hide()

            Using create As New OleDbCommand("INSERT INTO UserAccounts ([ID],[Username],[Password],[Position])VALUES(@ID,@Username,@Password,@Position)", connect)

                Dim cntRead
                cntRead = cntID + 1

                create.Parameters.AddWithValue("@ID", OleDbType.VarChar).Value = cntRead

                create.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txtRUsername.Text.Trim
                create.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtRPassword1.Text.Trim
                create.Parameters.AddWithValue("@Position", OleDbType.VarChar).Value = cboPosition.Text.Trim

                If create.ExecuteNonQuery Then
                    MessageBox.Show("Account Created.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    clearEntries()
                    refreshdataview()
                End If
            End Using
        End If

        connect.Close()

    End Sub

    Private Sub txtRPassword2_TextChanged(sender As Object, e As EventArgs)
        labelPass.Hide()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs) Handles btnReturn.Click
        panelRegister.Hide()
        clearEntries()

        dgvAccounts.Height = 447
        dgvAccounts.Show()
        panelStaff.Show()
        panelClock.Show()
        panelMenu.Show()

        refreshdataview()
        dgvAccounts.ClearSelection()

    End Sub

    Private Sub dgvAccounts_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvAccounts.CellClick

        PanelDetails.Show()
        panelID.Show()

        dgvAccounts.Height = 365

        Try

            txtUsername.Text = dgvAccounts.Rows(e.RowIndex).Cells(1).Value.ToString
            txtPassword.Text = dgvAccounts.Rows(e.RowIndex).Cells(2).Value.ToString
            comboboxPosition.Text = dgvAccounts.Rows(e.RowIndex).Cells(3).Value.ToString
            txtID.Text = dgvAccounts.Rows(e.RowIndex).Cells(4).Value.ToString

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs) Handles btnRegister.Click

        dgvAccounts.Hide()
        PanelDetails.Hide()
        panelID.Hide()
        panelStaff.Hide()
        panelClock.Hide()
        panelRegister.Show()
        PanelDetails.Hide()
        panelMenu.Hide()

    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        Try

            If connect.State = ConnectionState.Closed Then
                connect.ConnectionString = provider & source
            End If

            connect.Open()

            Dim comma = New OleDbCommand
            comma.Connection = connect

            comma.CommandText = "UPDATE UserAccounts set [Username]='" & txtUsername.Text & "', [Password]= '" & txtPassword.Text & "', [Position]='" & comboboxPosition.Text & "' WHERE [ID]= '" & txtID.Text & "'"

            comma.ExecuteNonQuery()
            MessageBox.Show("Record Updated", "University of Makati", MessageBoxButtons.OK, MessageBoxIcon.Information)

            populate()
            refreshdataview()
            clearDetails()

            connect.Close()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click

        If connect.State = ConnectionState.Closed Then

            connect.ConnectionString = provider & source

        End If

        Dim ans As Integer = MessageBox.Show("Do you want to delete this data?", "University of Makati GYM", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If ans = DialogResult.No Then
            dgvAccounts.ClearSelection()
            clearDetails()
        ElseIf ans = DialogResult.Yes Then
            Try
                If connect.State = ConnectionState.Closed Then
                    connect.Open()
                End If

                For Each row As DataGridViewRow In dgvAccounts.Rows

                    Dim selectt As Boolean = Convert.ToBoolean(row.Cells("chk").Value)

                    If selectt Then

                        Dim command As New OleDbCommand("DELETE FROM UserAccounts WHERE Username = @Username", connect)
                        command.Parameters.AddWithValue("@Username", row.Cells("UsernameDataGridViewTextBoxColumn").Value)
                        command.ExecuteNonQuery()

                    End If

                Next

                comm = New OleDbCommand
                comm.Connection = connect

                comm.CommandText = "DELETE FROM UserAccounts WHERE Username='" & txtUsername.Text & "'"
                MessageBox.Show("Record Deleted", "University of Makati GYM", MessageBoxButtons.OK, MessageBoxIcon.Information)

                dgvAccounts.ClearSelection()
                headerChk = Nothing
                clearDetails()
                comm.ExecuteNonQuery()
                refreshdataview()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub btnArchive_Click(sender As Object, e As EventArgs) Handles btnArchive.Click
        exportStaff = True
        Archive_Module.Show()
        Me.Hide()
    End Sub

    Private Sub txtRUsername_TextChanged(sender As Object, e As EventArgs) Handles txtRUsername.TextChanged
        'auto capital first letter
        Dim ss As Integer = txtRUsername.SelectionStart
        Dim sl As Integer = txtRUsername.SelectionLength
        txtRUsername.Text = StrConv(txtRUsername.Text, VbStrConv.ProperCase)
        txtRUsername.SelectionStart = ss
        txtRUsername.SelectionLength = sl
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim ans As Integer = MessageBox.Show("Are you sure?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If ans = DialogResult.Yes Then

            Threading.Thread.Sleep(1000)

            SignOutStaff = True

            Homepage_Module.login()

            If Reservation_Module.ExportRes = True Then

                Reservation_Module.ExportRes = False

            ElseIf Archive_Module.ExportArchive = True Then

                Archive_Module.ExportArchive = False

            ElseIf exportStaff = True Then

                exportStaff = False

            End If

            Homepage_Module.Show()
            Me.Hide()

        End If

        Homepage_Module.ModuleDisable()
        Homepage_Module.chkShowPass.CheckState = CheckState.Unchecked
        Homepage_Module.authority = False

    End Sub

    Private Sub btnAuditLog_Click(sender As Object, e As EventArgs) Handles btnAuditLog.Click

        ReturnStaff = False

        dgvAccounts.Hide()
        panelStaff.Hide()
        PanelDetails.Hide()
        panelRegister.Hide()

        dgvRecords.Show()
        panelRecords.Show()

        populate2()

        autoscrollrows()
        dgvRecords.ClearSelection()

    End Sub

    Private Sub btnReturn2_Click(sender As Object, e As EventArgs) Handles btnReturn2.Click

        ReturnStaff = True

        dgvAccounts.Show()
        dgvAccounts.Height = 447

        panelStaff.Show()
        dgvRecords.Hide()
        txtID.Text = Nothing
        panelRecords.Hide()
        panelID.Hide()

        refreshdataview()
        dgvAccounts.ClearSelection()

    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click

        exportStaff = True

        Export_Module.Show()
        Me.Hide()

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        labelTime.Text = TimeOfDay.ToString("hh:mm:ss tt")
    End Sub

    Private Sub btnDeleteAll_Click(sender As Object, e As EventArgs) Handles btnDeleteAll.Click
        If empty = False Then
            connect.Open()
            Dim ans As Integer = MessageBox.Show("This will entirely erase all data from your Archive. Are you sure you want to continue anyway?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

            If ans = DialogResult.Yes Then
                Dim command As New OleDbCommand("DELETE FROM AuditLog", connect)
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

    'Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
    '    Dim email As String = "gym.technicalsupp@gmail.com"
    '    Dim mail As New MailMessage()
    '    Dim smtservers As New SmtpClient
    '    mail.From = New MailAddress(email)
    '    mail.To.Add("dreisantos15@gmail.com")
    '    mail.Subject = "Sending Email Testing"
    '    mail.IsBodyHtml = False
    '    mail.Body = "Your Username is: Admin and Password is: Admin123"
    '    smtservers.Port = 587
    '    smtservers.UseDefaultCredentials = True
    '    smtservers.Credentials = New System.Net.NetworkCredential(email, "vblcyvilkyzbgbde")
    '    smtservers.EnableSsl = True
    '    smtservers.Host = "smtp.gmail.com"
    '    smtservers.Send(mail)
    '    MsgBox("Mail Sent.")
    'End Sub
End Class