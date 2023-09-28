<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class accounts
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_emp_search = New System.Windows.Forms.Button()
        Me.cmb_emp_search = New System.Windows.Forms.ComboBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_emp_name = New System.Windows.Forms.TextBox()
        Me.txt_decrease = New System.Windows.Forms.TextBox()
        Me.txt_increase_2 = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txt_increase_1 = New System.Windows.Forms.TextBox()
        Me.txt_total_salary = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmb_month = New System.Windows.Forms.ComboBox()
        Me.cmb_emp_name = New System.Windows.Forms.ComboBox()
        Me.txt_job = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.txt_basic_salary = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(107, 5)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 19)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "البحث عن بيانات حسابات الموظفين"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_emp_search)
        Me.GroupBox2.Controls.Add(Me.cmb_emp_search)
        Me.GroupBox2.Location = New System.Drawing.Point(20, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(404, 51)
        Me.GroupBox2.TabIndex = 42
        Me.GroupBox2.TabStop = False
        '
        'btn_emp_search
        '
        Me.btn_emp_search.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_emp_search.Location = New System.Drawing.Point(310, 14)
        Me.btn_emp_search.Name = "btn_emp_search"
        Me.btn_emp_search.Size = New System.Drawing.Size(78, 25)
        Me.btn_emp_search.TabIndex = 35
        Me.btn_emp_search.Text = "بحث"
        Me.btn_emp_search.UseVisualStyleBackColor = True
        '
        'cmb_emp_search
        '
        Me.cmb_emp_search.FormattingEnabled = True
        Me.cmb_emp_search.Location = New System.Drawing.Point(6, 15)
        Me.cmb_emp_search.Name = "cmb_emp_search"
        Me.cmb_emp_search.Size = New System.Drawing.Size(290, 21)
        Me.cmb_emp_search.TabIndex = 34
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(12, 348)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 35)
        Me.btn_back.TabIndex = 41
        Me.btn_back.Text = "رجوع"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(93, 348)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 35)
        Me.btn_delete.TabIndex = 39
        Me.btn_delete.Text = "حذف"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(174, 348)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 35)
        Me.btn_update.TabIndex = 40
        Me.btn_update.Text = "تعديل"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(255, 348)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 35)
        Me.btn_save.TabIndex = 37
        Me.btn_save.Text = "حفظ"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.Location = New System.Drawing.Point(336, 348)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(75, 35)
        Me.btn_new.TabIndex = 38
        Me.btn_new.Text = "جديد"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_emp_name)
        Me.GroupBox1.Controls.Add(Me.txt_decrease)
        Me.GroupBox1.Controls.Add(Me.txt_increase_2)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_increase_1)
        Me.GroupBox1.Controls.Add(Me.txt_total_salary)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.cmb_month)
        Me.GroupBox1.Controls.Add(Me.cmb_emp_name)
        Me.GroupBox1.Controls.Add(Me.txt_job)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_code)
        Me.GroupBox1.Controls.Add(Me.txt_basic_salary)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 108)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(403, 234)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(324, 50)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 19)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "إسم الموظف"
        '
        'txt_emp_name
        '
        Me.txt_emp_name.Enabled = False
        Me.txt_emp_name.Location = New System.Drawing.Point(12, 49)
        Me.txt_emp_name.Name = "txt_emp_name"
        Me.txt_emp_name.Size = New System.Drawing.Size(306, 20)
        Me.txt_emp_name.TabIndex = 35
        '
        'txt_decrease
        '
        Me.txt_decrease.Location = New System.Drawing.Point(199, 206)
        Me.txt_decrease.Name = "txt_decrease"
        Me.txt_decrease.Size = New System.Drawing.Size(131, 20)
        Me.txt_decrease.TabIndex = 34
        '
        'txt_increase_2
        '
        Me.txt_increase_2.Location = New System.Drawing.Point(12, 162)
        Me.txt_increase_2.Name = "txt_increase_2"
        Me.txt_increase_2.Size = New System.Drawing.Size(123, 20)
        Me.txt_increase_2.TabIndex = 33
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(141, 163)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(53, 19)
        Me.Label11.TabIndex = 32
        Me.Label11.Text = "العلاوات"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(336, 207)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(65, 19)
        Me.Label12.TabIndex = 31
        Me.Label12.Text = "الخصومات"
        '
        'txt_increase_1
        '
        Me.txt_increase_1.Location = New System.Drawing.Point(201, 163)
        Me.txt_increase_1.Name = "txt_increase_1"
        Me.txt_increase_1.Size = New System.Drawing.Size(129, 20)
        Me.txt_increase_1.TabIndex = 30
        '
        'txt_total_salary
        '
        Me.txt_total_salary.Location = New System.Drawing.Point(12, 205)
        Me.txt_total_salary.Name = "txt_total_salary"
        Me.txt_total_salary.Size = New System.Drawing.Size(123, 20)
        Me.txt_total_salary.TabIndex = 29
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(141, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(53, 19)
        Me.Label4.TabIndex = 28
        Me.Label4.Text = "الاجمالى"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(341, 164)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 19)
        Me.Label10.TabIndex = 27
        Me.Label10.Text = "الزيادات"
        '
        'cmb_month
        '
        Me.cmb_month.FormattingEnabled = True
        Me.cmb_month.Items.AddRange(New Object() {"يناير", "فبراير", "مارس", "ابريل", "مايو", "يونيو", "يوليو", "اغسطس", "سبتمبر", "اكتوبر", "نوفمبر", "ديسمبر"})
        Me.cmb_month.Location = New System.Drawing.Point(12, 84)
        Me.cmb_month.Name = "cmb_month"
        Me.cmb_month.Size = New System.Drawing.Size(123, 21)
        Me.cmb_month.TabIndex = 26
        '
        'cmb_emp_name
        '
        Me.cmb_emp_name.FormattingEnabled = True
        Me.cmb_emp_name.Location = New System.Drawing.Point(12, 16)
        Me.cmb_emp_name.Name = "cmb_emp_name"
        Me.cmb_emp_name.Size = New System.Drawing.Size(308, 21)
        Me.cmb_emp_name.TabIndex = 25
        '
        'txt_job
        '
        Me.txt_job.Enabled = False
        Me.txt_job.Location = New System.Drawing.Point(201, 120)
        Me.txt_job.Name = "txt_job"
        Me.txt_job.Size = New System.Drawing.Size(129, 20)
        Me.txt_job.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(326, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "كود الموظف"
        '
        'txt_code
        '
        Me.txt_code.Enabled = False
        Me.txt_code.Location = New System.Drawing.Point(201, 85)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(119, 20)
        Me.txt_code.TabIndex = 17
        '
        'txt_basic_salary
        '
        Me.txt_basic_salary.Location = New System.Drawing.Point(12, 120)
        Me.txt_basic_salary.Name = "txt_basic_salary"
        Me.txt_basic_salary.Size = New System.Drawing.Size(123, 20)
        Me.txt_basic_salary.TabIndex = 15
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(141, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 19)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "الاساسى"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(344, 119)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 19)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "الوظيفة"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(152, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "الشهر"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(326, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "إسم الموظف"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(107, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 19)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "تسجيل بيانات حسابات الموظفين"
        '
        'accounts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(437, 394)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "accounts"
        Me.Text = "accounts"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_emp_search As System.Windows.Forms.Button
    Friend WithEvents cmb_emp_search As System.Windows.Forms.ComboBox
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_job As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_code As System.Windows.Forms.TextBox
    Friend WithEvents txt_basic_salary As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cmb_emp_name As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_month As System.Windows.Forms.ComboBox
    Friend WithEvents txt_decrease As System.Windows.Forms.TextBox
    Friend WithEvents txt_increase_2 As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txt_increase_1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_total_salary As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_emp_name As System.Windows.Forms.TextBox
End Class
