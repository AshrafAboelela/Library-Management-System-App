Public Class forigen_metaphor
    Public bool As Boolean = False
    Public Sub clear_txt()
        txt_metaphor_id.Text = ""
        txt_metaphor_name.Text = ""
        txt_process_num.Text = ""
        txt_book_1.Text = ""
        txt_book_2.Text = ""
        txt_book_3.Text = ""
        txt_book_4.Text = ""
    End Sub
    Public Sub bind_list()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from books_add"
        reader = cmd.ExecuteReader()
        ListView1.Items.Clear()
        While reader.Read()
            ListView1.Items.Add(reader(2).ToString)
        End While
        con.Close()
        reader.Close()
    End Sub
    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_metaphor_id.Text = "" Then
            ErrorProvider1.SetError(txt_metaphor_id, 1)
            txt_metaphor_id.BackColor = Color.Red
            txt_metaphor_id.Select()
            Exit Sub
        End If
        If txt_metaphor_name.Text = "" Then
            ErrorProvider1.SetError(txt_metaphor_name, 1)
            txt_metaphor_name.BackColor = Color.Red
            txt_metaphor_name.Select()
            Exit Sub
        End If
        If txt_process_num.Text = "" Then
            ErrorProvider1.SetError(txt_process_num, 1)
            txt_process_num.BackColor = Color.Red
            txt_process_num.Select()
            Exit Sub
        End If
        If txt_book_1.Text = "" Then
            ErrorProvider1.SetError(txt_book_1, 1)
            txt_book_1.BackColor = Color.Red
            txt_book_1.Select()
            Exit Sub
        End If
        retreving.retrive.save("insert into forigen_metaphor (process_num,metaphor_name,metaphor_id,metaphor_date,recieved_date,name1,name2,name3,name4) values ('" + txt_process_num.Text + "','" + txt_metaphor_name.Text + "','" + txt_metaphor_id.Text + "','" + dtp_metaphor_date.Text + "','" + dtp_recieved_date.Text + "','" + txt_book_1.Text + "','" + txt_book_2.Text + "','" + txt_book_3.Text + "','" + txt_book_4.Text + "')")
        bind_list()
        clear_txt()
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        clear_txt()
        bool = True

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        Me.Dispose()

    End Sub

    Private Sub forigen_metaphor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bind_list()

    End Sub
End Class