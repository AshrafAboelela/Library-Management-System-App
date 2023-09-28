Public Class year_inventory

    Public Sub clear_txt()
        txt_process_num.Text = ""
        txt_year.Text = ""
        txt_current_num.Text = ""
        txt_original_num.Text = ""
        txt_lost_num.Text = ""
    End Sub

    Public bool As Boolean = False
    Public Sub bind_combo_emp()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from employees_administration"
        reader = cmd.ExecuteReader()
        cmb_emp.Items.Clear()
        While reader.Read()
            cmb_emp.Items.Add(reader(2).ToString)
        End While
        con.Close()
        reader.Close()
    End Sub
    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click
        clear_txt()
        bool = True
    End Sub

    Private Sub year_inventory_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bind_combo_emp()
        clear_txt()
    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click
        If txt_process_num.Text = "" Then
            ErrorProvider1.SetError(txt_process_num, 1)
            txt_process_num.BackColor = Color.Red
            txt_process_num.Select()
            Exit Sub
        End If
        If txt_year.Text = "" Then
            ErrorProvider1.SetError(txt_year, 1)
            txt_year.BackColor = Color.Red
            txt_year.Select()
            Exit Sub
        End If
        If txt_current_num.Text = "" Then
            ErrorProvider1.SetError(txt_current_num, 1)
            txt_current_num.BackColor = Color.Red
            txt_current_num.Select()
            Exit Sub
        End If
        If txt_current_num.Text = "" Then
            ErrorProvider1.SetError(txt_current_num, 1)
            txt_current_num.BackColor = Color.Red
            txt_current_num.Select()
            Exit Sub
        End If
        retreving.retrive.save("insert into year_inventory (process_num,year,month,day,hour,emp_name,book_original,book_current,book_lost) values ('" + txt_process_num.Text + "','" + txt_year.Text + "','" + cmb_month.Text + "','" + cmb_day.Text + "','" + txt_time.Text + "','" + cmb_emp.Text + "','" + txt_original_num.Text + "','" + txt_current_num.Text + "','" + txt_lost_num.Text + "')")
        clear_txt()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Dispose()
    End Sub
End Class