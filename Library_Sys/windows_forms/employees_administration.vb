Public Class employees_administration
    Public Sub clear_txt()
        txt_add.Text = ""
        txt_code.Text = ""
        txt_emp_name.Text = ""
        txt_id.Text = ""
        txt_job.Text = ""
        txt_mob.Text = ""
        cmb_emp_search.Text = ""
    End Sub
    Public Sub bind_combo_search()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from employees_administration"
        reader = cmd.ExecuteReader()
        cmb_emp_search.Items.Clear()
        While reader.Read()
            cmb_emp_search.Items.Add(reader(2).ToString)
        End While
        con.Close()
        reader.Close()
    End Sub
    Public Sub bind_grid()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from employees_administration"
        reader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            DataGridView1.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4),
                                   reader(5), reader(6), reader(7))
        End While
        con.Close()
        reader.Close()
    End Sub
    Public bool As Boolean = False
    Private Sub employees_administration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bind_combo_search()
        bind_grid()

    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        clear_txt()
        bool = True
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_add.Text = "" Then
            ErrorProvider1.SetError(txt_add, 1)
            txt_add.BackColor = Color.Red
            txt_add.Select()
            Exit Sub
        End If
        If txt_code.Text = "" Then
            ErrorProvider1.SetError(txt_code, 1)
            txt_code.BackColor = Color.Red
            txt_code.Select()
            Exit Sub
        End If
        If txt_emp_name.Text = "" Then
            ErrorProvider1.SetError(txt_emp_name, 1)
            txt_emp_name.BackColor = Color.Red
            txt_emp_name.Select()
            Exit Sub
        End If
        If txt_job.Text = "" Then
            ErrorProvider1.SetError(txt_job, 1)
            txt_job.BackColor = Color.Red
            txt_job.Select()
            Exit Sub
        End If
        If txt_mob.Text = "" Then
            ErrorProvider1.SetError(txt_mob, 1)
            txt_mob.BackColor = Color.Red
            txt_mob.Select()
            Exit Sub
        End If
        If txt_id.Text = "" Then
            ErrorProvider1.SetError(txt_id, 1)
            txt_id.BackColor = Color.Red
            txt_id.Select()
            Exit Sub
        End If
        
        retreving.retrive.save("insert into employees_administration (code,emp_name,mobile,date,job,personal_id,address) values ('" + txt_code.Text + "','" + txt_emp_name.Text + "','" + txt_mob.Text + "','" + DateTimePicker1.Text + "','" + txt_job.Text + "','" + txt_id.Text + "','" + txt_add.Text + "')")
        clear_txt()
        bind_combo_search()
        bind_grid()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If txt_add.Text = "" Then
            ErrorProvider1.SetError(txt_add, 1)
            txt_add.BackColor = Color.Red
            txt_add.Select()
            Exit Sub
        End If
        If txt_code.Text = "" Then
            ErrorProvider1.SetError(txt_code, 1)
            txt_code.BackColor = Color.Red
            txt_code.Select()
            Exit Sub
        End If
        If txt_emp_name.Text = "" Then
            ErrorProvider1.SetError(txt_emp_name, 1)
            txt_emp_name.BackColor = Color.Red
            txt_emp_name.Select()
            Exit Sub
        End If
        If txt_job.Text = "" Then
            ErrorProvider1.SetError(txt_job, 1)
            txt_job.BackColor = Color.Red
            txt_job.Select()
            Exit Sub
        End If
        If txt_mob.Text = "" Then
            ErrorProvider1.SetError(txt_mob, 1)
            txt_mob.BackColor = Color.Red
            txt_mob.Select()
            Exit Sub
        End If

        If txt_id.Text = "" Then
            ErrorProvider1.SetError(txt_id, 1)
            txt_id.BackColor = Color.Red
            txt_id.Select()
            Exit Sub
        End If
        retreving.retrive.update("update employees_administration set code='" + txt_code.Text + "',emp_name='" + txt_emp_name.Text + "',mobile='" + txt_mob.Text + "', date='" + DateTimePicker1.Text + "',job='" + txt_job.Text + "',personal_id='" + txt_id.Text + "',address='" + txt_add.Text + "' where emp_name='" + cmb_emp_search.Text + "'")
        clear_txt()
        bind_combo_search()
        bind_grid()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        retreving.retrive.delete("delete from employees_administration where emp_name='" + cmb_emp_search.Text + "'")
        clear_txt()
        bind_combo_search()
        bind_grid()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Dispose()
    End Sub


    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from employees_administration where emp_name='" + cmb_emp_search.Text + "'"
        reader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            DataGridView1.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4),
                                   reader(5), reader(6), reader(7))
        End While
        con.Close()
        retreving.search_structure.employees_administration("select * from employees_administration where emp_name='" + cmb_emp_search.Text + "'")
        txt_code.Text = retreving.search_structure.emp_code
        txt_job.Text = retreving.search_structure.emp_job
        txt_mob.Text = retreving.search_structure.emp_mobile
        txt_emp_name.Text = retreving.search_structure.emp_name
        txt_id.Text = retreving.search_structure.emp_personal
        txt_add.Text = retreving.search_structure.emp_address
        DateTimePicker1.Text = retreving.search_structure.emp_date
    End Sub

    Private Sub btn_all_emps_Click(sender As Object, e As EventArgs) Handles btn_all_emps.Click
        clear_txt()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from employees_administration"
        reader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            DataGridView1.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4),
                                   reader(5), reader(6), reader(7))
        End While
        con.Close()
    End Sub
End Class