Public Class frmLogin
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call con()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        End
    End Sub

    Private Sub chkshow_CheckedChanged(sender As Object, e As EventArgs) Handles chkshow.CheckedChanged
        If chkshow.Checked = True Then
            txtpassword.PasswordChar = ""
        Else
            txtpassword.PasswordChar = "$"
        End If
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        If txtusername.Text = "" Then
            MsgBox("Enter username", vbInformation, "Missing")
            txtusername.Focus()
            Exit Sub
        ElseIf txtpassword.Text = "" Then
            MsgBox("Enter password", vbInformation, "Missing")
            txtpassword.Focus()
            Exit Sub
        End If
        rs = New ADODB.Recordset
        With rs
            If .State = 1 Then Close()
            .Open("Select * from tbl_accounts where ACC_UNAME='" + txtusername.Text + "' and ACC_PWORD='" + txtpassword.Text + "'", cn, 1, 2)
            If .EOF = True Then
                MsgBox("Log in Failed", vbInformation, "Failed")
                Exit Sub
            End If
            MsgBox("Log in Successful", vbInformation, "Success")
            .Close()
        End With
        Me.Hide()
        frmAccount.Show()
    End Sub
End Class