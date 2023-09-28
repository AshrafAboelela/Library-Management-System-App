<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class store_sales
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
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_sale_code_search = New System.Windows.Forms.TextBox()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_rem = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_payed = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_quan = New System.Windows.Forms.TextBox()
        Me.cmb_cust_name = New System.Windows.Forms.ComboBox()
        Me.cmb_book_name = New System.Windows.Forms.ComboBox()
        Me.txt_sale_code = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.dtp_sale_date = New System.Windows.Forms.DateTimePicker()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_book_price = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_new
        '
        Me.btn_new.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.Location = New System.Drawing.Point(669, 295)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(75, 35)
        Me.btn_new.TabIndex = 81
        Me.btn_new.Text = "جديد"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(345, 295)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 35)
        Me.btn_back.TabIndex = 80
        Me.btn_back.Text = "رجوع"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_delete.Location = New System.Drawing.Point(426, 295)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(75, 35)
        Me.btn_delete.TabIndex = 78
        Me.btn_delete.Text = "حذف"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_update.Location = New System.Drawing.Point(507, 295)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(75, 35)
        Me.btn_update.TabIndex = 79
        Me.btn_update.Text = "تعديل"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(588, 295)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 35)
        Me.btn_save.TabIndex = 77
        Me.btn_save.Text = "حفظ"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column4, Me.Column3, Me.Column6, Me.Column5, Me.Column8, Me.Column7, Me.Column1, Me.Column9})
        Me.DataGridView1.Location = New System.Drawing.Point(4, 93)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(326, 219)
        Me.DataGridView1.TabIndex = 76
        '
        'Column2
        '
        Me.Column2.HeaderText = "رقم حركة البيع"
        Me.Column2.Name = "Column2"
        '
        'Column4
        '
        Me.Column4.HeaderText = "اسم العميل"
        Me.Column4.Name = "Column4"
        '
        'Column3
        '
        Me.Column3.HeaderText = "اسم الكتاب"
        Me.Column3.Name = "Column3"
        '
        'Column6
        '
        Me.Column6.HeaderText = "الكمية"
        Me.Column6.Name = "Column6"
        '
        'Column5
        '
        Me.Column5.HeaderText = "سعر الكتاب"
        Me.Column5.Name = "Column5"
        '
        'Column8
        '
        Me.Column8.HeaderText = "المدفوع"
        Me.Column8.Name = "Column8"
        '
        'Column7
        '
        Me.Column7.HeaderText = "الاجمالى"
        Me.Column7.Name = "Column7"
        '
        'Column1
        '
        Me.Column1.HeaderText = "المتبقى"
        Me.Column1.Name = "Column1"
        '
        'Column9
        '
        Me.Column9.HeaderText = "تاريخ حركة البيع"
        Me.Column9.Name = "Column9"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(98, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(179, 19)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "البحث عن بيانات فاتورة بيع كتاب"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txt_sale_code_search)
        Me.GroupBox2.Controls.Add(Me.btn_search)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 31)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(328, 56)
        Me.GroupBox2.TabIndex = 74
        Me.GroupBox2.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(232, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 19)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "رقم حركة البيع"
        '
        'txt_sale_code_search
        '
        Me.txt_sale_code_search.Location = New System.Drawing.Point(70, 23)
        Me.txt_sale_code_search.Name = "txt_sale_code_search"
        Me.txt_sale_code_search.Size = New System.Drawing.Size(144, 20)
        Me.txt_sale_code_search.TabIndex = 37
        Me.txt_sale_code_search.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btn_search
        '
        Me.btn_search.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.Location = New System.Drawing.Point(8, 19)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(54, 25)
        Me.btn_search.TabIndex = 35
        Me.btn_search.Text = "بحث"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(456, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(160, 19)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "تسجيل بيانات فاتورة بيع كتاب"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.txt_rem)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.txt_payed)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.txt_quan)
        Me.GroupBox3.Controls.Add(Me.cmb_cust_name)
        Me.GroupBox3.Controls.Add(Me.cmb_book_name)
        Me.GroupBox3.Controls.Add(Me.txt_sale_code)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.dtp_sale_date)
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.txt_total)
        Me.GroupBox3.Controls.Add(Me.Label19)
        Me.GroupBox3.Controls.Add(Me.txt_book_price)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Location = New System.Drawing.Point(345, 31)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(379, 260)
        Me.GroupBox3.TabIndex = 82
        Me.GroupBox3.TabStop = False
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(283, 84)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(65, 19)
        Me.Label22.TabIndex = 44
        Me.Label22.Text = "إسم العميل"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(138, 191)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(46, 19)
        Me.Label13.TabIndex = 43
        Me.Label13.Text = "المتبقى"
        '
        'txt_rem
        '
        Me.txt_rem.Enabled = False
        Me.txt_rem.Location = New System.Drawing.Point(20, 190)
        Me.txt_rem.Name = "txt_rem"
        Me.txt_rem.Size = New System.Drawing.Size(110, 20)
        Me.txt_rem.TabIndex = 42
        Me.txt_rem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(298, 193)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 19)
        Me.Label14.TabIndex = 41
        Me.Label14.Text = "المدفوع"
        '
        'txt_payed
        '
        Me.txt_payed.Location = New System.Drawing.Point(196, 192)
        Me.txt_payed.Name = "txt_payed"
        Me.txt_payed.Size = New System.Drawing.Size(96, 20)
        Me.txt_payed.TabIndex = 40
        Me.txt_payed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(138, 120)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 19)
        Me.Label15.TabIndex = 39
        Me.Label15.Text = "الكمية"
        '
        'txt_quan
        '
        Me.txt_quan.Location = New System.Drawing.Point(22, 119)
        Me.txt_quan.Name = "txt_quan"
        Me.txt_quan.Size = New System.Drawing.Size(110, 20)
        Me.txt_quan.TabIndex = 38
        Me.txt_quan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cmb_cust_name
        '
        Me.cmb_cust_name.FormattingEnabled = True
        Me.cmb_cust_name.Location = New System.Drawing.Point(23, 84)
        Me.cmb_cust_name.Name = "cmb_cust_name"
        Me.cmb_cust_name.Size = New System.Drawing.Size(243, 21)
        Me.cmb_cust_name.TabIndex = 37
        '
        'cmb_book_name
        '
        Me.cmb_book_name.FormattingEnabled = True
        Me.cmb_book_name.Location = New System.Drawing.Point(24, 48)
        Me.cmb_book_name.Name = "cmb_book_name"
        Me.cmb_book_name.Size = New System.Drawing.Size(243, 21)
        Me.cmb_book_name.TabIndex = 35
        '
        'txt_sale_code
        '
        Me.txt_sale_code.Location = New System.Drawing.Point(23, 18)
        Me.txt_sale_code.Name = "txt_sale_code"
        Me.txt_sale_code.Size = New System.Drawing.Size(244, 20)
        Me.txt_sale_code.TabIndex = 34
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(272, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(87, 19)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "رقم حركة البيع"
        '
        'dtp_sale_date
        '
        Me.dtp_sale_date.Location = New System.Drawing.Point(13, 226)
        Me.dtp_sale_date.Name = "dtp_sale_date"
        Me.dtp_sale_date.Size = New System.Drawing.Size(243, 20)
        Me.dtp_sale_date.TabIndex = 32
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(262, 229)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(97, 19)
        Me.Label18.TabIndex = 31
        Me.Label18.Text = "تاريخ حركة البيع"
        '
        'txt_total
        '
        Me.txt_total.Enabled = False
        Me.txt_total.Location = New System.Drawing.Point(81, 155)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(142, 20)
        Me.txt_total.TabIndex = 24
        Me.txt_total.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(300, 122)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(68, 19)
        Me.Label19.TabIndex = 19
        Me.Label19.Text = "سعر الكتاب"
        '
        'txt_book_price
        '
        Me.txt_book_price.Location = New System.Drawing.Point(198, 121)
        Me.txt_book_price.Name = "txt_book_price"
        Me.txt_book_price.Size = New System.Drawing.Size(96, 20)
        Me.txt_book_price.TabIndex = 17
        Me.txt_book_price.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(237, 156)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(74, 19)
        Me.Label20.TabIndex = 13
        Me.Label20.Text = "الإجمـــــــالى"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(282, 47)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(65, 19)
        Me.Label21.TabIndex = 11
        Me.Label21.Text = "إسم الكتاب"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'store_sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(746, 330)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "store_sales"
        Me.Text = "store_sales"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_update As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_sale_code_search As System.Windows.Forms.TextBox
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_rem As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_payed As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_quan As System.Windows.Forms.TextBox
    Friend WithEvents cmb_cust_name As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_book_name As System.Windows.Forms.ComboBox
    Friend WithEvents txt_sale_code As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents dtp_sale_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_book_price As System.Windows.Forms.TextBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
