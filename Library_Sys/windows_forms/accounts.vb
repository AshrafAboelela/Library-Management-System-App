Public Class accounts
    Public bool As Boolean = False
    Public Sub bind_combo_search()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from accounts"
        reader = cmd.ExecuteReader()
        cmb_emp_search.Items.Clear()
        While reader.Read()
            cmb_emp_search.Items.Add(reader(3).ToString)
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

    Public Sub clear_txt()
        cmb_emp_name.Text = ""
        txt_emp_name.Text = ""
        cmb_month.Text = ""
        txt_code.Text = ""
        txt_basic_salary.Text = ""
        txt_job.Text = ""
        txt_total_salary.Text = ""
        txt_increase_1.Text = ""
        txt_increase_2.Text = ""
        txt_decrease.Text = ""
    End Sub
    Private Sub accounts_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bind_combo_search()
        bind_combo_emp()

    End Sub

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        clear_txt()
        bool = True

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        retreving.retrive.save("insert into accounts (code,month,emp_name,job,basic,increment,increment_2,oppo,total) values ('" + txt_code.Text + "','" + cmb_month.Text + "','" + cmb_emp_name.Text + "','" + txt_job.Text + "','" + txt_basic_salary.Text + "','" + txt_increase_1.Text + "','" + txt_increase_2.Text + "','" + txt_decrease.Text + "','" + txt_total_salary.Text + "')")
        clear_txt()
        bind_combo_search()
        bind_combo_emp()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        retreving.retrive.update("update accounts set code='" + txt_code.Text + "',month='" + cmb_month.Text + "',job='" + txt_job.Text + "', basic='" + txt_basic_salary.Text + "',increment='" + txt_increase_1.Text + "',increment_2='" + txt_increase_2.Text + "',oppo='" + txt_decrease.Text + "',total='" + txt_total_salary.Text + "' where emp_name='" + cmb_emp_name.Text + "'")
        clear_txt()
        bind_combo_search()
        bind_combo_emp()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        retreving.retrive.delete("delete from accounts where emp_name='" + cmb_emp_name.Text + "'")
        clear_txt()
        bind_combo_search()
        bind_combo_emp()

    End Sub

    Private Sub cmb_emp_name_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_emp_name.SelectedIndexChanged

        retreving.retrive.connection()
        retreving.search_structure.emp_code = Nothing
        retreving.search_structure.emp_job = Nothing
        retreving.search_structure.emp_name = Nothing
        retreving.search_structure.employees_administration("select * from employees_administration where emp_name='" + cmb_emp_name.Text + "'")
        txt_code.Text = retreving.search_structure.emp_code
        txt_emp_name.Text = retreving.search_structure.emp_name
        txt_job.Text = retreving.search_structure.emp_job

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        Me.Dispose()

    End Sub

    Private Sub btn_emp_search_Click(sender As Object, e As EventArgs) Handles btn_emp_search.Click

        retreving.search_structure.acc_id = Nothing
        retreving.search_structure.acc_job = Nothing
        retreving.search_structure.acc_oppo = Nothing
        retreving.search_structure.acc_total = Nothing
        retreving.search_structure.acc_emp_name = Nothing
        retreving.search_structure.acc_month = Nothing
        retreving.search_structure.acc_basic = Nothing
        retreving.search_structure.acc_increment = Nothing
        retreving.search_structure.acc_increment_2 = Nothing
        retreving.search_structure.account("select * from accounts where emp_name='" + cmb_emp_search.Text + "'")
        txt_code.Text = retreving.search_structure.acc_id
        txt_job.Text = retreving.search_structure.acc_job
        txt_decrease.Text = retreving.search_structure.acc_oppo
        txt_total_salary.Text = retreving.search_structure.acc_total
        cmb_emp_name.Text = retreving.search_structure.acc_emp_name
        cmb_month.Text = retreving.search_structure.acc_month
        txt_basic_salary.Text = retreving.search_structure.acc_basic
        txt_increase_1.Text = retreving.search_structure.acc_increment
        txt_increase_2.Text = retreving.search_structure.acc_increment_2

    End Sub

    Private Sub txt_basic_salary_TextChanged(sender As Object, e As EventArgs) Handles txt_basic_salary.TextChanged

        txt_total_salary.Text = Val(txt_basic_salary.Text) + Val(txt_increase_1.Text) + Val(txt_increase_2.Text) - Val(txt_decrease.Text)

    End Sub

    Private Sub txt_increase_1_TextChanged(sender As Object, e As EventArgs) Handles txt_increase_1.TextChanged

        txt_total_salary.Text = Val(txt_basic_salary.Text) + Val(txt_increase_1.Text) + Val(txt_increase_2.Text) - Val(txt_decrease.Text)

    End Sub

    Private Sub txt_increase_2_TextChanged(sender As Object, e As EventArgs) Handles txt_increase_2.TextChanged

        txt_total_salary.Text = Val(txt_basic_salary.Text) + Val(txt_increase_1.Text) + Val(txt_increase_2.Text) - Val(txt_decrease.Text)

    End Sub

    Private Sub txt_decrease_TextChanged(sender As Object, e As EventArgs) Handles txt_decrease.TextChanged

        txt_total_salary.Text = Val(txt_basic_salary.Text) + Val(txt_increase_1.Text) + Val(txt_increase_2.Text) - Val(txt_decrease.Text)

    End Sub
End Class