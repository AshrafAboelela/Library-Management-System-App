<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class year_inventory
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
        Me.components = New System.ComponentModel.Container()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_year = New System.Windows.Forms.TextBox()
        Me.cmb_emp = New System.Windows.Forms.ComboBox()
        Me.cmb_day = New System.Windows.Forms.ComboBox()
        Me.cmb_month = New System.Windows.Forms.ComboBox()
        Me.txt_lost_num = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_current_num = New System.Windows.Forms.TextBox()
        Me.txt_original_num = New System.Windows.Forms.TextBox()
        Me.txt_time = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_process_num = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(7, 348)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 35)
        Me.btn_back.TabIndex = 52
        Me.btn_back.Text = "رجوع"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(138, 348)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 35)
        Me.btn_save.TabIndex = 48
        Me.btn_save.Text = "حفظ"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.Location = New System.Drawing.Point(279, 348)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(75, 35)
        Me.btn_new.TabIndex = 49
        Me.btn_new.Text = "جديد"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 19)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "شاشة الجرد السنوى"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_year)
        Me.GroupBox1.Controls.Add(Me.cmb_emp)
        Me.GroupBox1.Controls.Add(Me.cmb_day)
        Me.GroupBox1.Controls.Add(Me.cmb_month)
        Me.GroupBox1.Controls.Add(Me.txt_lost_num)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_current_num)
        Me.GroupBox1.Controls.Add(Me.txt_original_num)
        Me.GroupBox1.Controls.Add(Me.txt_time)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_process_num)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 314)
        Me.GroupBox1.TabIndex = 53
        Me.GroupBox1.TabStop = False
        '
        'txt_year
        '
        Me.txt_year.Location = New System.Drawing.Point(14, 11)
        Me.txt_year.Name = "txt_year"
        Me.txt_year.Size = New System.Drawing.Size(242, 20)
        Me.txt_year.TabIndex = 43
        '
        'cmb_emp
        '
        Me.cmb_emp.FormattingEnabled = True
        Me.cmb_emp.Location = New System.Drawing.Point(12, 183)
        Me.cmb_emp.Name = "cmb_emp"
        Me.cmb_emp.Size = New System.Drawing.Size(242, 21)
        Me.cmb_emp.TabIndex = 42
        '
        'cmb_day
        '
        Me.cmb_day.FormattingEnabled = True
        Me.cmb_day.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20", "21", "22", "23", "24", "25", "26", "27", "28", "29", "30", "31"})
        Me.cmb_day.Location = New System.Drawing.Point(13, 107)
        Me.cmb_day.Name = "cmb_day"
        Me.cmb_day.Size = New System.Drawing.Size(243, 21)
        Me.cmb_day.TabIndex = 40
        '
        'cmb_month
        '
        Me.cmb_month.FormattingEnabled = True
        Me.cmb_month.Items.AddRange(New Object() {"يناير", "فبراير", "مارس", "أبريل", "مايو", "يونيو", "يوليو", "أغسطس", "سبتمبر", "أكتوبر", "نوفمبر", "ديسمبر"})
        Me.cmb_month.Location = New System.Drawing.Point(12, 71)
        Me.cmb_month.Name = "cmb_month"
        Me.cmb_month.Size = New System.Drawing.Size(243, 21)
        Me.cmb_month.TabIndex = 39
        '
        'txt_lost_num
        '
        Me.txt_lost_num.Location = New System.Drawing.Point(12, 288)
        Me.txt_lost_num.Name = "txt_lost_num"
        Me.txt_lost_num.Size = New System.Drawing.Size(92, 20)
        Me.txt_lost_num.TabIndex = 32
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(110, 289)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(162, 19)
        Me.Label10.TabIndex = 31
        Me.Label10.Text = "عدد الكتب المفقودة خلال العام"
        '
        'txt_current_num
        '
        Me.txt_current_num.Location = New System.Drawing.Point(13, 253)
        Me.txt_current_num.Name = "txt_current_num"
        Me.txt_current_num.Size = New System.Drawing.Size(91, 20)
        Me.txt_current_num.TabIndex = 30
        '
        'txt_original_num
        '
        Me.txt_original_num.Location = New System.Drawing.Point(13, 217)
        Me.txt_original_num.Name = "txt_original_num"
        Me.txt_original_num.Size = New System.Drawing.Size(91, 20)
        Me.txt_original_num.TabIndex = 29
        '
        'txt_time
        '
        Me.txt_time.Location = New System.Drawing.Point(12, 146)
        Me.txt_time.Name = "txt_time"
        Me.txt_time.Size = New System.Drawing.Size(242, 20)
        Me.txt_time.TabIndex = 28
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(110, 218)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(217, 19)
        Me.Label8.TabIndex = 27
        Me.Label8.Text = "عدد الكتب الاصلية فى المكتبة خلال العام"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(114, 252)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(213, 19)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "عدد الكتب الحالية فى المكتبة خلال العام"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(260, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 19)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "الساعة"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(263, 187)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 19)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "اسم الموظف"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(267, 39)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "رقم العملية"
        '
        'txt_process_num
        '
        Me.txt_process_num.Location = New System.Drawing.Point(12, 42)
        Me.txt_process_num.Name = "txt_process_num"
        Me.txt_process_num.Size = New System.Drawing.Size(242, 20)
        Me.txt_process_num.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(260, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(34, 19)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "اليوم"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(260, 70)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(41, 19)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "الشهر"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(268, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "السنة"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'year_inventory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(360, 393)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.Label1)
        Me.Name = "year_inventory"
        Me.Text = "year_inventory"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_day As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_month As System.Windows.Forms.ComboBox
    Friend WithEvents txt_lost_num As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_current_num As System.Windows.Forms.TextBox
    Friend WithEvents txt_original_num As System.Windows.Forms.TextBox
    Friend WithEvents txt_time As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_process_num As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_emp As System.Windows.Forms.ComboBox
    Friend WithEvents txt_year As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
