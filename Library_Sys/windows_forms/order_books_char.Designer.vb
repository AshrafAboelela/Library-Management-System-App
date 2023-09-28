<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class order_books_char
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
        Me.txt_char = New System.Windows.Forms.TextBox()
        Me.chk_3 = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.chk_2 = New System.Windows.Forms.CheckBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.chk_1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_char
        '
        Me.txt_char.Location = New System.Drawing.Point(88, 45)
        Me.txt_char.Name = "txt_char"
        Me.txt_char.Size = New System.Drawing.Size(177, 20)
        Me.txt_char.TabIndex = 149
        '
        'chk_3
        '
        Me.chk_3.AutoSize = True
        Me.chk_3.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.chk_3.Location = New System.Drawing.Point(349, 45)
        Me.chk_3.Name = "chk_3"
        Me.chk_3.Size = New System.Drawing.Size(128, 23)
        Me.chk_3.TabIndex = 148
        Me.chk_3.Text = "حرف فى اخر الكلمة"
        Me.chk_3.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(287, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 19)
        Me.Label1.TabIndex = 147
        Me.Label1.Text = "شاشة ترتيب الكتب بالحروف"
        '
        'chk_2
        '
        Me.chk_2.AutoSize = True
        Me.chk_2.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.chk_2.Location = New System.Drawing.Point(483, 48)
        Me.chk_2.Name = "chk_2"
        Me.chk_2.Size = New System.Drawing.Size(150, 23)
        Me.chk_2.TabIndex = 146
        Me.chk_2.Text = "حرف فى منتصف الكلمة"
        Me.chk_2.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(16, 43)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(55, 30)
        Me.btn_back.TabIndex = 144
        Me.btn_back.Text = "رجوع"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'chk_1
        '
        Me.chk_1.AutoSize = True
        Me.chk_1.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.chk_1.Location = New System.Drawing.Point(639, 48)
        Me.chk_1.Name = "chk_1"
        Me.chk_1.Size = New System.Drawing.Size(110, 23)
        Me.chk_1.TabIndex = 143
        Me.chk_1.Text = "حرف اول الكلمة"
        Me.chk_1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(271, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 21)
        Me.Label2.TabIndex = 150
        Me.Label2.Text = "الحروف"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2, Me.Column3, Me.Column4, Me.Column8, Me.Column5, Me.Column6})
        Me.DataGridView1.Location = New System.Drawing.Point(12, 81)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(729, 256)
        Me.DataGridView1.TabIndex = 151
        '
        'Column2
        '
        Me.Column2.HeaderText = "كود الكتاب"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "اسم الكتاب"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "اسم المؤلف"
        Me.Column4.Name = "Column4"
        '
        'Column8
        '
        Me.Column8.HeaderText = "الرقم العام"
        Me.Column8.Name = "Column8"
        '
        'Column5
        '
        Me.Column5.HeaderText = "تاريخ النشر"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "تاريخ التسجيل"
        Me.Column6.Name = "Column6"
        '
        'order_books_char
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(753, 345)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_char)
        Me.Controls.Add(Me.chk_3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.chk_2)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.chk_1)
        Me.Name = "order_books_char"
        Me.Text = "order_books_char"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_char As System.Windows.Forms.TextBox
    Friend WithEvents chk_3 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents chk_2 As System.Windows.Forms.CheckBox
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents chk_1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
