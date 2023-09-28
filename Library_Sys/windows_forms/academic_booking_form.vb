Public Class academic_booking_form
    Public Sub clear_txt()
        txt_room_code.Text = ""
        txt_room_name.Text = ""
        txt_cost.Text = ""
        txt_duration.Text = ""
        txt_res.Text = ""
    End Sub
    Public bool As Boolean = False
    Public Sub bind_grid()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from academic_booking"
        reader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            DataGridView1.Rows.Add(reader(1), reader(2), reader(3), reader(4),
                                   reader(5), reader(6))
        End While
        con.Close()
        reader.Close()
    End Sub
    Private Sub academic_booking_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bind_grid()

    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        clear_txt()
        bool = True

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_room_code.Text = "" Then
            ErrorProvider1.SetError(txt_room_code, 1)
            txt_room_code.BackColor = Color.Red
            txt_room_code.Select()
            Exit Sub
        End If
        If txt_room_name.Text = "" Then
            ErrorProvider1.SetError(txt_room_name, 1)
            txt_room_name.BackColor = Color.Red
            txt_room_name.Select()
            Exit Sub
        End If
        If txt_cost.Text = "" Then
            ErrorProvider1.SetError(txt_cost, 1)
            txt_cost.BackColor = Color.Red
            txt_cost.Select()
            Exit Sub
        End If
        If txt_duration.Text = "" Then
            ErrorProvider1.SetError(txt_duration, 1)
            txt_duration.BackColor = Color.Red
            txt_duration.Select()
            Exit Sub
        End If
        If txt_res.Text = "" Then
            ErrorProvider1.SetError(txt_res, 1)
            txt_res.BackColor = Color.Red
            txt_res.Select()
            Exit Sub
        End If

        retreving.retrive.save("insert into academic_booking (code,name,date_reserver,duration,price,reserver) values ('" + txt_room_code.Text + "','" + txt_room_name.Text + "','" + dtp_reserver.Text + "','" + txt_duration.Text + "','" + txt_cost.Text + "','" + txt_res.Text + "')")
        clear_txt()
        bind_grid()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        retreving.retrive.update("update academic_booking set code='" + txt_room_code.Text + "',name='" + txt_room_name.Text + "',date_reserver='" + dtp_reserver.Text + "',duration='" + txt_duration.Text + "',price='" + txt_cost.Text + "',reserver='" + txt_res.Text + "' where date_reserver='" + dtp_reserver_search.Text + "'")
        clear_txt()
        bind_grid()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        retreving.retrive.delete("delete from academic_booking where date_reserver='" + dtp_reserver_search.Text + "'")
        clear_txt()
        bind_grid()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        Me.Dispose()

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from academic_booking where date_reserver='" + dtp_reserver_search.Text + "'"
        reader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            DataGridView1.Rows.Add(reader(1), reader(2), reader(3), reader(4),
                                   reader(5), reader(6))
        End While
        con.Close()

        retreving.search_structure.acd_code = Nothing
        retreving.search_structure.acd_name = Nothing
        retreving.search_structure.acd_date_reserver = Nothing
        retreving.search_structure.acd_price = Nothing
        retreving.search_structure.acd_duration = Nothing
        retreving.search_structure.acd_res = Nothing
        retreving.search_structure.academic_booking("select * from academic_booking where date_reserver='" + dtp_reserver_search.Text + "'")
        txt_room_code.Text = retreving.search_structure.acd_code
        txt_room_name.Text = retreving.search_structure.acd_name
        txt_cost.Text = retreving.search_structure.acd_price
        txt_duration.Text = retreving.search_structure.acd_duration
        txt_res.Text = retreving.search_structure.acd_res
        dtp_reserver.Text = retreving.search_structure.acd_date_reserver
    End Sub

End Class