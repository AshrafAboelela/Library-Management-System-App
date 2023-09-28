<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class library_branches
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
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.btn_all_lib_print = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_print = New System.Windows.Forms.Button()
        Me.cmb_lib_search = New System.Windows.Forms.ComboBox()
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_back)
        Me.GroupBox2.Controls.Add(Me.btn_all_lib_print)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btn_print)
        Me.GroupBox2.Controls.Add(Me.cmb_lib_search)
        Me.GroupBox2.Location = New System.Drawing.Point(121, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(829, 91)
        Me.GroupBox2.TabIndex = 41
        Me.GroupBox2.TabStop = False
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(15, 37)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 35)
        Me.btn_back.TabIndex = 46
        Me.btn_back.Text = "رجوع"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'btn_all_lib_print
        '
        Me.btn_all_lib_print.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_all_lib_print.Location = New System.Drawing.Point(105, 42)
        Me.btn_all_lib_print.Name = "btn_all_lib_print"
        Me.btn_all_lib_print.Size = New System.Drawing.Size(173, 25)
        Me.btn_all_lib_print.TabIndex = 45
        Me.btn_all_lib_print.Text = "طباعة بيانات جميع المكتبات"
        Me.btn_all_lib_print.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(734, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 19)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "اختر اسم المكتبة"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(380, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(127, 19)
        Me.Label6.TabIndex = 43
        Me.Label6.Text = "البحث عن بيانات مكتبة"
        '
        'btn_print
        '
        Me.btn_print.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_print.Location = New System.Drawing.Point(313, 43)
        Me.btn_print.Name = "btn_print"
        Me.btn_print.Size = New System.Drawing.Size(65, 25)
        Me.btn_print.TabIndex = 35
        Me.btn_print.Text = "طباعة"
        Me.btn_print.UseVisualStyleBackColor = True
        '
        'cmb_lib_search
        '
        Me.cmb_lib_search.FormattingEnabled = True
        Me.cmb_lib_search.Location = New System.Drawing.Point(410, 46)
        Me.cmb_lib_search.Name = "cmb_lib_search"
        Me.cmb_lib_search.Size = New System.Drawing.Size(318, 21)
        Me.cmb_lib_search.TabIndex = 34
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(12, 109)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1035, 382)
        Me.CrystalReportViewer1.TabIndex = 47
        '
        'library_branches
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 493)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "library_branches"
        Me.Text = "library_branches"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_print As System.Windows.Forms.Button
    Friend WithEvents cmb_lib_search As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents btn_all_lib_print As System.Windows.Forms.Button
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
End Class
