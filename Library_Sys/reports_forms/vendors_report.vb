Public Class vendors_report
    Public Sub bind_combo_search()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from vendors"
        reader = cmd.ExecuteReader()
        cmb_ven_search.Items.Clear()
        While reader.Read()
            cmb_ven_search.Items.Add(reader(2).ToString)
        End While
        con.Close()
        reader.Close()
    End Sub
    Private Sub vendors_report_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bind_combo_search()
        Me.Width = Width
        Me.Height = Height
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Dispose()
    End Sub

    Private Sub btn_all_ven_print_Click(sender As Object, e As EventArgs) Handles btn_all_ven_print.Click
        Try
            cn.Open("Provider=SQLOLEDB.1;Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=library_sys;Data Source=DESKTOP-E76UUDF\SQLEXPRESS")
            rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            rs.Open("select * from vendors", cn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            Dim rpt As New vend_report
            rpt.SetDataSource(rs)
            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Refresh()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_ven_print_Click(sender As Object, e As EventArgs) Handles btn_ven_print.Click
        Try
            cn.Open("Provider=SQLOLEDB.1;Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=library_sys;Data Source=DESKTOP-E76UUDF\SQLEXPRESS")
            rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            rs.Open("select * from vendors where ven_name='" + cmb_ven_search.Text + "'", cn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            Dim rpt As New vend_report
            rpt.SetDataSource(rs)
            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Refresh()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
End Class