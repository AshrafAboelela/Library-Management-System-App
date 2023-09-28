Public Class order_books_date

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Dispose()
    End Sub

    Private Sub btn_order_Click(sender As Object, e As EventArgs) Handles btn_order.Click
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from books_add where reg_date between '" + dtp_from_date.Text + "%' and '" + dtp_to_date.Text + "%'"
        reader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            DataGridView1.Rows.Add(reader(1), reader(2), reader(3), reader(4), reader(5), reader(6))
        End While
        con.Close()
        reader.Close()
    End Sub

    Private Sub order_books_date_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from books_add"
        reader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            DataGridView1.Rows.Add(reader(1), reader(2), reader(3), reader(4), reader(5), reader(6))
        End While
        con.Close()
        reader.Close()

    End Sub
End Class