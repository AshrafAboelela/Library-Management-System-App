<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class customers_report
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
        Me.CrystalReportViewer1 = New CrystalDecisions.Windows.Forms.CrystalReportViewer()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_all_cust_print = New System.Windows.Forms.Button()
        Me.btn_cust_print = New System.Windows.Forms.Button()
        Me.cmb_cust_search = New System.Windows.Forms.ComboBox()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'CrystalReportViewer1
        '
        Me.CrystalReportViewer1.ActiveViewIndex = -1
        Me.CrystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.CrystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default
        Me.CrystalReportViewer1.Location = New System.Drawing.Point(6, 107)
        Me.CrystalReportViewer1.Name = "CrystalReportViewer1"
        Me.CrystalReportViewer1.Size = New System.Drawing.Size(1032, 364)
        Me.CrystalReportViewer1.TabIndex = 48
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_back)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.btn_all_cust_print)
        Me.GroupBox2.Controls.Add(Me.btn_cust_print)
        Me.GroupBox2.Controls.Add(Me.cmb_cust_search)
        Me.GroupBox2.Location = New System.Drawing.Point(108, 7)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(819, 94)
        Me.GroupBox2.TabIndex = 47
        Me.GroupBox2.TabStop = False
        '
        'btn_back
        '
        Me.btn_back.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_back.Location = New System.Drawing.Point(24, 44)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(75, 35)
        Me.btn_back.TabIndex = 38
        Me.btn_back.Text = "رجوع"
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(713, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 19)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "حدد اسم العميل"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(341, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(137, 19)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "البحث عن بيانات العملاء"
        '
        'btn_all_cust_print
        '
        Me.btn_all_cust_print.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_all_cust_print.Location = New System.Drawing.Point(126, 49)
        Me.btn_all_cust_print.Name = "btn_all_cust_print"
        Me.btn_all_cust_print.Size = New System.Drawing.Size(173, 25)
        Me.btn_all_cust_print.TabIndex = 36
        Me.btn_all_cust_print.Text = "طباعة بيانات جميع العملاء"
        Me.btn_all_cust_print.UseVisualStyleBackColor = True
        '
        'btn_cust_print
        '
        Me.btn_cust_print.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cust_print.Location = New System.Drawing.Point(315, 50)
        Me.btn_cust_print.Name = "btn_cust_print"
        Me.btn_cust_print.Size = New System.Drawing.Size(100, 25)
        Me.btn_cust_print.TabIndex = 35
        Me.btn_cust_print.Text = "طباعة عميل"
        Me.btn_cust_print.UseVisualStyleBackColor = True
        '
        'cmb_cust_search
        '
        Me.cmb_cust_search.FormattingEnabled = True
        Me.cmb_cust_search.Location = New System.Drawing.Point(427, 53)
        Me.cmb_cust_search.Name = "cmb_cust_search"
        Me.cmb_cust_search.Size = New System.Drawing.Size(276, 21)
        Me.cmb_cust_search.TabIndex = 34
        '
        'customers_report
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1050, 478)
        Me.Controls.Add(Me.CrystalReportViewer1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "customers_report"
        Me.Text = "customers_report"
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CrystalReportViewer1 As CrystalDecisions.Windows.Forms.CrystalReportViewer
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_all_cust_print As System.Windows.Forms.Button
    Friend WithEvents btn_cust_print As System.Windows.Forms.Button
    Friend WithEvents cmb_cust_search As System.Windows.Forms.ComboBox
End Class
