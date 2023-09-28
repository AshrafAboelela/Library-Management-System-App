Public Class full_books_add
    Public bool As Boolean = False
    Public Sub clear_txt()
        txt_book_code.Text = ""
        txt_auther_name.Text = ""
        txt_full_book.Text = ""
        txt_isbn.Text = ""
    End Sub
    Public Sub bind_combo()
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
        If txt_auther_name.Text = "" Then
            ErrorProvider1.SetError(txt_auther_name, 1)
            txt_auther_name.BackColor = Color.Red
            txt_auther_name.Select()
            Exit Sub
        End If
        If txt_isbn.Text = "" Then
            ErrorProvider1.SetError(txt_auther_name, 1)
            txt_auther_name.BackColor = Color.Red
            txt_auther_name.Select()
            Exit Sub
        End If
        If txt_full_book.Text = "" Then
            ErrorProvider1.SetError(txt_full_book, 1)
            txt_full_book.BackColor = Color.Red
            txt_full_book.Select()
            Exit Sub
        End If
        retreving.retrive.save("insert into full_book_add (code,book_name,isbn,auth_name,reg_date,full_book) values ('" + txt_book_code.Text + "','" + cmb_book_name.Text + "','" + txt_isbn.Text + "','" + txt_auther_name.Text + "','" + dtp_reg_date.Text + "','" + txt_full_book.Text + "')")
        bind_combo()
        clear_txt()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        Me.Dispose()

    End Sub

    Private Sub btn_book_color_Click(sender As Object, e As EventArgs) Handles btn_book_color.Click

        ColorDialog1.ShowDialog()
        txt_full_book.BackColor = ColorDialog1.Color

    End Sub

    Private Sub btn_line_color_Click(sender As Object, e As EventArgs) Handles btn_line_color.Click

        ColorDialog1.ShowDialog()
        txt_full_book.ForeColor = ColorDialog1.Color

    End Sub

    Private Sub btn_line_Click(sender As Object, e As EventArgs) Handles btn_line.Click

        FontDialog1.ShowDialog()
        txt_full_book.Font = New Font(FontDialog1.Font.FontFamily, FontDialog1.Font.Size, FontDialog1.Font.Style)

    End Sub

    Private Sub btn_left_Click(sender As Object, e As EventArgs) Handles btn_left.Click

        txt_full_book.TextAlign = HorizontalAlignment.Left

    End Sub

    Private Sub btn_middle_Click(sender As Object, e As EventArgs) Handles btn_middle.Click

        txt_full_book.TextAlign = HorizontalAlignment.Center

    End Sub

    Private Sub btn_right_Click(sender As Object, e As EventArgs) Handles btn_right.Click

        txt_full_book.TextAlign = HorizontalAlignment.Right

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

    Private Sub full_books_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bind_combo()

    End Sub

End Class