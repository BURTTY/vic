<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAccount
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chkshow = New System.Windows.Forms.CheckBox()
        Me.txtlastname = New System.Windows.Forms.TextBox()
        Me.txtfirstname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btnclear = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cbofilter = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.lstaccounts = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.txtsearch = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "USERNAME:"
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(106, 24)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(179, 22)
        Me.txtusername.TabIndex = 1
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(106, 52)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(36)
        Me.txtpassword.Size = New System.Drawing.Size(179, 22)
        Me.txtpassword.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 55)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "PASSWORD"
        '
        'chkshow
        '
        Me.chkshow.AutoSize = True
        Me.chkshow.Location = New System.Drawing.Point(106, 80)
        Me.chkshow.Name = "chkshow"
        Me.chkshow.Size = New System.Drawing.Size(102, 17)
        Me.chkshow.TabIndex = 4
        Me.chkshow.Text = "Show Password"
        Me.chkshow.UseVisualStyleBackColor = True
        '
        'txtlastname
        '
        Me.txtlastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtlastname.Location = New System.Drawing.Point(106, 103)
        Me.txtlastname.Name = "txtlastname"
        Me.txtlastname.Size = New System.Drawing.Size(179, 22)
        Me.txtlastname.TabIndex = 6
        '
        'txtfirstname
        '
        Me.txtfirstname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfirstname.Location = New System.Drawing.Point(106, 131)
        Me.txtfirstname.Name = "txtfirstname"
        Me.txtfirstname.Size = New System.Drawing.Size(179, 22)
        Me.txtfirstname.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 16)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "FIRSTNAME:"
        '
        'txtemail
        '
        Me.txtemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtemail.Location = New System.Drawing.Point(106, 159)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(179, 22)
        Me.txtemail.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 162)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "EMAIL:"
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(389, 26)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(168, 23)
        Me.btnadd.TabIndex = 11
        Me.btnadd.Text = "ADD ACCOUNT"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(285, 25)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(18, 24)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "*"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(285, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(18, 24)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "*"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(285, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(18, 24)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "*"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(285, 132)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(18, 24)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "*"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(285, 159)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(18, 24)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "*"
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(389, 55)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(168, 23)
        Me.btnupdate.TabIndex = 20
        Me.btnupdate.Text = "UPDATE ACCOUNT"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btnclear
        '
        Me.btnclear.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnclear.Location = New System.Drawing.Point(389, 84)
        Me.btnclear.Name = "btnclear"
        Me.btnclear.Size = New System.Drawing.Size(168, 23)
        Me.btnclear.TabIndex = 21
        Me.btnclear.Text = "CLEAR"
        Me.btnclear.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.Location = New System.Drawing.Point(389, 113)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(168, 23)
        Me.btndelete.TabIndex = 22
        Me.btndelete.Text = "DELETE ACCOUNT"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(389, 142)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(168, 23)
        Me.btnexit.TabIndex = 23
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 16)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "LASTNAME:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(13, 212)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(78, 16)
        Me.Label11.TabIndex = 29
        Me.Label11.Text = "FILTER BY:"
        '
        'cbofilter
        '
        Me.cbofilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbofilter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbofilter.FormattingEnabled = True
        Me.cbofilter.Items.AddRange(New Object() {"USERNAME", "LASTNAME", "FIRSTNAME", "EMAIL"})
        Me.cbofilter.Location = New System.Drawing.Point(106, 206)
        Me.cbofilter.Name = "cbofilter"
        Me.cbofilter.Size = New System.Drawing.Size(149, 28)
        Me.cbofilter.TabIndex = 30
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(284, 212)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(88, 16)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "TYPE HERE:"
        '
        'lstaccounts
        '
        Me.lstaccounts.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.lstaccounts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstaccounts.FullRowSelect = True
        Me.lstaccounts.GridLines = True
        Me.lstaccounts.Location = New System.Drawing.Point(15, 240)
        Me.lstaccounts.Name = "lstaccounts"
        Me.lstaccounts.Size = New System.Drawing.Size(542, 265)
        Me.lstaccounts.TabIndex = 33
        Me.lstaccounts.UseCompatibleStateImageBehavior = False
        Me.lstaccounts.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "USERNAME"
        Me.ColumnHeader1.Width = 124
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "LAST NAME"
        Me.ColumnHeader2.Width = 145
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "FIRST NAME"
        Me.ColumnHeader3.Width = 151
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "EMAIL"
        Me.ColumnHeader4.Width = 180
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(378, 209)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(179, 22)
        Me.txtsearch.TabIndex = 34
        '
        'frmAccount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 517)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.lstaccounts)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.cbofilter)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnclear)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtfirstname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtlastname)
        Me.Controls.Add(Me.chkshow)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmAccount"
        Me.Text = "ACCOUNT FORM"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents chkshow As CheckBox
    Friend WithEvents txtlastname As TextBox
    Friend WithEvents txtfirstname As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtemail As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnadd As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents btnupdate As Button
    Friend WithEvents btnclear As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btnexit As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents cbofilter As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtsearch As TextBox
    Friend WithEvents lstaccounts As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
End Class
