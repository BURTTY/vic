<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLogin
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
        Me.chkshow = New System.Windows.Forms.CheckBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtusername = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'chkshow
        '
        Me.chkshow.AutoSize = True
        Me.chkshow.Location = New System.Drawing.Point(107, 68)
        Me.chkshow.Name = "chkshow"
        Me.chkshow.Size = New System.Drawing.Size(102, 17)
        Me.chkshow.TabIndex = 9
        Me.chkshow.Text = "Show Password"
        Me.chkshow.UseVisualStyleBackColor = True
        '
        'txtpassword
        '
        Me.txtpassword.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(107, 40)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(36)
        Me.txtpassword.Size = New System.Drawing.Size(179, 22)
        Me.txtpassword.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 16)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "PASSWORD"
        '
        'txtusername
        '
        Me.txtusername.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusername.Location = New System.Drawing.Point(107, 12)
        Me.txtusername.Name = "txtusername"
        Me.txtusername.Size = New System.Drawing.Size(179, 22)
        Me.txtusername.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "USERNAME:"
        '
        'btnlogin
        '
        Me.btnlogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Location = New System.Drawing.Point(77, 100)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(168, 23)
        Me.btnlogin.TabIndex = 12
        Me.btnlogin.Text = "LOG IN"
        Me.btnlogin.UseVisualStyleBackColor = True
        '
        'btnexit
        '
        Me.btnexit.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.Location = New System.Drawing.Point(77, 129)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(168, 23)
        Me.btnexit.TabIndex = 13
        Me.btnexit.Text = "EXIT"
        Me.btnexit.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(324, 164)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.chkshow)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtusername)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLogin"
        Me.Text = "LOG IN"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents chkshow As CheckBox
    Friend WithEvents txtpassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtusername As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnlogin As Button
    Friend WithEvents btnexit As Button
End Class
