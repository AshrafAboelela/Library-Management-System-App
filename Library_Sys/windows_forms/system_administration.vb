Public Class system_administration
    Public Sub clear_txt()
        txt_emp_name.Text = ""
        txt_job.Text = ""
        txt_mob.Text = ""
        cmb_emp_search.Text = ""
    End Sub
    Public Sub clear_check()
        chk_academic_booking.Checked = False
        chk_add_book.Checked = False
        chk_archiving.Checked = False
        chk_metaphor.Checked = False
        chk_emp.Checked = False
        chk_store.Checked = False
        chk_inventory.Checked = False
        chk_lib.Checked = False
        chk_sys_admin.Checked = False
        chk_reports.Checked = False
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
    Public bool As Boolean = False
    Private Sub system_administration_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bind_combo_search()
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        clear_txt()
        bool = True
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
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
        retreving.retrive.save("insert into permissions (emp_name,job,mobil,emp_admin,add_library,inventory,books_add,store_library,metaphor,archiving,academic_booking,sys_admin,reports) values ('" + txt_emp_name.Text + "','" + txt_job.Text + "','" + txt_mob.Text + "','" + chk_emp.Checked.ToString() + "','" + chk_lib.Checked.ToString() + "','" + chk_inventory.Checked.ToString() + "','" + chk_add_book.Checked.ToString() + "','" + chk_store.Checked.ToString() + "','" + chk_metaphor.Checked.ToString() + "','" + chk_archiving.Checked.ToString() + "','" + chk_academic_booking.Checked.ToString() + "','" + chk_sys_admin.Checked.ToString() + "','" + chk_reports.Checked.ToString() + "')")
        clear_txt()
        clear_check()
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
        reader.Read()
        If reader.HasRows Then
            txt_emp_name.Text = reader(2).ToString()
            txt_job.Text = reader(5).ToString()
            txt_mob.Text = reader(3).ToString()
            reader.Close()
            con.Close()
        Else
            reader.Close()
            con.Close()
            notfound.Show()
        End If
    End Sub

End Class