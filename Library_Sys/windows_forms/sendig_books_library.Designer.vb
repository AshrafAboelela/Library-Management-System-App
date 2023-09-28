<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sendig_books_library
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cmb_lib_name = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_reserved_date = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_recieved_date = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_notes = New System.Windows.Forms.TextBox()
        Me.txt_sending_num = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.txt_book_1 = New System.Windows.Forms.TextBox()
        Me.txt_book_2 = New System.Windows.Forms.TextBox()
        Me.txt_book_3 = New System.Windows.Forms.TextBox()
        Me.txt_book_4 = New System.Windows.Forms.TextBox()
        Me.txt_book_6 = New System.Windows.Forms.TextBox()
        Me.txt_book_5 = New System.Windows.Forms.TextBox()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.dtp_res = New System.Windows.Forms.DateTimePicker()
        Me.dtp_rec = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cmb_lib_name)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtp_reserved_date)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtp_recieved_date)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_notes)
        Me.GroupBox1.Controls.Add(Me.txt_sending_num)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(3, 28)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(400, 211)
        Me.GroupBox1.TabIndex = 61
        Me.GroupBox1.TabStop = False
        '
        'cmb_lib_name
        '
        Me.cmb_lib_name.FormattingEnabled = True
        Me.cmb_lib_name.Location = New System.Drawing.Point(14, 42)
        Me.cmb_lib_name.Name = "cmb_lib_name"
        Me.cmb_lib_name.Size = New System.Drawing.Size(293, 21)
        Me.cmb_lib_name.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(323, 48)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 19)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "اسم المكتبة"
        '
        'dtp_reserved_date
        '
        Me.dtp_reserved_date.Location = New System.Drawing.Point(14, 145)
        Me.dtp_reserved_date.Name = "dtp_reserved_date"
        Me.dtp_reserved_date.Size = New System.Drawing.Size(293, 20)
        Me.dtp_reserved_date.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(313, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(72, 19)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "تاريخ الحجز"
        '
        'dtp_recieved_date
        '
        Me.dtp_recieved_date.Location = New System.Drawing.Point(12, 180)
        Me.dtp_recieved_date.Name = "dtp_recieved_date"
        Me.dtp_recieved_date.Size = New System.Drawing.Size(293, 20)
        Me.dtp_recieved_date.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(316, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 19)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "تاريخ التسليم"
        '
        'txt_notes
        '
        Me.txt_notes.Location = New System.Drawing.Point(13, 73)
        Me.txt_notes.Multiline = True
        Me.txt_notes.Name = "txt_notes"
        Me.txt_notes.Size = New System.Drawing.Size(294, 59)
        Me.txt_notes.TabIndex = 24
        '
        'txt_sending_num
        '
        Me.txt_sending_num.Location = New System.Drawing.Point(13, 11)
        Me.txt_sending_num.Name = "txt_sending_num"
        Me.txt_sending_num.Size = New System.Drawing.Size(294, 20)
        Me.txt_sending_num.TabIndex = 16
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(323, 91)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 19)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "ملاحظات"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(323, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "رقم العملية"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(183, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 19)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "ارسال طلبية كتب الى المكتبة"
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(409, 51)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(246, 195)
        Me.ListView1.TabIndex = 67
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'txt_book_1
        '
        Me.txt_book_1.Location = New System.Drawing.Point(411, 296)
        Me.txt_book_1.Name = "txt_book_1"
        Me.txt_book_1.Size = New System.Drawing.Size(118, 20)
        Me.txt_book_1.TabIndex = 68
        '
        'txt_book_2
        '
        Me.txt_book_2.Location = New System.Drawing.Point(411, 331)
        Me.txt_book_2.Name = "txt_book_2"
        Me.txt_book_2.Size = New System.Drawing.Size(118, 20)
        Me.txt_book_2.TabIndex = 69
        '
        'txt_book_3
        '
        Me.txt_book_3.Location = New System.Drawing.Point(411, 371)
        Me.txt_book_3.Name = "txt_book_3"
        Me.txt_book_3.Size = New System.Drawing.Size(118, 20)
        Me.txt_book_3.TabIndex = 70
        '
        'txt_book_4
        '
        Me.txt_book_4.Location = New System.Drawing.Point(535, 296)
        Me.txt_book_4.Name = "txt_book_4"
        Me.txt_book_4.Size = New System.Drawing.Size(122, 20)
        Me.txt_book_4.TabIndex = 71
        '
        'txt_book_6
        '
        Me.txt_book_6.Location = New System.Drawing.Point(535, 373)
        Me.txt_book_6.Name = "txt_book_6"
        Me.txt_book_6.Size = New System.Drawing.Size(122, 20)
        Me.txt_book_6.TabIndex = 81
        '
        'txt_book_5
        '
        Me.txt_book_5.Location = New System.Drawing.Point(535, 333)
        Me.txt_book_5.Name = "txt_book_5"
        Me.txt_book_5.Size = New System.Drawing.Size(122, 20)
        Me.txt_book_5.TabIndex = 80
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.btn_search)
        Me.GroupBox2.Controls.Add(Me.dtp_res)
        Me.GroupBox2.Controls.Add(Me.dtp_rec)
        Me.GroupBox2.Location = New System.Drawing.Point(3, 295)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(400, 113)
        Me.GroupBox2.TabIndex = 86
        Me.GroupBox2.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(294, 47)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 19)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "حدد تاريخ الحجز"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(289, 78)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 19)
        Me.Label7.TabIndex = 67
        Me.Label7.Text = "حدد تاريخ التسليم"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(99, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(238, 19)
        Me.Label11.TabIndex = 66
        Me.Label11.Text = "البحث باستخدام تاريخ الحجز و تاريخ التسليم"
        '
        'btn_search
        '
        Me.btn_search.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.Location = New System.Drawing.Point(4, 50)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 35)
        Me.btn_search.TabIndex = 65
        Me.btn_search.Text = "بحث"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'dtp_res
        '
        Me.dtp_res.Location = New System.Drawing.Point(87, 43)
        Me.dtp_res.Name = "dtp_res"
        Me.dtp_res.Size = New System.Drawing.Size(191, 20)
        Me.dtp_res.TabIndex = 32
        '
        'dtp_rec
        '
        Me.dtp_rec.Location = New System.Drawing.Point(85, 78)
        Me.dtp_rec.Name = "dtp_rec"
        Me.dtp_rec.Size = New System.Drawing.Size(193, 20)
        Me.dtp_rec.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(481, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 19)
        Me.Label2.TabIndex = 172
        Me.Label2.Text = "جميع الكتب"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(450, 270)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(167, 19)
        Me.Label10.TabIndex = 182
        Me.Label10.Text = "حدد الكتب المرسلة الى المكتبة"
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(3, 245)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 35)
        Me.btn_back.TabIndex = 187
        Me.btn_back.Text = "رجوع"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(84, 245)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 35)
        Me.btn_delete.TabIndex = 185
        Me.btn_delete.Text = "حذف"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(165, 245)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 35)
        Me.btn_update.TabIndex = 186
        Me.btn_update.Text = "تعديل"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(246, 245)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 35)
        Me.btn_save.TabIndex = 183
        Me.btn_save.Text = "حفظ"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.Location = New System.Drawing.Point(329, 245)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(69, 35)
        Me.btn_new.TabIndex = 184
        Me.btn_new.Text = "جديد"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'sendig_books_library
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(662, 409)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.txt_book_6)
        Me.Controls.Add(Me.txt_book_5)
        Me.Controls.Add(Me.txt_book_4)
        Me.Controls.Add(Me.txt_book_3)
        Me.Controls.Add(Me.txt_book_2)
        Me.Controls.Add(Me.txt_book_1)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "sendig_books_library"
        Me.Text = "sendig_books_library"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtp_reserved_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp_recieved_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_notes As System.Windows.Forms.TextBox
    Friend WithEvents txt_sending_num As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents txt_book_1 As System.Windows.Forms.TextBox
    Friend WithEvents txt_book_2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_book_3 As System.Windows.Forms.TextBox
    Friend WithEvents txt_book_4 As System.Windows.Forms.TextBox
    Friend WithEvents cmb_lib_name As System.Windows.Forms.ComboBox
    Friend WithEvents txt_book_6 As System.Windows.Forms.TextBox
    Friend WithEvents txt_book_5 As System.Windows.Forms.TextBox
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dtp_res As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtp_rec As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
End Class
