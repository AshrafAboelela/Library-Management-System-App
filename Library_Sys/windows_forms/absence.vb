Public Class absence

    Public bool As Boolean = False
    Public Sub clear_txt()
        txt_code.Text = ""
        txt_emp_name.Text = ""
        txt_job.Text = ""
        txt_notes.Text = ""
        txt_num.Text = ""
        cmb_day.Text = ""
        cmb_emp_name.Text = ""
        cmb_month.Text = ""
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
    End Sub
    Public Sub bind_combo_emp()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from employees_administration"
        reader = cmd.ExecuteReader()
        cmb_emp_name.Items.Clear()
        While reader.Read()
            cmb_emp_name.Items.Add(reader(2).ToString)
        End While
        con.Close()
        reader.Close()
    End Sub

    Private Sub absence_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bind_combo_emp()
        bind_grid()
    End Sub

    Private Sub cmb_emp_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_emp_name.SelectedIndexChanged
        retreving.retrive.connection()
        retreving.search_structure.emp_name = Nothing
        retreving.search_structure.emp_code = Nothing
        retreving.search_structure.emp_job = Nothing
        retreving.search_structure.employees_administration("select * from employees_administration where emp_name='" + cmb_emp_name.Text + "'")
        txt_code.Text = retreving.search_structure.emp_code
        txt_job.Text = retreving.search_structure.emp_job
        txt_emp_name.Text = retreving.search_structure.emp_name
    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        clear_txt()
        bool = True
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        retreving.retrive.save("insert into absence (code,emp_name,job,abs_num,month,day,notes) values ('" + txt_code.Text + "','" + cmb_emp_name.Text + "','" + txt_job.Text + "','" + txt_num.Text + "','" + cmb_month.Text + "','" + cmb_day.Text + "','" + txt_notes.Text + "')")
        clear_txt()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Dispose()
    End Sub

End Class