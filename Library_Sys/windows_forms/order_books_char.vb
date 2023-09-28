Public Class order_books_char

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        Me.Dispose()

    End Sub

    Private Sub chk_1_CheckedChanged(sender As Object, e As EventArgs) Handles chk_1.CheckedChanged

        If chk_1.Checked = True Then
            chk_2.Checked = False
            chk_3.Checked = False

        End If
    End Sub

    Private Sub chk_2_CheckedChanged(sender As Object, e As EventArgs) Handles chk_2.CheckedChanged

        If chk_2.Checked = True Then
            chk_1.Checked = False
            chk_3.Checked = False

        End If
    End Sub

    Private Sub chk_3_CheckedChanged(sender As Object, e As EventArgs) Handles chk_3.CheckedChanged

        If chk_3.Checked = True Then
            chk_1.Checked = False
            chk_2.Checked = False
        End If

    End Sub

    Private Sub order_books_char_Load(sender As Object, e As EventArgs) Handles MyBase.Load

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

    Private Sub txt_char_TextChanged(sender As Object, e As EventArgs) Handles txt_char.TextChanged

        If chk_1.Checked = True Then
            retreving.retrive.connection()
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "select * from books_add where book_name like '" + txt_char.Text + "%'"
            reader = cmd.ExecuteReader()
            DataGridView1.Rows.Clear()
            While reader.Read()
                DataGridView1.Rows.Add(reader(1), reader(2), reader(3), reader(4), reader(5), reader(6))
            End While
            con.Close()
            reader.Close()
        End If

        If chk_2.Checked = True Then
            retreving.retrive.connection()
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "select * from books_add where book_name like '%" + txt_char.Text + "%'"
            reader = cmd.ExecuteReader()
            DataGridView1.Rows.Clear()
            While reader.Read()
                DataGridView1.Rows.Add(reader(1), reader(2), reader(3), reader(4), reader(5), reader(6))
            End While
            con.Close()
            reader.Close()
        End If

        If chk_3.Checked = True Then
            retreving.retrive.connection()
            cmd.Connection = con
            con.Open()
            cmd.CommandText = "select * from books_add where book_name like '%" + txt_char.Text + "'"
            reader = cmd.ExecuteReader()
            DataGridView1.Rows.Clear()
            While reader.Read()
                DataGridView1.Rows.Add(reader(1), reader(2), reader(3), reader(4), reader(5), reader(6))
            End While
            con.Close()
            reader.Close()
        End If
    End Sub
End Class