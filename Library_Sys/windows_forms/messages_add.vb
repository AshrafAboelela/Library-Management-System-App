Public Class messages_add
    Public Sub clear_txt()
        txt_msg_code.Text = ""
        txt_msg_name.Text = ""
        txt_researcher_name.Text = ""
    End Sub
    Public Sub bind_combo_search()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from messages_add"
        reader = cmd.ExecuteReader()
        cmb_msg_search.Items.Clear()
        While reader.Read()
            cmb_msg_search.Items.Add(reader(2).ToString)
        End While
        con.Close()
        reader.Close()
    End Sub
    Public Sub bind_grid()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from messages_add"
        reader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            DataGridView1.Rows.Add(reader(1), reader(2), reader(3), reader(4))
        End While
        con.Close()
        reader.Close()
    End Sub

    Public bool As Boolean = False

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_msg_code.Text = "" Then
            ErrorProvider1.SetError(txt_msg_code, 1)
            txt_msg_code.BackColor = Color.Red
            txt_msg_code.Select()
            Exit Sub
        End If
        If txt_msg_name.Text = "" Then
            ErrorProvider1.SetError(txt_msg_name, 1)
            txt_msg_name.BackColor = Color.Red
            txt_msg_name.Select()
            Exit Sub
        End If
        If txt_researcher_name.Text = "" Then
            ErrorProvider1.SetError(txt_researcher_name, 1)
            txt_researcher_name.BackColor = Color.Red
            txt_researcher_name.Select()
            Exit Sub
        End If
        retreving.retrive.save("insert into messages_add (msg_code,msg_name,researcher_name,reg_date) values ('" + txt_msg_code.Text + "','" + txt_msg_name.Text + "','" + txt_researcher_name.Text + "','" + dtp_reg_date.Text + "')")
        clear_txt()
        bind_combo_search()
        bind_grid()
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        clear_txt()
        bool = True

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If txt_msg_code.Text = "" Then
            ErrorProvider1.SetError(txt_msg_code, 1)
            txt_msg_code.BackColor = Color.Red
            txt_msg_code.Select()
            Exit Sub
        End If
        If txt_msg_name.Text = "" Then
            ErrorProvider1.SetError(txt_msg_name, 1)
            txt_msg_name.BackColor = Color.Red
            txt_msg_name.Select()
            Exit Sub
        End If
        If txt_researcher_name.Text = "" Then
            ErrorProvider1.SetError(txt_researcher_name, 1)
            txt_researcher_name.BackColor = Color.Red
            txt_researcher_name.Select()
            Exit Sub
        End If
        retreving.retrive.update("update messages_add set msg_code='" + txt_msg_code.Text + "',msg_name='" + txt_msg_name.Text + "',researcher_name='" + txt_researcher_name.Text + "',reg_date='" + dtp_reg_date.Text + "' where msg_name='" + cmb_msg_search.Text + "'")
        clear_txt()
        bind_combo_search()
        bind_grid()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        retreving.retrive.delete("delete from messages_add where msg_name='" + cmb_msg_search.Text + "'")
        clear_txt()
        bind_combo_search()
        bind_grid()

    End Sub


    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If cmb_msg_search.Text = "" Then
            ErrorProvider1.SetError(cmb_msg_search, 1)
            cmb_msg_search.BackColor = Color.Red
            cmb_msg_search.Select()
            Exit Sub
        End If
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from messages_add where msg_name='" + cmb_msg_search.Text + "'"
        reader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            DataGridView1.Rows.Add(reader(1), reader(2), reader(3), reader(4))
        End While
        con.Close()
        retreving.search_structure.msg_code = Nothing
        retreving.search_structure.msg_message_name = Nothing
        retreving.search_structure.msg_researcher_name = Nothing
        retreving.search_structure.msg_reg_date = Nothing
        retreving.search_structure.messages_add("select * from messages_add where msg_name='" + cmb_msg_search.Text + "'")
        txt_msg_code.Text = retreving.search_structure.msg_code
        txt_msg_name.Text = retreving.search_structure.msg_message_name
        txt_researcher_name.Text = retreving.search_structure.msg_researcher_name
        dtp_reg_date.Text = retreving.search_structure.msg_reg_date
    End Sub


    Private Sub messages_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bind_combo_search()
        bind_grid()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        Me.Dispose()

    End Sub
End Class