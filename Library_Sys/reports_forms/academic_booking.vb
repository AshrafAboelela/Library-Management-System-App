Public Class academic_booking

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Dispose()
    End Sub

    Private Sub btn_print_Click(sender As Object, e As EventArgs) Handles btn_print.Click
        Try
            cn.Open("Provider=SQLOLEDB.1;Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=library_sys;Data Source=DESKTOP-E76UUDF\SQLEXPRESS")
            rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
            rs.Open("select * from academic_booking where date_reserver='" + dtp_reserver_search.Text + "'", cn, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            Dim rpt As New academic_booking_report
            rpt.SetDataSource(rs)
            CrystalReportViewer1.ReportSource = rpt
            CrystalReportViewer1.Refresh()
            cn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub academic_booking_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Width = Width
        Me.Height = Height
    End Sub
End Class