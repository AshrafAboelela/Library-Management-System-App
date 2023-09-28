Public Class bookscopy_add
    Public Sub clear_txt()
        txt_book_code.Text = ""
        txt_copy.Text = ""
        txt_auther_name.Text = ""
        txt_isbn.Text = ""
        txt_book_num.Text = ""
    End Sub
    Public Sub bind_combo_search()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from books_copy_add"
        reader = cmd.ExecuteReader()
        cmb_book_search.Items.Clear()
        While reader.Read()
            cmb_book_search.Items.Add(reader(3).ToString)
        End While
        con.Close()
        reader.Close()
    End Sub

    Public bool As Boolean = False

    Public Sub bind_combo_name()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from books_add"
        reader = cmd.ExecuteReader()
        cmb_book_name.Items.Clear()
        While reader.Read()
            cmb_book_name.Items.Add(reader(2).ToString)
        End While
        con.Close()
        reader.Close()
    End Sub
    Public Sub bind_grid()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from books_copy_add"
        reader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            DataGridView1.Rows.Add(reader(1), reader(2), reader(3), reader(4),
                                   reader(5), reader(6), reader(7))
        End While
        con.Close()
        reader.Close()
    End Sub


    Private Sub bookscopy_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bind_grid()
        bind_combo_search()
        bind_combo_name()

    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        clear_txt()
        bool = True

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_book_code.Text = "" Then
            ErrorProvider1.SetError(txt_book_code, 1)
            txt_book_code.BackColor = Color.Red
            txt_book_code.Select()
            Exit Sub
        End If
        If txt_copy.Text = "" Then
            ErrorProvider1.SetError(txt_copy, 1)
            txt_copy.BackColor = Color.Red
            txt_copy.Select()
            Exit Sub
        End If
        If txt_auther_name.Text = "" Then
            ErrorProvider1.SetError(txt_auther_name, 1)
            txt_auther_name.BackColor = Color.Red
            txt_auther_name.Select()
            Exit Sub
        End If
        If txt_isbn.Text = "" Then
            ErrorProvider1.SetError(txt_isbn, 1)
            txt_isbn.BackColor = Color.Red
            txt_isbn.Select()
            Exit Sub
        End If
        retreving.retrive.save("insert into books_copy_add (code,book_name,auther_name,isbn,copy_book,reg_date,book_nums) values ('" + txt_book_code.Text + "','" + cmb_book_name.Text + "','" + txt_auther_name.Text + "','" + txt_isbn.Text + "','" + txt_copy.Text + "','" + dtp_reg_date.Text + "','" + txt_book_num.Text + "')")
        clear_txt()
        bind_combo_search()
        bind_grid()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If txt_book_code.Text = "" Then
            ErrorProvider1.SetError(txt_book_code, 1)
            txt_book_code.BackColor = Color.Red
            txt_book_code.Select()
            Exit Sub
        End If
        If txt_copy.Text = "" Then
            ErrorProvider1.SetError(txt_copy, 1)
            txt_copy.BackColor = Color.Red
            txt_copy.Select()
            Exit Sub
        End If
        If txt_auther_name.Text = "" Then
            ErrorProvider1.SetError(txt_auther_name, 1)
            txt_auther_name.BackColor = Color.Red
            txt_auther_name.Select()
            Exit Sub
        End If
        If txt_isbn.Text = "" Then
            ErrorProvider1.SetError(txt_isbn, 1)
            txt_isbn.BackColor = Color.Red
            txt_isbn.Select()
            Exit Sub
        End If
        retreving.retrive.update("update books_copy_add set code='" + txt_book_code.Text + "',book_name='" + cmb_book_name.Text + "',auther_name='" + txt_auther_name.Text + "',isbn='" + txt_isbn.Text + "',copy_book='" + txt_copy.Text + "',reg_date='" + dtp_reg_date.Text + "',book_nums='" + txt_book_num.Text + "'  where copy_book='" + cmb_book_search.Text + "'")
        clear_txt()
        bind_combo_search()
        bind_grid()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        retreving.retrive.delete("delete from books_copy_add where book_name='" + cmb_book_search.Text + "'")
        clear_txt()
        bind_combo_search()
        bind_grid()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        Me.Dispose()

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If cmb_book_search.Text = "" Then
            ErrorProvider1.SetError(cmb_book_search, 1)
            cmb_book_search.BackColor = Color.Red
            cmb_book_search.Select()
            Exit Sub
        End If
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from books_copy_add where copy_book='" + cmb_book_search.Text + "'"
        reader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            DataGridView1.Rows.Add(reader(1), reader(2), reader(3), reader(4),reader(5), reader(6), reader(7))
        End While
        con.Close()
        retreving.search_structure.bc_code = Nothing
        retreving.search_structure.bc_auth_name = Nothing
        retreving.search_structure.bc_book_copy = Nothing
        retreving.search_structure.bc_book_isbn = Nothing
        retreving.search_structure.bc_book_name = Nothing
        retreving.search_structure.bc_book_num = Nothing
        retreving.search_structure.bc_reg_date = Nothing
        retreving.search_structure.books_copy_add("select * from books_copy_add where copy_book='" + cmb_book_search.Text + "'")
        txt_book_code.Text = retreving.search_structure.bc_code
        cmb_book_name.Text = retreving.search_structure.bc_book_name
        txt_copy.Text = retreving.search_structure.bc_book_copy
        txt_auther_name.Text = retreving.search_structure.bc_auth_name
        txt_isbn.Text = retreving.search_structure.bc_book_isbn
        dtp_reg_date.Text = retreving.search_structure.bc_reg_date
        txt_book_num.Text = retreving.search_structure.bc_book_num
    End Sub

    Private Sub cmb_book_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_book_name.SelectedIndexChanged

        retreving.retrive.connection()
        retreving.search_structure.book_code = Nothing
        retreving.search_structure.book_isbn = Nothing
        retreving.search_structure.auth_name = Nothing
        retreving.search_structure.books_add("select * from books_add where book_name='" + cmb_book_name.Text + "'")
        txt_book_code.Text = retreving.search_structure.book_code
        txt_auther_name.Text = retreving.search_structure.auth_name
        txt_isbn.Text = retreving.search_structure.book_isbn

    End Sub
End Class