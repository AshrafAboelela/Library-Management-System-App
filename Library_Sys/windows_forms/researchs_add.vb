Public Class researchs_add
    Public Sub clear_txt()
        txt_research_code.Text = ""
        txt_research_name.Text = ""
        txt_researcher_name.Text = ""
    End Sub
    Public Sub bind_combo_search()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from researchs_add"
        reader = cmd.ExecuteReader()
        cmb_research_search.Items.Clear()
        While reader.Read()
            cmb_research_search.Items.Add(reader(2).ToString)
        End While
        con.Close()
        reader.Close()
    End Sub
    Public Sub bind_grid()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from researchs_add"
        reader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            DataGridView1.Rows.Add(reader(1), reader(2), reader(3), reader(4))
        End While
        con.Close()
        reader.Close()
    End Sub

    Public bool As Boolean = False

    Private Sub btn_new_Click(sender As Object, e As EventArgs) Handles btn_new.Click

        clear_txt()
        bool = True

    End Sub

    Private Sub btn_save_Click(sender As Object, e As EventArgs) Handles btn_save.Click

        If txt_research_code.Text = "" Then
            ErrorProvider1.SetError(txt_research_code, 1)
            txt_research_code.BackColor = Color.Red
            txt_research_code.Select()
            Exit Sub
        End If
        If txt_research_name.Text = "" Then
            ErrorProvider1.SetError(txt_research_name, 1)
            txt_research_name.BackColor = Color.Red
            txt_research_name.Select()
            Exit Sub
        End If
        If txt_researcher_name.Text = "" Then
            ErrorProvider1.SetError(txt_researcher_name, 1)
            txt_researcher_name.BackColor = Color.Red
            txt_researcher_name.Select()
            Exit Sub
        End If
        retreving.retrive.save("insert into researchs_add (res_code,res_name,researcher_name,reg_date) values ('" + txt_research_code.Text + "','" + txt_research_name.Text + "','" + txt_researcher_name.Text + "','" + dtp_reg_date.Text + "')")
        clear_txt()
        bind_combo_search()
        bind_grid()

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        If txt_research_code.Text = "" Then
            ErrorProvider1.SetError(txt_research_code, 1)
            txt_research_code.BackColor = Color.Red
            txt_research_code.Select()
            Exit Sub
        End If
        If txt_research_name.Text = "" Then
            ErrorProvider1.SetError(txt_research_name, 1)
            txt_research_name.BackColor = Color.Red
            txt_research_name.Select()
            Exit Sub
        End If
        If txt_researcher_name.Text = "" Then
            ErrorProvider1.SetError(txt_researcher_name, 1)
            txt_researcher_name.BackColor = Color.Red
            txt_researcher_name.Select()
            Exit Sub
        End If
        retreving.retrive.update("update researchs_add set res_code='" + txt_research_code.Text + "',res_name='" + txt_research_name.Text + "',researcher_name='" + txt_researcher_name.Text + "',reg_date='" + dtp_reg_date.Text + "' where res_name='" + cmb_research_search.Text + "'")
        clear_txt()
        bind_combo_search()
        bind_grid()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        retreving.retrive.delete("delete from researchs_add where res_name='" + cmb_research_search.Text + "'")
        clear_txt()
        bind_combo_search()
        bind_grid()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        Me.Dispose()

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If cmb_research_search.Text = "" Then
            ErrorProvider1.SetError(cmb_research_search, 1)
            cmb_research_search.BackColor = Color.Red
            cmb_research_search.Select()
            Exit Sub
        End If
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from researchs_add where res_name='" + cmb_research_search.Text + "'"
        reader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            DataGridView1.Rows.Add(reader(1), reader(2), reader(3), reader(4))
        End While
        con.Close()
        retreving.search_structure.res_code = Nothing
        retreving.search_structure.res_name = Nothing
        retreving.search_structure.res_researcher_name = Nothing
        retreving.search_structure.res_reg_date = Nothing
        retreving.search_structure.research_add("select * from researchs_add where res_name='" + cmb_research_search.Text + "'")
        txt_research_code.Text = retreving.search_structure.res_code
        txt_research_name.Text = retreving.search_structure.res_name
        txt_researcher_name.Text = retreving.search_structure.res_researcher_name
        dtp_reg_date.Text = retreving.search_structure.res_reg_date
    End Sub

    Private Sub researchs_add_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bind_combo_search()
        bind_grid()

    End Sub
End Class