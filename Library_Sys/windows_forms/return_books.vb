Public Class return_books
    Public Sub clear_txt()

        txt_process_num.Text = ""
        txt_metaphor_name.Text = ""
        txt_metaphor_id.Text = ""

    End Sub
    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Try
            retreving.retrive.connection()
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "select * from internal_metaphor where process_num='" + txt_process_num_search.Text + "'"
            reader = cmd.ExecuteReader()
            reader.Read()
            If reader.HasRows Then
                txt_process_num.Text = reader(1).ToString()
                txt_metaphor_name.Text = reader(2).ToString()
                txt_metaphor_id.Text = reader(3).ToString()
                dtp_date_metaphor.Text = reader(4).ToString()
                reader.Close()
                con.Close()
            End If
            retreving.retrive.connection()
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "select * from internal_metaphor where process_num='" + txt_process_num_search.Text + "'"
            reader = cmd.ExecuteReader()
            ListView1.Items.Clear()
            While reader.Read()
                ListView1.Items.Add(reader(5).ToString)
                ListView1.Items.Add(reader(6).ToString)
                ListView1.Items.Add(reader(7).ToString)
                ListView1.Items.Add(reader(8).ToString)
            End While
            con.Close()
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        Me.Dispose()

    End Sub

    Private Sub btn_return_Click(sender As Object, e As EventArgs) Handles btn_return.Click

        Try
            retreving.retrive.connection()
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "delete from internal_metaphor where process_num='" + txt_process_num_search.Text + "'"
            cmd.ExecuteNonQuery()
            con.Close()
            MsgBox("تم اعادة الكتب المستعارة للداخل الى المكتبة")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        clear_txt()
        ListView1.Items.Clear()
    End Sub
End Class