Public Class customers
    Public bool As Boolean = False
    Public Sub clear_txt()
        txt_cust_code.Text = ""
        txt_cust_mail.Text = ""
        txt_cust_mob.Text = ""
        txt_cust_name.Text = ""
        txt_cust_tel.Text = ""
    End Sub
    Public Sub bind_combo_search()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from customers"
        reader = cmd.ExecuteReader()
        cmb_cust_search.Items.Clear()
        While reader.Read()
            cmb_cust_search.Items.Add(reader(2).ToString)
        End While
        con.Close()
        reader.Close()
    End Sub
    Public Sub bind_grid()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from customers"
        reader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            DataGridView1.Rows.Add(reader(1), reader(2), reader(3), reader(4),
                                   reader(5), reader(6))
        End While
        con.Close()
        reader.Close()
    End Sub
    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        clear_txt()
        bool = True

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_cust_code.Text = "" Then
            ErrorProvider1.SetError(txt_cust_code, 1)
            txt_cust_code.BackColor = Color.Red
            txt_cust_code.Select()
            Exit Sub
        End If
        If txt_cust_name.Text = "" Then
            ErrorProvider1.SetError(txt_cust_name, 1)
            txt_cust_name.BackColor = Color.Red
            txt_cust_name.Select()
            Exit Sub
        End If
        If txt_cust_mail.Text = "" Then
            ErrorProvider1.SetError(txt_cust_mail, 1)
            txt_cust_mail.BackColor = Color.Red
            txt_cust_mail.Select()
            Exit Sub
        End If
        If txt_cust_mob.Text = "" Then
            ErrorProvider1.SetError(txt_cust_mob, 1)
            txt_cust_mob.BackColor = Color.Red
            txt_cust_mob.Select()
            Exit Sub
        End If
        If txt_cust_tel.Text = "" Then
            ErrorProvider1.SetError(txt_cust_tel, 1)
            txt_cust_tel.BackColor = Color.Red
            txt_cust_tel.Select()
            Exit Sub
        End If
        retreving.retrive.save("insert into customers (code,cust_name,reg_date,mail,mobile,phone) values ('" + txt_cust_code.Text + "','" + txt_cust_name.Text + "','" + dtp_reg_date.Text + "','" + txt_cust_mail.Text + "','" + txt_cust_mob.Text + "','" + txt_cust_tel.Text + "')")
        bind_grid()
        bind_combo_search()
        clear_txt()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        retreving.retrive.update("update customers set code='" + txt_cust_code.Text + "',cust_name='" + txt_cust_name.Text + "',reg_date='" + dtp_reg_date.Text + "',mail='" + txt_cust_mail.Text + "',phone='" + txt_cust_tel.Text + "',mobile='" + txt_cust_mob.Text + "' where cust_name='" + cmb_cust_search.Text + "'")
        clear_txt()
        bind_combo_search()
        bind_grid()
    End Sub

    Private Sub customers_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bind_grid()
        bind_combo_search()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        retreving.retrive.delete("delete from customers where cust_name='" + cmb_cust_search.Text + "'")
        clear_txt()
        bind_combo_search()
        bind_grid()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        Me.Dispose()

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

        If cmb_cust_search.Text = "" Then
            ErrorProvider1.SetError(cmb_cust_search, 1)
            cmb_cust_search.BackColor = Color.Red
            cmb_cust_search.Select()
            Exit Sub
        End If
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from customers where cust_name='" + cmb_cust_search.Text + "'"
        reader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            DataGridView1.Rows.Add(reader(1), reader(2), reader(3), reader(4),
                                   reader(5), reader(6))
        End While
        con.Close()

        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from customers where cust_name='" + cmb_cust_search.Text + "'"
        reader = cmd.ExecuteReader()
        reader.Read()
        If reader.HasRows Then
            txt_cust_code.Text = reader(1).ToString()
            txt_cust_name.Text = reader(2).ToString()
            txt_cust_tel.Text = reader(3).ToString()
            txt_cust_mob.Text = reader(4).ToString()
            dtp_reg_date.Text = reader(5).ToString()
            txt_cust_mail.Text = reader(6).ToString()
            reader.Close()
            con.Close()
        Else
            notfound.Show()
            reader.Close()
            con.Close()
        End If

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class