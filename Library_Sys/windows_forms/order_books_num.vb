Public Class order_books_num

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        Me.Dispose()

    End Sub

    Private Sub chk_asc_CheckedChanged(sender As Object, e As EventArgs) Handles chk_asc.CheckedChanged

        If chk_asc.Checked = True Then
            chk_desc.Checked = False
            retreving.retrive.connection()
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "select * from books_add order by [code] asc"
            reader = cmd.ExecuteReader()
            DataGridView1.Rows.Clear()
            While reader.Read()
                DataGridView1.Rows.Add(reader(1), reader(2), reader(3), reader(4), reader(5), reader(6))
            End While
            con.Close()
            reader.Close()
        End If

    End Sub

    Private Sub chk_desc_CheckedChanged(sender As Object, e As EventArgs) Handles chk_desc.CheckedChanged

        If chk_desc.Checked = True Then
            chk_asc.Checked = False
            retreving.retrive.connection()
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "select * from books_add order by [code] desc"
            reader = cmd.ExecuteReader()
            DataGridView1.Rows.Clear()
            While reader.Read()
                DataGridView1.Rows.Add(reader(1), reader(2), reader(3), reader(4), reader(5), reader(6))
            End While
            con.Close()
            reader.Close()
        End If

    End Sub

    Private Sub order_books_num_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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