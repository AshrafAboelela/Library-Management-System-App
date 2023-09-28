<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class all_absence_employees
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.cmb_emp_search = New System.Windows.Forms.ComboBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.cmb_day = New System.Windows.Forms.ComboBox()
        Me.cmb_month = New System.Windows.Forms.ComboBox()
        Me.txt_notes = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_job = New System.Windows.Forms.TextBox()
        Me.txt_code = New System.Windows.Forms.TextBox()
        Me.txt_emp_name = New System.Windows.Forms.TextBox()
        Me.txt_num = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_all_abs_emps = New System.Windows.Forms.Button()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column6, Me.Column4, Me.Column5, Me.Column7, Me.Column8})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 110)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(613, 212)
        Me.DataGridView1.TabIndex = 37
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(249, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(178, 19)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "البحث عن بيانات غياب الموظفين"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_all_abs_emps)
        Me.GroupBox2.Controls.Add(Me.btn_search)
        Me.GroupBox2.Controls.Add(Me.cmb_emp_search)
        Me.GroupBox2.Location = New System.Drawing.Point(105, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(803, 61)
        Me.GroupBox2.TabIndex = 35
        Me.GroupBox2.TabStop = False
        '
        'btn_search
        '
        Me.btn_search.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.Location = New System.Drawing.Point(277, 21)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(132, 25)
        Me.btn_search.TabIndex = 35
        Me.btn_search.Text = "بحث عن غياب موظف"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'cmb_emp_search
        '
        Me.cmb_emp_search.FormattingEnabled = True
        Me.cmb_emp_search.Location = New System.Drawing.Point(429, 25)
        Me.cmb_emp_search.Name = "cmb_emp_search"
        Me.cmb_emp_search.Size = New System.Drawing.Size(350, 21)
        Me.cmb_emp_search.TabIndex = 34
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(24, 47)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 35)
        Me.btn_back.TabIndex = 38
        Me.btn_back.Text = "رجوع"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'cmb_day
        '
        Me.cmb_day.Enabled = False
        Me.cmb_day.FormattingEnabled = True
        Me.cmb_day.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmb_day.Location = New System.Drawing.Point(650, 233)
        Me.cmb_day.Name = "cmb_day"
        Me.cmb_day.Size = New System.Drawing.Size(84, 21)
        Me.cmb_day.TabIndex = 52
        '
        'cmb_month
        '
        Me.cmb_month.Enabled = False
        Me.cmb_month.FormattingEnabled = True
        Me.cmb_month.Items.AddRange(New Object() {"يناير", "فبراير", "مارس", "ابريل", "مايو", "يونيو", "يوليو", "اغسطس", "سبتمبر", "اكتوبر", "نوفمبر", "ديسمبر"})
        Me.cmb_month.Location = New System.Drawing.Point(780, 233)
        Me.cmb_month.Name = "cmb_month"
        Me.cmb_month.Size = New System.Drawing.Size(57, 21)
        Me.cmb_month.TabIndex = 51
        '
        'txt_notes
        '
        Me.txt_notes.Enabled = False
        Me.txt_notes.Location = New System.Drawing.Point(650, 265)
        Me.txt_notes.Multiline = True
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.Size = New System.Drawing.Size(187, 60)
        Me.txt_notes.TabIndex = 50
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(843, 270)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 19)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "ملاحظات"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(740, 234)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 19)
        Me.Label1.TabIndex = 48
        Me.Label1.Text = "اليوم"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(849, 235)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 19)
        Me.Label4.TabIndex = 47
        Me.Label4.Text = "الشهر"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(842, 111)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 19)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "إسم الموظف"
        '
        'txt_job
        '
        Me.txt_job.Enabled = False
        Me.txt_job.Location = New System.Drawing.Point(649, 172)
        Me.txt_job.Name = "txt_job"
        Me.txt_job.Size = New System.Drawing.Size(180, 20)
        Me.txt_job.TabIndex = 45
        '
        'txt_code
        '
        Me.txt_code.Enabled = False
        Me.txt_code.Location = New System.Drawing.Point(649, 141)
        Me.txt_code.Name = "txt_code"
        Me.txt_code.Size = New System.Drawing.Size(180, 20)
        Me.txt_code.TabIndex = 44
        '
        'txt_emp_name
        '
        Me.txt_emp_name.Enabled = False
        Me.txt_emp_name.Location = New System.Drawing.Point(650, 110)
        Me.txt_emp_name.Name = "txt_emp_name"
        Me.txt_emp_name.Size = New System.Drawing.Size(180, 20)
        Me.txt_emp_name.TabIndex = 43
        '
        'txt_num
        '
        Me.txt_num.Enabled = False
        Me.txt_num.Location = New System.Drawing.Point(650, 198)
        Me.txt_num.Name = "txt_num"
        Me.txt_num.Size = New System.Drawing.Size(180, 20)
        Me.txt_num.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(835, 199)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 19)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "عدد ايام الغياب"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(842, 173)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 19)
        Me.Label8.TabIndex = 40
        Me.Label8.Text = "الوظيفة"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(835, 142)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 19)
        Me.Label5.TabIndex = 39
        Me.Label5.Text = "كود الموظف"
        '
        'btn_all_abs_emps
        '
        Me.btn_all_abs_emps.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_all_abs_emps.Location = New System.Drawing.Point(27, 21)
        Me.btn_all_abs_emps.Name = "btn_all_abs_emps"
        Me.btn_all_abs_emps.Size = New System.Drawing.Size(232, 25)
        Me.btn_all_abs_emps.TabIndex = 37
        Me.btn_all_abs_emps.Text = "عرض بيانات غياب جميع الموظفين"
        Me.btn_all_abs_emps.UseVisualStyleBackColor = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "رقم السجل"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "كود الموظف"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "اسم الموظف"
        Me.Column3.Name = "Column3"
        '
        'Column6
        '
        Me.Column6.HeaderText = "الوظيفة"
        Me.Column6.Name = "Column6"
        '
        'Column4
        '
        Me.Column4.HeaderText = "عدد ايام الغياب"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "الشهر"
        Me.Column5.Name = "Column5"
        '
        'Column7
        '
        Me.Column7.HeaderText = "اليوم"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "ملاحظات"
        Me.Column8.Name = "Column8"
        '
        'all_absence_employees
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(924, 337)
        Me.Controls.Add(Me.cmb_day)
        Me.Controls.Add(Me.cmb_month)
        Me.Controls.Add(Me.txt_notes)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_job)
        Me.Controls.Add(Me.txt_code)
        Me.Controls.Add(Me.txt_emp_name)
        Me.Controls.Add(Me.txt_num)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "all_absence_employees"
        Me.Text = "all_absence_employees"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents cmb_emp_search As System.Windows.Forms.ComboBox
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents cmb_day As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_month As System.Windows.Forms.ComboBox
    Friend WithEvents txt_notes As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_job As System.Windows.Forms.TextBox
    Friend WithEvents txt_code As System.Windows.Forms.TextBox
    Friend WithEvents txt_emp_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_num As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btn_all_abs_emps As System.Windows.Forms.Button
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
