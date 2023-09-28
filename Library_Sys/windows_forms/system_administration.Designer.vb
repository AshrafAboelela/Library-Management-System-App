<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class system_administration
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_emp_search = New System.Windows.Forms.ComboBox()
        Me.chk_emp = New System.Windows.Forms.CheckBox()
        Me.chk_lib = New System.Windows.Forms.CheckBox()
        Me.chk_inventory = New System.Windows.Forms.CheckBox()
        Me.chk_add_book = New System.Windows.Forms.CheckBox()
        Me.chk_academic_booking = New System.Windows.Forms.CheckBox()
        Me.chk_archiving = New System.Windows.Forms.CheckBox()
        Me.chk_metaphor = New System.Windows.Forms.CheckBox()
        Me.chk_store = New System.Windows.Forms.CheckBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.btn_new = New System.Windows.Forms.Button()
        Me.btn_search = New System.Windows.Forms.Button()
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_emp_name = New System.Windows.Forms.TextBox()
        Me.txt_job = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_mob = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.chk_reports = New System.Windows.Forms.CheckBox()
        Me.chk_sys_admin = New System.Windows.Forms.CheckBox()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(357, 57)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 19)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "إسم الموظف"
        '
        'cmb_emp_search
        '
        Me.cmb_emp_search.FormattingEnabled = True
        Me.cmb_emp_search.Location = New System.Drawing.Point(95, 55)
        Me.cmb_emp_search.Name = "cmb_emp_search"
        Me.cmb_emp_search.Size = New System.Drawing.Size(256, 21)
        Me.cmb_emp_search.TabIndex = 35
        '
        'chk_emp
        '
        Me.chk_emp.AutoSize = True
        Me.chk_emp.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_emp.Location = New System.Drawing.Point(276, 195)
        Me.chk_emp.Name = "chk_emp"
        Me.chk_emp.Size = New System.Drawing.Size(110, 23)
        Me.chk_emp.TabIndex = 42
        Me.chk_emp.Text = "شئون الموظفين"
        Me.chk_emp.UseVisualStyleBackColor = True
        '
        'chk_lib
        '
        Me.chk_lib.AutoSize = True
        Me.chk_lib.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_lib.Location = New System.Drawing.Point(276, 224)
        Me.chk_lib.Name = "chk_lib"
        Me.chk_lib.Size = New System.Drawing.Size(103, 23)
        Me.chk_lib.TabIndex = 44
        Me.chk_lib.Text = "فروع المكتبات"
        Me.chk_lib.UseVisualStyleBackColor = True
        '
        'chk_inventory
        '
        Me.chk_inventory.AutoSize = True
        Me.chk_inventory.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_inventory.Location = New System.Drawing.Point(276, 254)
        Me.chk_inventory.Name = "chk_inventory"
        Me.chk_inventory.Size = New System.Drawing.Size(56, 23)
        Me.chk_inventory.TabIndex = 45
        Me.chk_inventory.Text = "الجرد"
        Me.chk_inventory.UseVisualStyleBackColor = True
        '
        'chk_add_book
        '
        Me.chk_add_book.AutoSize = True
        Me.chk_add_book.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_add_book.Location = New System.Drawing.Point(276, 281)
        Me.chk_add_book.Name = "chk_add_book"
        Me.chk_add_book.Size = New System.Drawing.Size(92, 23)
        Me.chk_add_book.TabIndex = 46
        Me.chk_add_book.Text = "اضافة الكتب"
        Me.chk_add_book.UseVisualStyleBackColor = True
        '
        'chk_academic_booking
        '
        Me.chk_academic_booking.AutoSize = True
        Me.chk_academic_booking.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_academic_booking.Location = New System.Drawing.Point(95, 277)
        Me.chk_academic_booking.Name = "chk_academic_booking"
        Me.chk_academic_booking.Size = New System.Drawing.Size(110, 23)
        Me.chk_academic_booking.TabIndex = 50
        Me.chk_academic_booking.Text = "الحجز الاكاديمى"
        Me.chk_academic_booking.UseVisualStyleBackColor = True
        '
        'chk_archiving
        '
        Me.chk_archiving.AutoSize = True
        Me.chk_archiving.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_archiving.Location = New System.Drawing.Point(95, 250)
        Me.chk_archiving.Name = "chk_archiving"
        Me.chk_archiving.Size = New System.Drawing.Size(73, 23)
        Me.chk_archiving.TabIndex = 49
        Me.chk_archiving.Text = "الارشيف"
        Me.chk_archiving.UseVisualStyleBackColor = True
        '
        'chk_metaphor
        '
        Me.chk_metaphor.AutoSize = True
        Me.chk_metaphor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_metaphor.Location = New System.Drawing.Point(95, 224)
        Me.chk_metaphor.Name = "chk_metaphor"
        Me.chk_metaphor.Size = New System.Drawing.Size(76, 23)
        Me.chk_metaphor.TabIndex = 48
        Me.chk_metaphor.Text = "الاستعارة"
        Me.chk_metaphor.UseVisualStyleBackColor = True
        '
        'chk_store
        '
        Me.chk_store.AutoSize = True
        Me.chk_store.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_store.Location = New System.Drawing.Point(95, 197)
        Me.chk_store.Name = "chk_store"
        Me.chk_store.Size = New System.Drawing.Size(71, 23)
        Me.chk_store.TabIndex = 47
        Me.chk_store.Text = "المخازن"
        Me.chk_store.UseVisualStyleBackColor = True
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(17, 343)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 35)
        Me.btn_back.TabIndex = 55
        Me.btn_back.Text = "رجوع"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_save
        '
        Me.btn_save.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_save.Location = New System.Drawing.Point(169, 343)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(75, 35)
        Me.btn_save.TabIndex = 51
        Me.btn_save.Text = "حفظ"
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'btn_new
        '
        Me.btn_new.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_new.Location = New System.Drawing.Point(348, 343)
        Me.btn_new.Name = "btn_new"
        Me.btn_new.Size = New System.Drawing.Size(75, 35)
        Me.btn_new.TabIndex = 52
        Me.btn_new.Text = "جديد"
        Me.btn_new.UseVisualStyleBackColor = True
        '
        'btn_search
        '
        Me.btn_search.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_search.Location = New System.Drawing.Point(17, 54)
        Me.btn_search.Name = "btn_search"
        Me.btn_search.Size = New System.Drawing.Size(54, 25)
        Me.btn_search.TabIndex = 56
        Me.btn_search.Text = "بحث"
        Me.btn_search.UseVisualStyleBackColor = True
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(362, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(75, 19)
        Me.Label1.TabIndex = 36
        Me.Label1.Text = "إسم الموظف"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(375, 132)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(48, 19)
        Me.Label8.TabIndex = 37
        Me.Label8.Text = "الوظيفة"
        '
        'txt_emp_name
        '
        Me.txt_emp_name.Enabled = False
        Me.txt_emp_name.Location = New System.Drawing.Point(95, 99)
        Me.txt_emp_name.Name = "txt_emp_name"
        Me.txt_emp_name.Size = New System.Drawing.Size(258, 20)
        Me.txt_emp_name.TabIndex = 38
        '
        'txt_job
        '
        Me.txt_job.Enabled = False
        Me.txt_job.Location = New System.Drawing.Point(95, 131)
        Me.txt_job.Name = "txt_job"
        Me.txt_job.Size = New System.Drawing.Size(258, 20)
        Me.txt_job.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(373, 160)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 19)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "الموبايل"
        '
        'txt_mob
        '
        Me.txt_mob.Enabled = False
        Me.txt_mob.Location = New System.Drawing.Point(96, 159)
        Me.txt_mob.Name = "txt_mob"
        Me.txt_mob.Size = New System.Drawing.Size(258, 20)
        Me.txt_mob.TabIndex = 41
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(134, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(173, 19)
        Me.Label2.TabIndex = 57
        Me.Label2.Text = "شاشة تحديد صلاحيات الموظفين"
        '
        'chk_reports
        '
        Me.chk_reports.AutoSize = True
        Me.chk_reports.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_reports.Location = New System.Drawing.Point(95, 306)
        Me.chk_reports.Name = "chk_reports"
        Me.chk_reports.Size = New System.Drawing.Size(67, 23)
        Me.chk_reports.TabIndex = 59
        Me.chk_reports.Text = "التقارير"
        Me.chk_reports.UseVisualStyleBackColor = True
        '
        'chk_sys_admin
        '
        Me.chk_sys_admin.AutoSize = True
        Me.chk_sys_admin.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chk_sys_admin.Location = New System.Drawing.Point(276, 310)
        Me.chk_sys_admin.Name = "chk_sys_admin"
        Me.chk_sys_admin.Size = New System.Drawing.Size(87, 23)
        Me.chk_sys_admin.TabIndex = 58
        Me.chk_sys_admin.Text = "ادارة النظام"
        Me.chk_sys_admin.UseVisualStyleBackColor = True
        '
        'system_administration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(450, 407)
        Me.Controls.Add(Me.chk_reports)
        Me.Controls.Add(Me.chk_sys_admin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_search)
        Me.Controls.Add(Me.btn_back)
        Me.Controls.Add(Me.btn_save)
        Me.Controls.Add(Me.btn_new)
        Me.Controls.Add(Me.chk_academic_booking)
        Me.Controls.Add(Me.chk_archiving)
        Me.Controls.Add(Me.chk_metaphor)
        Me.Controls.Add(Me.chk_store)
        Me.Controls.Add(Me.chk_add_book)
        Me.Controls.Add(Me.chk_inventory)
        Me.Controls.Add(Me.chk_lib)
        Me.Controls.Add(Me.chk_emp)
        Me.Controls.Add(Me.txt_mob)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_job)
        Me.Controls.Add(Me.txt_emp_name)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_emp_search)
        Me.Controls.Add(Me.Label3)
        Me.Name = "system_administration"
        Me.Text = "system_administration"
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cmb_emp_search As System.Windows.Forms.ComboBox
    Friend WithEvents chk_emp As System.Windows.Forms.CheckBox
    Friend WithEvents chk_lib As System.Windows.Forms.CheckBox
    Friend WithEvents chk_inventory As System.Windows.Forms.CheckBox
    Friend WithEvents chk_add_book As System.Windows.Forms.CheckBox
    Friend WithEvents chk_academic_booking As System.Windows.Forms.CheckBox
    Friend WithEvents chk_archiving As System.Windows.Forms.CheckBox
    Friend WithEvents chk_metaphor As System.Windows.Forms.CheckBox
    Friend WithEvents chk_store As System.Windows.Forms.CheckBox
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents btn_save As System.Windows.Forms.Button
    Friend WithEvents btn_new As System.Windows.Forms.Button
    Friend WithEvents btn_search As System.Windows.Forms.Button
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents txt_mob As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_job As System.Windows.Forms.TextBox
    Friend WithEvents txt_emp_name As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents chk_reports As System.Windows.Forms.CheckBox
    Friend WithEvents chk_sys_admin As System.Windows.Forms.CheckBox
End Class
