<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class return_metaphor_books
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
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_return = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_process_num_search = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_metaphor_name = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dtp_date_metaphor = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtp_recieved_date = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_metaphor_id = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_process_num = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(203, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(198, 19)
        Me.Label1.TabIndex = 133
        Me.Label1.Text = "شاشة اعادة الكتب المستعارة للخارج"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(388, 60)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 19)
        Me.Label6.TabIndex = 155
        Me.Label6.Text = "الكتب المستعارة للخارج"
        '
        'btn_return
        '
        Me.btn_return.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_return.Location = New System.Drawing.Point(254, 372)
        Me.btn_return.Name = "btn_return"
        Me.btn_return.Size = New System.Drawing.Size(261, 35)
        Me.btn_return.TabIndex = 150
        Me.btn_return.Text = "اعادة الكتب المستعارة للخارج الى المكتبة"
        Me.btn_return.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_process_num_search)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.btn_search)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 40)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(325, 115)
        Me.GroupBox2.TabIndex = 152
        Me.GroupBox2.TabStop = False
        '
        'txt_process_num_search
        '
        Me.txt_process_num_search.Location = New System.Drawing.Point(23, 47)
        Me.txt_process_num_search.Name = "txt_process_num_search"
        Me.txt_process_num_search.Size = New System.Drawing.Size(216, 20)
        Me.txt_process_num_search.TabIndex = 111
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(242, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 19)
        Me.Label3.TabIndex = 110
        Me.Label3.Text = "رقم العملية"
        '
        'btn_search
        '
        Me.btn_search.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.Location = New System.Drawing.Point(13, 81)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(75, 24)
        Me.btn_search.TabIndex = 109
        Me.btn_search.Text = "بحث"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(43, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(233, 19)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "بحث عن الكتب المستعارة للخارج خلال فترة"
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(12, 372)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 35)
        Me.btn_back.TabIndex = 154
        Me.btn_back.Text = "رجوع"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'ListView1
        '
        Me.ListView1.Location = New System.Drawing.Point(349, 95)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(186, 260)
        Me.ListView1.TabIndex = 153
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.List
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_metaphor_id)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.txt_process_num)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.txt_metaphor_name)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.dtp_date_metaphor)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.dtp_recieved_date)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 161)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(326, 194)
        Me.GroupBox1.TabIndex = 151
        Me.GroupBox1.TabStop = False
        '
        'txt_metaphor_name
        '
        Me.txt_metaphor_name.Enabled = False
        Me.txt_metaphor_name.Location = New System.Drawing.Point(10, 57)
        Me.txt_metaphor_name.Name = "txt_metaphor_name"
        Me.txt_metaphor_name.Size = New System.Drawing.Size(216, 20)
        Me.txt_metaphor_name.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(239, 57)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(79, 19)
        Me.Label5.TabIndex = 33
        Me.Label5.Text = "اسم المستعير"
        '
        'dtp_date_metaphor
        '
        Me.dtp_date_metaphor.Enabled = False
        Me.dtp_date_metaphor.Location = New System.Drawing.Point(12, 128)
        Me.dtp_date_metaphor.Name = "dtp_date_metaphor"
        Me.dtp_date_metaphor.Size = New System.Drawing.Size(215, 20)
        Me.dtp_date_metaphor.TabIndex = 32
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(233, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(89, 19)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "تاريخ الاستعارة"
        '
        'dtp_recieved_date
        '
        Me.dtp_recieved_date.Enabled = False
        Me.dtp_recieved_date.Location = New System.Drawing.Point(10, 163)
        Me.dtp_recieved_date.Name = "dtp_recieved_date"
        Me.dtp_recieved_date.Size = New System.Drawing.Size(215, 20)
        Me.dtp_recieved_date.TabIndex = 30
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(236, 163)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 19)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "تاريخ التسليم"
        '
        'txt_metaphor_id
        '
        Me.txt_metaphor_id.Enabled = False
        Me.txt_metaphor_id.Location = New System.Drawing.Point(12, 92)
        Me.txt_metaphor_id.Name = "txt_metaphor_id"
        Me.txt_metaphor_id.Size = New System.Drawing.Size(216, 20)
        Me.txt_metaphor_id.TabIndex = 42
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(243, 91)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 19)
        Me.Label7.TabIndex = 41
        Me.Label7.Text = "الرقم القومى"
        '
        'txt_process_num
        '
        Me.txt_process_num.Enabled = False
        Me.txt_process_num.Location = New System.Drawing.Point(9, 24)
        Me.txt_process_num.Name = "txt_process_num"
        Me.txt_process_num.Size = New System.Drawing.Size(216, 20)
        Me.txt_process_num.TabIndex = 40
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(241, 23)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 19)
        Me.Label10.TabIndex = 39
        Me.Label10.Text = "رقم العملية"
        '
        'return_metaphor_books
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 414)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btn_return)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.ListView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "return_metaphor_books"
        Me.Text = "return_metaphor_books"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_return As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_process_num_search As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents ListView1 As System.Windows.Forms.ListView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_metaphor_name As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents dtp_date_metaphor As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtp_recieved_date As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_metaphor_id As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_process_num As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
End Class
