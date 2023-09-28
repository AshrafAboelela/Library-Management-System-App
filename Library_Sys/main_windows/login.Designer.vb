<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chk_branch = New System.Windows.Forms.CheckBox()
        Me.chk_lib_manager = New System.Windows.Forms.CheckBox()
        Me.chk_emp = New System.Windows.Forms.CheckBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_record = New System.Windows.Forms.Button()
        Me.txt_pass_server = New System.Windows.Forms.TextBox()
        Me.txt_user_server = New System.Windows.Forms.TextBox()
        Me.txt_database = New System.Windows.Forms.TextBox()
        Me.txt_server = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.txt_user = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_emp = New System.Windows.Forms.Button()
        Me.btn_end = New System.Windows.Forms.Button()
        Me.btn_branch_manager = New System.Windows.Forms.Button()
        Me.btn_manager = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(349, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "إختر المنصب"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(326, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(27, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "<<"
        '
        'chk_branch
        '
        Me.chk_branch.AutoSize = True
        Me.chk_branch.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_branch.Location = New System.Drawing.Point(122, 12)
        Me.chk_branch.Name = "chk_branch"
        Me.chk_branch.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_branch.Size = New System.Drawing.Size(76, 23)
        Me.chk_branch.TabIndex = 2
        Me.chk_branch.Text = "مدير قسم"
        Me.chk_branch.UseVisualStyleBackColor = True
        '
        'chk_lib_manager
        '
        Me.chk_lib_manager.AutoSize = True
        Me.chk_lib_manager.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_lib_manager.Location = New System.Drawing.Point(229, 12)
        Me.chk_lib_manager.Name = "chk_lib_manager"
        Me.chk_lib_manager.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_lib_manager.Size = New System.Drawing.Size(83, 23)
        Me.chk_lib_manager.TabIndex = 3
        Me.chk_lib_manager.Text = "مدير مكتبة"
        Me.chk_lib_manager.UseVisualStyleBackColor = True
        '
        'chk_emp
        '
        Me.chk_emp.AutoSize = True
        Me.chk_emp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_emp.Location = New System.Drawing.Point(26, 12)
        Me.chk_emp.Name = "chk_emp"
        Me.chk_emp.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.chk_emp.Size = New System.Drawing.Size(62, 23)
        Me.chk_emp.TabIndex = 4
        Me.chk_emp.Text = "موظف"
        Me.chk_emp.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_cancel)
        Me.GroupBox1.Controls.Add(Me.btn_record)
        Me.GroupBox1.Controls.Add(Me.txt_pass_server)
        Me.GroupBox1.Controls.Add(Me.txt_user_server)
        Me.GroupBox1.Controls.Add(Me.txt_database)
        Me.GroupBox1.Controls.Add(Me.txt_server)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(43, 41)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(354, 189)
        Me.GroupBox1.TabIndex = 11
        Me.GroupBox1.TabStop = False
        '
        'btn_cancel
        '
        Me.btn_cancel.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancel.Location = New System.Drawing.Point(51, 142)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(75, 35)
        Me.btn_cancel.TabIndex = 20
        Me.btn_cancel.Text = "الغاء"
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_record
        '
        Me.btn_record.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_record.Location = New System.Drawing.Point(194, 142)
        Me.btn_record.Name = "btn_record"
        Me.btn_record.Size = New System.Drawing.Size(75, 35)
        Me.btn_record.TabIndex = 19
        Me.btn_record.Text = "التسجيل"
        Me.btn_record.UseVisualStyleBackColor = True
        '
        'txt_pass_server
        '
        Me.txt_pass_server.Location = New System.Drawing.Point(12, 112)
        Me.txt_pass_server.Name = "txt_pass_server"
        Me.txt_pass_server.Size = New System.Drawing.Size(242, 20)
        Me.txt_pass_server.TabIndex = 18
        '
        'txt_user_server
        '
        Me.txt_user_server.Location = New System.Drawing.Point(12, 81)
        Me.txt_user_server.Name = "txt_user_server"
        Me.txt_user_server.Size = New System.Drawing.Size(242, 20)
        Me.txt_user_server.TabIndex = 17
        '
        'txt_database
        '
        Me.txt_database.Location = New System.Drawing.Point(13, 50)
        Me.txt_database.Name = "txt_database"
        Me.txt_database.Size = New System.Drawing.Size(242, 20)
        Me.txt_database.TabIndex = 16
        '
        'txt_server
        '
        Me.txt_server.Location = New System.Drawing.Point(13, 21)
        Me.txt_server.Name = "txt_server"
        Me.txt_server.Size = New System.Drawing.Size(242, 20)
        Me.txt_server.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(269, 111)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(73, 19)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "كلمة المرور"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(261, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(81, 19)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "إسم المستخدم"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(263, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "قاعدة البيانات"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(268, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "إسم السيرفر"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_pass)
        Me.GroupBox2.Controls.Add(Me.txt_user)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(43, 236)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(355, 96)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(15, 56)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(242, 20)
        Me.txt_pass.TabIndex = 20
        '
        'txt_user
        '
        Me.txt_user.Location = New System.Drawing.Point(15, 25)
        Me.txt_user.Name = "txt_user"
        Me.txt_user.Size = New System.Drawing.Size(242, 20)
        Me.txt_user.TabIndex = 19
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(269, 57)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 19)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "كلمة المرور"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(263, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "إسم المستخدم"
        '
        'btn_emp
        '
        Me.btn_emp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_emp.Location = New System.Drawing.Point(128, 348)
        Me.btn_emp.Name = "btn_emp"
        Me.btn_emp.Size = New System.Drawing.Size(75, 35)
        Me.btn_emp.TabIndex = 20
        Me.btn_emp.Text = "الموظف"
        Me.btn_emp.UseVisualStyleBackColor = True
        Me.btn_emp.Visible = False
        '
        'btn_end
        '
        Me.btn_end.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_end.Location = New System.Drawing.Point(41, 348)
        Me.btn_end.Name = "btn_end"
        Me.btn_end.Size = New System.Drawing.Size(75, 35)
        Me.btn_end.TabIndex = 21
        Me.btn_end.Text = "خروج"
        Me.btn_end.UseVisualStyleBackColor = True
        '
        'btn_branch_manager
        '
        Me.btn_branch_manager.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_branch_manager.Location = New System.Drawing.Point(215, 348)
        Me.btn_branch_manager.Name = "btn_branch_manager"
        Me.btn_branch_manager.Size = New System.Drawing.Size(75, 35)
        Me.btn_branch_manager.TabIndex = 22
        Me.btn_branch_manager.Text = "مدير القسم"
        Me.btn_branch_manager.UseVisualStyleBackColor = True
        Me.btn_branch_manager.Visible = False
        '
        'btn_manager
        '
        Me.btn_manager.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_manager.Location = New System.Drawing.Point(296, 348)
        Me.btn_manager.Name = "btn_manager"
        Me.btn_manager.Size = New System.Drawing.Size(75, 35)
        Me.btn_manager.TabIndex = 23
        Me.btn_manager.Text = "المدير"
        Me.btn_manager.UseVisualStyleBackColor = True
        Me.btn_manager.Visible = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(431, 402)
        Me.Controls.Add(Me.btn_manager)
        Me.Controls.Add(Me.btn_branch_manager)
        Me.Controls.Add(Me.btn_end)
        Me.Controls.Add(Me.btn_emp)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.chk_emp)
        Me.Controls.Add(Me.chk_lib_manager)
        Me.Controls.Add(Me.chk_branch)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "login"
        Me.Text = "login"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chk_branch As System.Windows.Forms.CheckBox
    Friend WithEvents chk_lib_manager As System.Windows.Forms.CheckBox
    Friend WithEvents chk_emp As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_pass_server As System.Windows.Forms.TextBox
    Friend WithEvents txt_user_server As System.Windows.Forms.TextBox
    Friend WithEvents txt_database As System.Windows.Forms.TextBox
    Friend WithEvents txt_server As System.Windows.Forms.TextBox
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_record As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents txt_user As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_emp As System.Windows.Forms.Button
    Friend WithEvents btn_end As System.Windows.Forms.Button
    Friend WithEvents btn_branch_manager As System.Windows.Forms.Button
    Friend WithEvents btn_manager As System.Windows.Forms.Button
End Class
