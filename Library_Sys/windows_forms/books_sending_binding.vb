Public Class books_sending_binding
    Public Sub clear_txt()
        txt_book_1.Text = ""
        txt_book_2.Text = ""
        txt_book_3.Text = ""
        txt_book_4.Text = ""
        txt_book_5.Text = ""
        txt_book_6.Text = ""
        txt_sending_num.Text = ""
        txt_binding_printing_house.Text = ""
        txt_notes.Text = ""
    End Sub

    Public bool As Boolean = False

    Public Sub bind_lst()
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
        If bool = False Then
            MsgBox("برجاء الضغط على جديد")
            Exit Sub
        End If
        If txt_sending_num.Text = "" Then
            ErrorProvider1.SetError(txt_sending_num, 1)
            txt_sending_num.BackColor = Color.Red
            txt_sending_num.Select()
            Exit Sub
        End If
        If txt_binding_printing_house.Text = "" Then
            ErrorProvider1.SetError(txt_binding_printing_house, 1)
            txt_binding_printing_house.BackColor = Color.Red
            txt_binding_printing_house.Select()
            Exit Sub
        End If
        If txt_notes.Text = "" Then
            ErrorProvider1.SetError(txt_notes, 1)
            txt_notes.BackColor = Color.Red
            txt_notes.Select()
            Exit Sub
        End If
        If txt_book_1.Text = "" Then
            ErrorProvider1.SetError(txt_book_1, 1)
            txt_book_1.BackColor = Color.Red
            txt_book_1.Select()
            Exit Sub
        End If

        retreving.retrive.save("insert into books_sending_binding (sending_num,binding_printing_house,notes,sending_date,recieved_date,name1,name2,name3,name4,name5,name6) values ('" + txt_sending_num.Text + "','" + txt_binding_printing_house.Text + "','" + txt_notes.Text + "','" + dtp_sending_date.Text + "','" + dtp_recieved_date.Text + "','" + txt_book_1.Text + "','" + txt_book_2.Text + "','" + txt_book_3.Text + "','" + txt_book_4.Text + "','" + txt_book_5.Text + "','" + txt_book_6.Text + "')")

        clear_txt()
        bind_lst()
    End Sub


    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If txt_sending_num.Text = "" Then
            ErrorProvider1.SetError(txt_sending_num, 1)
            txt_sending_num.BackColor = Color.Red
            txt_sending_num.Select()
            Exit Sub
        End If
        If txt_book_1.Text = "" Then
            ErrorProvider1.SetError(txt_book_1, 1)
            txt_book_1.BackColor = Color.Red
            txt_book_1.Select()
            Exit Sub
        End If

        retreving.retrive.update("update books_sending_binding set sending_num='" + txt_sending_num.Text + "',binding_printing_house='" + txt_binding_printing_house.Text + "',notes='" + txt_notes.Text + "',sending_date='" + dtp_sending_date.Text + "',recieved_date='" + dtp_recieved_date.Text + "',name1='" + txt_book_1.Text + "',name2='" + txt_book_2.Text + "',name3='" + txt_book_3.Text + "',name4='" + txt_book_4.Text + "',name5='" + txt_book_5.Text + "',name6='" + txt_book_6.Text + "' where sending_date='" + dtp_sending_search.Text + "'")
        clear_txt()
        bind_lst()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        retreving.retrive.delete("delete from books_sending_binding where sending_date='" + dtp_sending_search.Text + "'")
        clear_txt()
        bind_lst()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        Me.Dispose()

    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        clear_txt()
        bool = True

    End Sub

    Private Sub books_sending_binding_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bind_lst()

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from books_sending_binding where sending_date='" + dtp_sending_search.Text + "'"
        reader = cmd.ExecuteReader()
        reader.Read()
        If reader.HasRows Then
            txt_sending_num.Text = reader(1).ToString()
            txt_binding_printing_house.Text = reader(2).ToString()
            dtp_sending_date.Text = reader(3).ToString()
            dtp_recieved_date.Text = reader(4).ToString()
            txt_notes.Text = reader(5).ToString()
            txt_book_1.Text = reader(6).ToString()
            txt_book_2.Text = reader(7).ToString()
            txt_book_3.Text = reader(8).ToString()
            txt_book_4.Text = reader(9).ToString()
            txt_book_5.Text = reader(10).ToString()
            txt_book_6.Text = reader(11).ToString()
            reader.Close()
            con.Close()
        Else
            reader.Close()
            con.Close()
            notfound.Show()
        End If
    End Sub

End Class