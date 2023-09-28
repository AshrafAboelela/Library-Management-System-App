<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reserve_group_book
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
        Me.txt_book_4 = New System.Windows.Forms.TextBox()
        Me.txt_book_3 = New System.Windows.Forms.TextBox()
        Me.txt_book_2 = New System.Windows.Forms.TextBox()
        Me.txt_book_1 = New System.Windows.Forms.TextBox()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_doctor_name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_reserve_date = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_stu_name = New System.Windows.Forms.TextBox()
        Me.txt_process_num = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.txt_book_6 = New System.Windows.Forms.TextBox()
        Me.txt_book_5 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(49, 327)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 35)
        Me.btn_back.TabIndex = 167
        Me.btn_back.Text = "رجوع"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'txt_book_4
        '
        Me.txt_book_4.Location = New System.Drawing.Point(17, 228)
        Me.txt_book_4.Name = "txt_book_4"
        Me.txt_book_4.Size = New System.Drawing.Size(173, 20)
        Me.txt_book_4.TabIndex = 158
        '
        'txt_book_3
        '
        Me.txt_book_3.Location = New System.Drawing.Point(196, 285)
        Me.txt_book_3.Name = "txt_book_3"
        Me.txt_book_3.Size = New System.Drawing.Size(149, 20)
        Me.txt_book_3.TabIndex = 157
        '
        'txt_book_2
        '
        Me.txt_book_2.Location = New System.Drawing.Point(196, 259)
        Me.txt_book_2.Name = "txt_book_2"
        Me.txt_book_2.Size = New System.Drawing.Size(149, 20)
        Me.txt_book_2.TabIndex = 156
        '
        'txt_book_1
        '
        Me.txt_book_1.Location = New System.Drawing.Point(196, 230)
        Me.txt_book_1.Name = "txt_book_1"
        Me.txt_book_1.Size = New System.Drawing.Size(149, 20)
        Me.txt_book_1.TabIndex = 155
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(367, 68)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(186, 254)
        Me.ListView1.TabIndex = 154
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(150, 327)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 35)
        Me.btn_save.TabIndex = 152
        Me.btn_save.Text = "حفظ"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.Location = New System.Drawing.Point(249, 327)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(75, 35)
        Me.btn_new.TabIndex = 153
        Me.btn_new.Text = "جديد"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_doctor_name)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtp_reserve_date)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_stu_name)
        Me.GroupBox1.Controls.Add(Me.txt_process_num)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 32)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(337, 162)
        Me.GroupBox1.TabIndex = 151
        Me.GroupBox1.TabStop = False
        '
        'txt_doctor_name
        '
        Me.txt_doctor_name.Location = New System.Drawing.Point(17, 54)
        Me.txt_doctor_name.Name = "txt_doctor_name"
        Me.txt_doctor_name.Size = New System.Drawing.Size(216, 20)
        Me.txt_doctor_name.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(246, 55)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 19)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "اسم الدكتور"
        '
        'dtp_reserve_date
        '
        Me.dtp_reserve_date.Location = New System.Drawing.Point(18, 125)
        Me.dtp_reserve_date.Name = "dtp_reserve_date"
        Me.dtp_reserve_date.Size = New System.Drawing.Size(215, 20)
        Me.dtp_reserve_date.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(239, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 19)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "تاريخ الحجز"
        '
        'txt_stu_name
        '
        Me.txt_stu_name.Location = New System.Drawing.Point(16, 88)
        Me.txt_stu_name.Name = "txt_stu_name"
        Me.txt_stu_name.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txt_stu_name.Size = New System.Drawing.Size(216, 20)
        Me.txt_stu_name.TabIndex = 24
        '
        'txt_process_num
        '
        Me.txt_process_num.Location = New System.Drawing.Point(15, 18)
        Me.txt_process_num.Name = "txt_process_num"
        Me.txt_process_num.Size = New System.Drawing.Size(216, 20)
        Me.txt_process_num.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(246, 89)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 19)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "اسم الطالب"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(247, 17)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "رقم العملية"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(188, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 19)
        Me.Label1.TabIndex = 150
        Me.Label1.Text = "شاشة حجز مجموعة كتب"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'txt_book_6
        '
        Me.txt_book_6.Location = New System.Drawing.Point(17, 286)
        Me.txt_book_6.Name = "txt_book_6"
        Me.txt_book_6.Size = New System.Drawing.Size(173, 20)
        Me.txt_book_6.TabIndex = 169
        '
        'txt_book_5
        '
        Me.txt_book_5.Location = New System.Drawing.Point(17, 260)
        Me.txt_book_5.Name = "txt_book_5"
        Me.txt_book_5.Size = New System.Drawing.Size(173, 20)
        Me.txt_book_5.TabIndex = 168
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(398, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 170
        Me.Label2.Text = "جميع الكتب"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(123, 204)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(133, 19)
        Me.Label6.TabIndex = 171
        Me.Label6.Text = "حدد الكتب المراد حجزها"
        '
        'reserve_group_book
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(564, 374)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_book_6)
        Me.Controls.Add(Me.txt_book_5)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.txt_book_4)
        Me.Controls.Add(Me.txt_book_3)
        Me.Controls.Add(Me.txt_book_2)
        Me.Controls.Add(Me.txt_book_1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "reserve_group_book"
        Me.Text = "reserve_group_book"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents txt_book_4 As System.Windows.Forms.TextBox
    Friend WithEvents txt_book_3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_book_2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_book_1 As System.Windows.Forms.TextBox
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_doctor_name As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtp_reserve_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_stu_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_process_num As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txt_book_6 As System.Windows.Forms.TextBox
    Friend WithEvents txt_book_5 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class
