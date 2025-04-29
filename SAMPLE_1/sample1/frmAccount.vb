Public Class frmAccount
    Private Sub frmAccount_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call con()
        Call account_list()
    End Sub

    Private Sub chkshow_CheckedChanged(sender As Object, e As EventArgs) Handles chkshow.CheckedChanged
        If chkshow.Checked = True Then
            txtpassword.PasswordChar = ""
        Else
            txtpassword.PasswordChar = "$"
        End If
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        If txtusername.Text = "" Then
            MsgBox("Enter username", vbInformation, "Missing")
            txtusername.Focus()
            Exit Sub
        ElseIf txtpassword.Text = "" Then
            MsgBox("Enter password", vbInformation, "Missing")
            txtpassword.Focus()
            Exit Sub
        ElseIf txtlastname.Text = "" Then
            MsgBox("Enter last name", vbInformation, "Missing")
            txtlastname.Focus()
            Exit Sub
        ElseIf txtfirstname.Text = "" Then
            MsgBox("Enter last name", vbInformation, "Missing")
            txtfirstname.Focus()
            Exit Sub
        ElseIf txtemail.Text = "" Then
            MsgBox("Enter email", vbInformation, "Missing")
            txtemail.Focus()
            Exit Sub
        End If

        rs = New ADODB.Recordset
        With rs
            If .State = 1 Then .Close()
            .Open("Select * from tbl_accounts where ACC_UNAME='" + txtusername.Text + "'", cn, 1, 2)
            If .EOF = False Then
                MsgBox("Username already exist, use a different username", vbInformation, "Exist")
                txtusername.Text = ""
                txtusername.Focus()
                Exit Sub
            End If
            .AddNew()
            .Fields("ACC_UNAME").Value = txtusername.Text
            .Fields("ACC_PWORD").Value = txtpassword.Text
            .Fields("ACC_LAST").Value = txtlastname.Text
            .Fields("ACC_FIRST").Value = txtfirstname.Text
            .Fields("ACC_EMAIL").Value = txtemail.Text
            .Update()
            MsgBox("Account was added", vbInformation, "Add")
            .Close()
        End With
        Call clear()
        Call account_list()
    End Sub
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If txtpassword.Text = "" Then
            MsgBox("Enter password", vbInformation, "Missing")
            txtpassword.Focus()
            Exit Sub
        ElseIf txtlastname.Text = "" Then
            MsgBox("Enter last name", vbInformation, "Missing")
            txtlastname.Focus()
            Exit Sub
        ElseIf txtfirstname.Text = "" Then
            MsgBox("Enter last name", vbInformation, "Missing")
            txtfirstname.Focus()
            Exit Sub
        ElseIf txtemail.Text = "" Then
            MsgBox("Enter email", vbInformation, "Missing")
            txtemail.Focus()
            Exit Sub
        End If

        rs = New ADODB.Recordset
        With rs
            If .State = 1 Then .Close()
            .Open("Select * from tbl_accounts where ACC_UNAME='" + txtusername.Text + "'", cn, 1, 2)
            .Fields("ACC_PWORD").Value = txtpassword.Text
            .Fields("ACC_LAST").Value = txtlastname.Text
            .Fields("ACC_FIRST").Value = txtfirstname.Text
            .Fields("ACC_EMAIL").Value = txtemail.Text
            If MsgBox("Do you really want to update this account?", vbQuestion + vbYesNo, "Update") = vbNo Then
                Exit Sub
            End If
            .Update()
            MsgBox("Account was updated", vbInformation, "Add")
            .Close()
        End With
        Call clear()
        Call account_list()
    End Sub

    Private Sub btnclear_Click(sender As Object, e As EventArgs) Handles btnclear.Click
        Call clear()
        Call account_list()
    End Sub
    Sub clear()
        txtusername.Text = ""
        txtpassword.Text = ""
        txtlastname.Text = ""
        txtfirstname.Text = ""
        chkshow.Checked = False
        txtemail.Text = ""
        txtusername.Enabled = True
        txtusername.Focus()
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        rs = New ADODB.Recordset
        With rs
            If .State = 1 Then .Close()
            .Open("Select * from tbl_accounts where ACC_UNAME='" + txtusername.Text + "'", cn, 1, 2)
            If MsgBox("Are you sure you want to delet this account?", vbQuestion + vbYesNo, "Delete") = vbNo Then
                Exit Sub
            End If
            .Delete()
            .Update()
            MsgBox("Account was deleted", vbInformation, "Delete")
            .Close()
        End With
        Call clear()
        Call account_list()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub
    Dim rec As ListViewItem
    Sub account_list()
        rs = New ADODB.Recordset
        With rs
            If .State = 1 Then .Close()
            .Open("Select * from tbl_accounts ORDER BY ACC_LAST ASC", cn, 1, 2)
            If .EOF = True Then
                Exit Sub
            End If
            lstaccounts.Items.Clear()

            While .EOF = False
                rec = lstaccounts.Items.Add(.Fields("ACC_UNAME").Value)
                rec.SubItems.Insert(1, New ListViewItem.ListViewSubItem(Nothing, .Fields("ACC_LAST").Value))
                rec.SubItems.Insert(2, New ListViewItem.ListViewSubItem(Nothing, .Fields("ACC_FIRST").Value))
                rec.SubItems.Insert(3, New ListViewItem.ListViewSubItem(Nothing, .Fields("ACC_EMAIL").Value))
                .MoveNext()
            End While
            .Close()
        End With
    End Sub

    Private Sub txtsearch_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtsearch_TextChanged_1(sender As Object, e As EventArgs) Handles txtsearch.TextChanged
        rs = New ADODB.Recordset
        With rs
            If .State = 1 Then .Close()
            If cbofilter.SelectedIndex = 0 Then
                .Open("Select * from tbl_accounts where ACC_UNAME like '%" + txtsearch.Text + "%'", cn, 1, 2)
            ElseIf cbofilter.SelectedIndex = 1 Then
                .Open("Select * from tbl_accounts where ACC_LAST like '%" + txtsearch.Text + "%'", cn, 1, 2)
            ElseIf cbofilter.SelectedIndex = 2 Then
                .Open("Select * from tbl_accounts where ACC_FIRST like '%" + txtsearch.Text + "%'", cn, 1, 2)
            ElseIf cbofilter.SelectedIndex = 3 Then
                .Open("Select * from tbl_accounts where ACC_EMAIL like '%" + txtsearch.Text + "%'", cn, 1, 2)
            Else
                Exit Sub
            End If
            If .EOF = True Then
                Exit Sub
            End If
            lstaccounts.Items.Clear()
            While .EOF = False
                rec = lstaccounts.Items.Add(.Fields("ACC_UNAME").Value)
                rec.SubItems.Insert(1, New ListViewItem.ListViewSubItem(Nothing, .Fields("ACC_LAST").Value))
                rec.SubItems.Insert(2, New ListViewItem.ListViewSubItem(Nothing, .Fields("ACC_FIRST").Value))
                rec.SubItems.Insert(3, New ListViewItem.ListViewSubItem(Nothing, .Fields("ACC_EMAIL").Value))
                .MoveNext()
            End While
            .Close()
        End With
    End Sub

    Private Sub lstaccounts_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstaccounts.SelectedIndexChanged

    End Sub

    Private Sub lstaccounts_DoubleClick(sender As Object, e As EventArgs) Handles lstaccounts.DoubleClick
        rs = New ADODB.Recordset
        With rs
            If .State = 1 Then .Close()
            .Open("Select * from tbl_accounts where ACC_UNAME='" + lstaccounts.FocusedItem.Text + "' ", cn, 1, 2)
            If .EOF = True Then
                Exit Sub
            End If
            txtusername.Text = .Fields("ACC_UNAME").Value
            txtpassword.Text = .Fields("ACC_PWORD").Value
            txtlastname.Text = .Fields("ACC_LAST").Value
            txtfirstname.Text = .Fields("ACC_FIRST").Value
            txtemail.Text = .Fields("ACC_EMAIL").Value
            txtusername.Enabled = False
            .Close()
        End With
    End Sub
End Class
