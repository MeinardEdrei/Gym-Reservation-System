Imports System.Data.OleDb
Imports System.ComponentModel

Public Class Homepage_Module
    'DBConnection
    Dim provider As String = "Provider=Microsoft.ACE.OLEDB.12.0;"
    Dim source As String = "Data Source=C:\Users\Yves\source\repos\Gym Reservation System\Gym Reservation System\Reservation_System_Database.accdb;"
    'DataGridView
    Dim comm As New OleDbCommand
    Dim connect As New OleDbConnection
    Dim da As New OleDbDataAdapter
    Dim dt As New DataTable
    Dim dset As New DataSet
    'Etc
    Dim cnt = 0
    Dim sum = 0
    Public authority = False

    Public Sub ModuleDisable()
        Reservation_Module.ExportRes = False
        Archive_Module.ExportArchive = False
        Staff_Module.exportStaff = False
        authority = False
    End Sub

    Private Sub refreshdataview()
        dt.Clear()
        dset.Clear()
        da = Nothing

        dgvRecords.DataSource = Nothing
        dgvRecords.Refresh()

        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = provider & source

        End If

        Dim cmd As OleDbCommand
        cmd = connect.CreateCommand
        cmd.CommandType = CommandType.Text

        da = New OleDbDataAdapter("Select * from AuditLog", connect)
        da.Fill(dt)
        dgvRecords.DataSource = dt
        populate()

        autoscrollrows()

        connect.Close()
    End Sub

    Function populate()
        dset.Clear()
        da = New OleDbDataAdapter("Select * from AuditLog", connect)
        dset = New DataSet
        da.Fill(dset, "AuditLog")
        dgvRecords.DataSource = dset.Tables("AuditLog").DefaultView
        Return True
    End Function

    Private Property MoveForm As Boolean
    Private Property MoveForm_MousePosition As Point

    Private Sub Homepage_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If e.Button = MouseButtons.Left Then
            MoveForm = True
            Me.Cursor = Cursors.Default
            MoveForm_MousePosition = e.Location
        End If
    End Sub
    Private Sub Homepage_MouseUp(sender As Object, e As MouseEventArgs) Handles MyBase.MouseUp
        If e.Button = MouseButtons.Left Then
            MoveForm = False
            Me.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub Homepage_PousePlove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If MoveForm Then
            Me.Location = Me.Location + (e.Location - MoveForm_MousePosition)
        End If
    End Sub

    Private Sub btnReservation_Click(sender As Object, e As EventArgs)
        Reservation_Module.PanelLogBook.Hide()
        Reservation_Module.PanelReservation.Show()
        Reservation_Module.Show()
        Me.Hide()
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs)
        Archive_Module.Show()
        Me.Hide()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Public Sub login()
        panelClock.Hide()
        labelTime.Hide()
        dgvRecords.Hide()
        panelMenu.Hide()
        'panelRegister.Hide()
        panelLogin.Show()
    End Sub

    Private Sub Homepage_Module_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Reservation_System_DatabaseDataSet2.AuditLog' table. You can move, or remove it, as needed.
        Me.AuditLogTableAdapter.Fill(Me.Reservation_System_DatabaseDataSet2.AuditLog)

        chkShowPass.CheckState = CheckState.Unchecked
        Timer1.Enabled = True

        If Reservation_Module.SignOutRes = True Or Archive_Module.SignOutArch = True Or Export_Module.SignOutExport = True Or Staff_Module.SignOutStaff = True Then
            panelClock.Hide()
            labelTime.Hide()
            dgvRecords.Hide()
            panelMenu.Hide()
            'panelRegister.Hide()
            panelLogin.Show()
        Else
            panelClock.Hide()
            labelTime.Hide()
            dgvRecords.Hide()
            panelMenu.Hide()
            'panelRegister.Hide()
            panelLogin.Show()
        End If

        If connect.State = ConnectionState.Closed Then
            connect.ConnectionString = provider & source
        End If

        refreshdataview()

        'txtPassword.UseSystemPasswordChar = True
        'dgvRecords.Sort(dgvRecords.Columns(0), ListSortDirection.Descending)

        Reservation_Module.ExportRes = False
        Archive_Module.ExportArchive = False
        Staff_Module.exportStaff = False

        ModuleDisable()

    End Sub

    Sub autoscrollrows()
        If dgvRecords.RowCount > 1 Then
            dgvRecords.FirstDisplayedScrollingRowIndex = dgvRecords.RowCount - 1
        Else

        End If
    End Sub

    Private Sub clearEntries()

        txtPassword.Text = Nothing
        'txtRPassword1.Text = Nothing
        'txtRPassword2.Text = Nothing
        'txtRUsername.Text = Nothing
        txtUsername.Text = Nothing
        'cboPosition.Text = Nothing

    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click

        connect.Open()

        If txtUsername.Text = Nothing Or txtPassword.Text = Nothing Then
            MessageBox.Show("Required Information must not be empty.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            Dim cmd As New OleDbCommand("SELECT COUNT(*) FROM UserAccounts WHERE [Username]=@Username AND [Password]=@Password", connect)
            cmd.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txtUsername.Text
            cmd.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtPassword.Text

            Dim count = Convert.ToInt32(cmd.ExecuteScalar)

            If count > 0 Then
                MessageBox.Show("Login Success.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)

                labelUser.Text = txtUsername.Text
                labelUser.Text = labelUser.Text + "!"

                Dim cmdd As New OleDbCommand("SELECT COUNT(*) FROM UserAccounts WHERE [Username]=@Username AND [Password]=@Password AND [Position]=@Position", connect)
                cmdd.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txtUsername.Text.Trim
                cmdd.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtPassword.Text.Trim
                cmdd.Parameters.AddWithValue("@Position", OleDbType.VarChar).Value = "Head"

                Dim countt = Convert.ToInt32(cmdd.ExecuteScalar)

                Threading.Thread.Sleep(1000)

                If countt = 1 Then
                    'MsgBox("Head to")

                    'INTO Audit Log Head Database
                    Using create As New OleDbCommand("INSERT INTO AuditLog ([Time],[Account],[Position])VALUES(@Time,@Account,@Position)", connect)

                        create.Parameters.AddWithValue("@Time", OleDbType.VarChar).Value = DateTime.Now.ToString("yyyy/MM/dd - hh:mm:ss tt")
                        create.Parameters.AddWithValue("@Account", OleDbType.VarChar).Value = txtUsername.Text.Trim

                        create.Parameters.AddWithValue("@Position", OleDbType.VarChar).Value = "Head"

                        create.ExecuteNonQuery()

                    End Using

                    authority = True

                    Staff_Module.Show()
                    Me.Hide()

                ElseIf countt = 0 Then
                    'MsgBox("employee to")


                    'INTO Audit Log Employee Database
                    Using create As New OleDbCommand("INSERT INTO AuditLog ([Time],[Account],[Position])VALUES(@Time,@Account,@Position)", connect)

                        create.Parameters.AddWithValue("@Time", OleDbType.VarChar).Value = DateTime.Now.ToString("yyyy/MM/dd - hh:mm:ss tt")
                        create.Parameters.AddWithValue("@Account", OleDbType.VarChar).Value = txtUsername.Text.Trim

                        create.Parameters.AddWithValue("@Position", OleDbType.VarChar).Value = "Employee"

                        create.ExecuteNonQuery()

                    End Using

                    panelMenu.Show()
                    dgvRecords.Show()
                    labelTime.Show()
                    panelClock.Show()
                    refreshdataview()
                    panelLogin.Hide()
                    'panelRegister.Hide()
                End If

                clearEntries()

            Else

                'Restriction

                Dim cmd3 As New OleDbCommand("SELECT COUNT(*) FROM UserAccounts WHERE [Username]=@Username", connect)
                cmd3.Parameters.AddWithValue("@Username", OleDbType.VarChar).Value = txtUsername.Text

                Dim count2 = Convert.ToInt32(cmd3.ExecuteScalar)

                Dim cmd4 As New OleDbCommand("SELECT COUNT(*) FROM UserAccounts WHERE [Password]=@Password", connect)
                cmd4.Parameters.AddWithValue("@Password", OleDbType.VarChar).Value = txtPassword.Text

                Dim count3 = Convert.ToInt32(cmd4.ExecuteScalar)

                If count2 <= 0 And count3 <= 0 Then
                    MessageBox.Show("Invalid Username and Password", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf count2 <= 0 And count3 > 0 Then
                    MessageBox.Show("Invalid Username Input", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                ElseIf count3 <= 0 And count2 > 0 Then
                    MessageBox.Show("Invalid Password Input", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End If
        End If

        connect.Close()

    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs)

        Threading.Thread.Sleep(1000)
        clearEntries()

        panelLogin.Hide()
        'labelPass.Hide()
        'panelRegister.Show()
    End Sub

    Private Sub btnReturn_Click(sender As Object, e As EventArgs)

        Threading.Thread.Sleep(1000)

        'panelRegister.Hide()
        panelLogin.Show()
    End Sub

    Private Sub chkShowPass_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPass.CheckedChanged

        If chkShowPass.CheckState = CheckState.Checked Then
            txtPassword.UseSystemPasswordChar = True
        Else
            txtPassword.UseSystemPasswordChar = False
        End If

    End Sub

    Private Sub btnExit_Click_1(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()

    End Sub

    Private Sub btnMinimize_Click(sender As Object, e As EventArgs) Handles btnMinimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnReservation_Click_1(sender As Object, e As EventArgs) Handles btnReservation.Click
        Reservation_Module.Show()
        Me.Hide()
    End Sub

    Private Sub btnArchive_Click(sender As Object, e As EventArgs) Handles btnArchive.Click
        Archive_Module.Show()
        Me.Hide()
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs) Handles txtUsername.TextChanged
        'auto capital first letter
        Dim ss As Integer = txtUsername.SelectionStart
        Dim sl As Integer = txtUsername.SelectionLength
        txtUsername.Text = StrConv(txtUsername.Text, VbStrConv.ProperCase)
        txtUsername.SelectionStart = ss
        txtUsername.SelectionLength = sl
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click

        Dim ans As Integer = MessageBox.Show("Are you sure?", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

        If ans = DialogResult.Yes Then

            Threading.Thread.Sleep(1000)

            If Reservation_Module.ExportRes = True Then

                Reservation_Module.ExportRes = False

            ElseIf Archive_Module.ExportArchive = True Then

                Archive_Module.ExportArchive = False

            ElseIf Staff_Module.exportStaff = True Then

                Staff_Module.exportStaff = False

            End If

            panelMenu.Hide()
            dgvRecords.Hide()
            labelTime.Hide()
            panelClock.Hide()
            panelLogin.Show()
        End If

        chkShowPass.CheckState = CheckState.Unchecked
        ModuleDisable()
        authority = False

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        labelTime.Text = TimeOfDay.ToString("hh:mm:ss tt")
    End Sub
End Class