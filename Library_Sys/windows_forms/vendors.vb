Public Class vendors
    Public bool As Boolean = False
    Public Sub clear_txt()
        txt_ven_code.Text = ""
        txt_ven_mail.Text = ""
        txt_ven_mob.Text = ""
        txt_ven_name.Text = ""
        txt_ven_tel.Text = ""
        txt_address.Text = ""
    End Sub
    Public Sub bind_combo_search()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from vendors"
        reader = cmd.ExecuteReader()
        cmb_ven_search.Items.Clear()
        While reader.Read()
            cmb_ven_search.Items.Add(reader(2).ToString)
        End While
        con.Close()
        reader.Close()
    End Sub
    Public Sub bind_grid()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from vendors"
        reader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            DataGridView1.Rows.Add(reader(1), reader(2), reader(3), reader(4),
                                   reader(5), reader(6), reader(7))
        End While
        con.Close()
        reader.Close()
    End Sub
    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        clear_txt()
        bool = True

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_ven_code.Text = "" Then
            ErrorProvider1.SetError(txt_ven_code, 1)
            txt_ven_code.BackColor = Color.Red
            txt_ven_code.Select()
            Exit Sub
        End If
        If txt_ven_name.Text = "" Then
            ErrorProvider1.SetError(txt_ven_name, 1)
            txt_ven_name.BackColor = Color.Red
            txt_ven_name.Select()
            Exit Sub
        End If
        If txt_ven_mail.Text = "" Then
            ErrorProvider1.SetError(txt_ven_mail, 1)
            txt_ven_mail.BackColor = Color.Red
            txt_ven_mail.Select()
            Exit Sub
        End If
        If txt_ven_mob.Text = "" Then
            ErrorProvider1.SetError(txt_ven_mob, 1)
            txt_ven_mob.BackColor = Color.Red
            txt_ven_mob.Select()
            Exit Sub
        End If
        If txt_ven_tel.Text = "" Then
            ErrorProvider1.SetError(txt_ven_tel, 1)
            txt_ven_tel.BackColor = Color.Red
            txt_ven_tel.Select()
            Exit Sub
        End If
        If txt_address.Text = "" Then
            ErrorProvider1.SetError(txt_address, 1)
            txt_address.BackColor = Color.Red
            txt_address.Select()
            Exit Sub
        End If
        retreving.retrive.save("insert into vendors (code,ven_name,reg_date,mail,mobile,phone,address) values ('" + txt_ven_code.Text + "','" + txt_ven_name.Text + "','" + dtp_reg_date.Text + "','" + txt_ven_mail.Text + "','" + txt_ven_mob.Text + "','" + txt_ven_tel.Text + "','" + txt_address.Text + "')")
        bind_grid()
        bind_combo_search()
        clear_txt()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        retreving.retrive.update("update vendors set code='" + txt_ven_code.Text + "',ven_name='" + txt_ven_name.Text + "',reg_date='" + dtp_reg_date.Text + "',mail='" + txt_ven_mail.Text + "',phone='" + txt_ven_tel.Text + "',mobile='" + txt_ven_mob.Text + "',address='" + txt_address.Text + "' where ven_name='" + cmb_ven_search.Text + "'")
        clear_txt()
        bind_combo_search()
        bind_grid()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        retreving.retrive.delete("delete from vendors where ven_name='" + cmb_ven_search.Text + "'")
        clear_txt()
        bind_combo_search()
        bind_grid()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Dispose()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If cmb_ven_search.Text = "" Then
            ErrorProvider1.SetError(cmb_ven_search, 1)
            cmb_ven_search.BackColor = Color.Red
            cmb_ven_search.Select()
            Exit Sub
        End If
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from vendors where ven_name='" + cmb_ven_search.Text + "'"
        reader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            DataGridView1.Rows.Add(reader(1), reader(2), reader(3), reader(4),
                                   reader(5), reader(6), reader(7))
        End While
        con.Close()

        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from vendors where ven_name='" + cmb_ven_search.Text + "'"
        reader = cmd.ExecuteReader()
        reader.Read()
        If reader.HasRows Then
            txt_ven_code.Text = reader(1).ToString()
            txt_ven_name.Text = reader(2).ToString()
            txt_ven_tel.Text = reader(3).ToString()
            txt_ven_mob.Text = reader(4).ToString()
            dtp_reg_date.Text = reader(5).ToString()
            txt_ven_mail.Text = reader(6).ToString()
            txt_address.Text = reader(7).ToString()
            reader.Close()
            con.Close()
        Else
            notfound.Show()
            reader.Close()
            con.Close()
        End If

    End Sub

    Private Sub vendors_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bind_combo_search()
        bind_grid()
    End Sub
End Class