Public Class reserve_group_book
    Public bool As Boolean = False
    Public Sub clear_txt()
        txt_doctor_name.Text = ""
        txt_stu_name.Text = ""
        txt_process_num.Text = ""
        txt_book_1.Text = ""
        txt_book_2.Text = ""
        txt_book_3.Text = ""
        txt_book_4.Text = ""
        txt_book_5.Text = ""
        txt_book_6.Text = ""
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
    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        clear_txt()
        bool = True

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_stu_name.Text = "" Then
            ErrorProvider1.SetError(txt_stu_name, 1)
            txt_stu_name.BackColor = Color.Red
            txt_stu_name.Select()
            Exit Sub
        End If
        If txt_doctor_name.Text = "" Then
            ErrorProvider1.SetError(txt_doctor_name, 1)
            txt_doctor_name.BackColor = Color.Red
            txt_doctor_name.Select()
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

        retreving.retrive.save("insert into reserve_group_book (process_num,dr_name,studs_name,reserve_date,book_name_1,book_name_2,book_name_3,book_name_4,book_name_5,book_name_6) values ('" + txt_process_num.Text + "','" + txt_doctor_name.Text + "','" + txt_stu_name.Text + "','" + dtp_reserve_date.Text + "','" + txt_book_1.Text + "','" + txt_book_2.Text + "','" + txt_book_3.Text + "','" + txt_book_4.Text + "','" + txt_book_5.Text + "','" + txt_book_6.Text + "')")

        bind_list()
        clear_txt()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        Me.Dispose()

    End Sub

    Private Sub reserve_group_book_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bind_list()

    End Sub
End Class