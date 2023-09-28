Public Class lost_books

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        Me.Dispose()

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        Try
            retreving.retrive.connection()
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "select * from forigen_metaphor where recieved_date between '" + dtp_search_date_from.Text + "' and '" + dtp_search_date_to.Text + "'"
            reader = cmd.ExecuteReader()
            DataGridView1.Rows.Clear()
            While reader.Read()
                DataGridView1.Rows.Add(reader(1), reader(2), reader(5), reader(3), reader(4), reader(6), reader(7), reader(8), reader(9))
            End While
            con.Close()
            reader.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class