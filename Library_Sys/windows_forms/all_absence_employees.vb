Public Class all_absence_employees
    Public Sub clear_txt()
        txt_num.Text = ""
        txt_code.Text = ""
        txt_emp_name.Text = ""
        txt_notes.Text = ""
        txt_job.Text = ""
        cmb_day.Text = ""
        cmb_month.Text = ""
        cmb_emp_search.Text = ""
    End Sub

    Public Sub bind_grid()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from absence"
        reader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            DataGridView1.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4),
                                   reader(5), reader(6), reader(7))
        End While
        con.Close()
        reader.Close()
    End Sub
    Public Sub bind_combo_search()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from absence"
        reader = cmd.ExecuteReader()
        cmb_emp_search.Items.Clear()
        While reader.Read()
            cmb_emp_search.Items.Add(reader(2).ToString)
        End While
        con.Close()
        reader.Close()
    End Sub

    Private Sub all_absence_employees_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bind_grid()
        bind_combo_search()

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from absence where emp_name='" + cmb_emp_search.Text + "'"
        reader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            DataGridView1.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4),
                                   reader(5), reader(6), reader(7))
        End While
        con.Close()
        retreving.search_structure.absence("select * from absence where emp_name='" + cmb_emp_search.Text + "'")
        txt_code.Text = retreving.search_structure.abs_code
        txt_job.Text = retreving.search_structure.abs_job
        txt_num.Text = retreving.search_structure.abs_abs_num
        txt_emp_name.Text = retreving.search_structure.abs_emp_name
        cmb_month.Text = retreving.search_structure.abs_month
        cmb_day.Text = retreving.search_structure.abs_day
        txt_notes.Text = retreving.search_structure.abs_notes

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        Me.Dispose()

    End Sub

    Private Sub btn_all_abs_emps_Click(sender As Object, e As EventArgs) Handles btn_all_abs_emps.Click

        clear_txt()
        bind_grid()

    End Sub
End Class