<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SIGNUP
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
        Me.TXT_NAME = New System.Windows.Forms.TextBox()
        Me.TXT_PASS = New System.Windows.Forms.TextBox()
        Me.BTN_SAVE = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CMB_GENDER = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXT_MAIL = New System.Windows.Forms.TextBox()
        Me.TXT_UID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TXT_MOBILE = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TXT_ADDRESS = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TXT_NAME
        '
        Me.TXT_NAME.Location = New System.Drawing.Point(188, 58)
        Me.TXT_NAME.MaxLength = 27
        Me.TXT_NAME.Name = "TXT_NAME"
        Me.TXT_NAME.Size = New System.Drawing.Size(141, 20)
        Me.TXT_NAME.TabIndex = 2
        '
        'TXT_PASS
        '
        Me.TXT_PASS.Location = New System.Drawing.Point(188, 91)
        Me.TXT_PASS.MaxLength = 27
        Me.TXT_PASS.Name = "TXT_PASS"
        Me.TXT_PASS.Size = New System.Drawing.Size(141, 20)
        Me.TXT_PASS.TabIndex = 3
        '
        'BTN_SAVE
        '
        Me.BTN_SAVE.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_SAVE.Location = New System.Drawing.Point(118, 273)
        Me.BTN_SAVE.Name = "BTN_SAVE"
        Me.BTN_SAVE.Size = New System.Drawing.Size(92, 35)
        Me.BTN_SAVE.TabIndex = 8
        Me.BTN_SAVE.Text = "SIGN UP"
        Me.BTN_SAVE.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(100, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "NAME"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(100, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "PASSWORD"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CMB_GENDER)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.TXT_MAIL)
        Me.GroupBox1.Controls.Add(Me.TXT_UID)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TXT_MOBILE)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.TXT_ADDRESS)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.BTN_SAVE)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.TXT_NAME)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TXT_PASS)
        Me.GroupBox1.Location = New System.Drawing.Point(85, 55)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(439, 352)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "SIGN UP INFO"
        '
        'CMB_GENDER
        '
        Me.CMB_GENDER.FormattingEnabled = True
        Me.CMB_GENDER.Items.AddRange(New Object() {"MALE", "FEMALE", "TRANS G", "OTHER"})
        Me.CMB_GENDER.Location = New System.Drawing.Point(188, 124)
        Me.CMB_GENDER.MaxLength = 8
        Me.CMB_GENDER.Name = "CMB_GENDER"
        Me.CMB_GENDER.Size = New System.Drawing.Size(141, 21)
        Me.CMB_GENDER.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(100, 160)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "EMAIL"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(100, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "GENDER"
        '
        'TXT_MAIL
        '
        Me.TXT_MAIL.Location = New System.Drawing.Point(188, 157)
        Me.TXT_MAIL.MaxLength = 27
        Me.TXT_MAIL.Name = "TXT_MAIL"
        Me.TXT_MAIL.Size = New System.Drawing.Size(141, 20)
        Me.TXT_MAIL.TabIndex = 5
        '
        'TXT_UID
        '
        Me.TXT_UID.Location = New System.Drawing.Point(188, 25)
        Me.TXT_UID.Name = "TXT_UID"
        Me.TXT_UID.ReadOnly = True
        Me.TXT_UID.Size = New System.Drawing.Size(141, 20)
        Me.TXT_UID.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(100, 28)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(51, 13)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "USER ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(100, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "ADDRESS"
        '
        'TXT_MOBILE
        '
        Me.TXT_MOBILE.Location = New System.Drawing.Point(188, 189)
        Me.TXT_MOBILE.MaxLength = 10
        Me.TXT_MOBILE.Name = "TXT_MOBILE"
        Me.TXT_MOBILE.Size = New System.Drawing.Size(141, 20)
        Me.TXT_MOBILE.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(100, 191)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "MOBILE"
        '
        'TXT_ADDRESS
        '
        Me.TXT_ADDRESS.Location = New System.Drawing.Point(188, 222)
        Me.TXT_ADDRESS.MaxLength = 27
        Me.TXT_ADDRESS.Name = "TXT_ADDRESS"
        Me.TXT_ADDRESS.Size = New System.Drawing.Size(141, 20)
        Me.TXT_ADDRESS.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(219, 273)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(92, 35)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "CLOSE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Blue
        Me.Label3.Location = New System.Drawing.Point(263, 14)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "SIGN UP"
        '
        'SIGNUP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(608, 472)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "SIGNUP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SIGNUP"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TXT_NAME As TextBox
    Friend WithEvents TXT_PASS As TextBox
    Friend WithEvents BTN_SAVE As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_MOBILE As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TXT_ADDRESS As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents TXT_MAIL As TextBox
    Friend WithEvents TXT_UID As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents CMB_GENDER As ComboBox
End Class
