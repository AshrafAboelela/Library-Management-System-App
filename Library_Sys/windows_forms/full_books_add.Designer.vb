<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class full_books_add
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
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cmb_book_name = New System.Windows.Forms.ComboBox()
        Me.txt_book_code = New System.Windows.Forms.TextBox()
        Me.dtp_reg_date = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_auther_name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_isbn = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_right = New System.Windows.Forms.Button()
        Me.btn_middle = New System.Windows.Forms.Button()
        Me.btn_left = New System.Windows.Forms.Button()
        Me.btn_book_color = New System.Windows.Forms.Button()
        Me.btn_line_color = New System.Windows.Forms.Button()
        Me.btn_line = New System.Windows.Forms.Button()
        Me.txt_full_book = New System.Windows.Forms.TextBox()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_new
        '
        Me.btn_new.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.Location = New System.Drawing.Point(12, 46)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(75, 35)
        Me.btn_new.TabIndex = 77
        Me.btn_new.Text = "جديد"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(12, 302)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 35)
        Me.btn_back.TabIndex = 76
        Me.btn_back.Text = "رجوع"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(12, 177)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 35)
        Me.btn_save.TabIndex = 73
        Me.btn_save.Text = "حفظ"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.cmb_book_name)
        Me.GroupBox1.Controls.Add(Me.txt_book_code)
        Me.GroupBox1.Controls.Add(Me.dtp_reg_date)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_auther_name)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_isbn)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(107, 30)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(466, 178)
        Me.GroupBox1.TabIndex = 72
        Me.GroupBox1.TabStop = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(384, 46)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 19)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "كود الكتاب"
        '
        'cmb_book_name
        '
        Me.cmb_book_name.FormattingEnabled = True
        Me.cmb_book_name.Location = New System.Drawing.Point(14, 16)
        Me.cmb_book_name.Name = "cmb_book_name"
        Me.cmb_book_name.Size = New System.Drawing.Size(354, 21)
        Me.cmb_book_name.TabIndex = 38
        '
        'txt_book_code
        '
        Me.txt_book_code.Enabled = False
        Me.txt_book_code.Location = New System.Drawing.Point(13, 47)
        Me.txt_book_code.Name = "txt_book_code"
        Me.txt_book_code.Size = New System.Drawing.Size(357, 20)
        Me.txt_book_code.TabIndex = 34
        '
        'dtp_reg_date
        '
        Me.dtp_reg_date.Location = New System.Drawing.Point(12, 147)
        Me.dtp_reg_date.Name = "dtp_reg_date"
        Me.dtp_reg_date.Size = New System.Drawing.Size(356, 20)
        Me.dtp_reg_date.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(377, 147)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(82, 19)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "تاريخ التسجيل"
        '
        'txt_auther_name
        '
        Me.txt_auther_name.Enabled = False
        Me.txt_auther_name.Location = New System.Drawing.Point(13, 112)
        Me.txt_auther_name.Name = "txt_auther_name"
        Me.txt_auther_name.Size = New System.Drawing.Size(357, 20)
        Me.txt_auther_name.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(384, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 19)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "الرقم العام"
        '
        'txt_isbn
        '
        Me.txt_isbn.Enabled = False
        Me.txt_isbn.Location = New System.Drawing.Point(13, 80)
        Me.txt_isbn.Name = "txt_isbn"
        Me.txt_isbn.Size = New System.Drawing.Size(357, 20)
        Me.txt_isbn.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(388, 113)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(71, 19)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "اسم المؤلف"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(384, 15)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 19)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "إسم الكتاب"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(225, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 19)
        Me.Label1.TabIndex = 71
        Me.Label1.Text = "التسجيل الكامل للكتاب"
        '
        'btn_right
        '
        Me.btn_right.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_right.Location = New System.Drawing.Point(499, 214)
        Me.btn_right.Name = "btn_right"
        Me.btn_right.Size = New System.Drawing.Size(76, 24)
        Me.btn_right.TabIndex = 78
        Me.btn_right.Text = "ازاحة يمين"
        Me.btn_right.UseVisualStyleBackColor = True
        '
        'btn_middle
        '
        Me.btn_middle.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_middle.Location = New System.Drawing.Point(409, 214)
        Me.btn_middle.Name = "btn_middle"
        Me.btn_middle.Size = New System.Drawing.Size(86, 24)
        Me.btn_middle.TabIndex = 79
        Me.btn_middle.Text = "ازاحة وسط"
        Me.btn_middle.UseVisualStyleBackColor = True
        '
        'btn_left
        '
        Me.btn_left.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_left.Location = New System.Drawing.Point(328, 214)
        Me.btn_left.Name = "btn_left"
        Me.btn_left.Size = New System.Drawing.Size(77, 24)
        Me.btn_left.TabIndex = 80
        Me.btn_left.Text = "ازاحة يسار"
        Me.btn_left.UseVisualStyleBackColor = True
        '
        'btn_book_color
        '
        Me.btn_book_color.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_book_color.Location = New System.Drawing.Point(107, 214)
        Me.btn_book_color.Name = "btn_book_color"
        Me.btn_book_color.Size = New System.Drawing.Size(84, 24)
        Me.btn_book_color.TabIndex = 83
        Me.btn_book_color.Text = "لون الصفحة"
        Me.btn_book_color.UseVisualStyleBackColor = True
        '
        'btn_line_color
        '
        Me.btn_line_color.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_line_color.Location = New System.Drawing.Point(198, 214)
        Me.btn_line_color.Name = "btn_line_color"
        Me.btn_line_color.Size = New System.Drawing.Size(65, 24)
        Me.btn_line_color.TabIndex = 82
        Me.btn_line_color.Text = "لون الخط"
        Me.btn_line_color.UseVisualStyleBackColor = True
        '
        'btn_line
        '
        Me.btn_line.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_line.Location = New System.Drawing.Point(271, 214)
        Me.btn_line.Name = "btn_line"
        Me.btn_line.Size = New System.Drawing.Size(51, 24)
        Me.btn_line.TabIndex = 81
        Me.btn_line.Text = "الخط"
        Me.btn_line.UseVisualStyleBackColor = True
        '
        'txt_full_book
        '
        Me.txt_full_book.Location = New System.Drawing.Point(107, 244)
        Me.txt_full_book.Multiline = True
        Me.txt_full_book.Name = "txt_full_book"
        Me.txt_full_book.Size = New System.Drawing.Size(468, 108)
        Me.txt_full_book.TabIndex = 84
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'full_books_add
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 359)
        Me.Controls.Add(Me.txt_full_book)
        Me.Controls.Add(Me.btn_book_color)
        Me.Controls.Add(Me.btn_line_color)
        Me.Controls.Add(Me.btn_line)
        Me.Controls.Add(Me.btn_left)
        Me.Controls.Add(Me.btn_middle)
        Me.Controls.Add(Me.btn_right)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "full_books_add"
        Me.Text = "full_books_add"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_book_name As System.Windows.Forms.ComboBox
    Friend WithEvents txt_book_code As System.Windows.Forms.TextBox
    Friend WithEvents dtp_reg_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_auther_name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_isbn As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_right As System.Windows.Forms.Button
    Friend WithEvents btn_middle As System.Windows.Forms.Button
    Friend WithEvents btn_left As System.Windows.Forms.Button
    Friend WithEvents btn_book_color As System.Windows.Forms.Button
    Friend WithEvents btn_line_color As System.Windows.Forms.Button
    Friend WithEvents btn_line As System.Windows.Forms.Button
    Friend WithEvents txt_full_book As System.Windows.Forms.TextBox
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
End Class
