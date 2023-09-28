Public Class add_library
    Public bool As Boolean = False
    Public Sub clear_txt()

        txt_lib_code.Text = ""
        txt_lib_name.Text = ""
        txt_lib_fax.Text = ""
        txt_lib_tel.Text = ""
        txt_lib_add.Text = ""

    End Sub
    Public Sub bind_combo_search()

        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from add_library"
        reader = cmd.ExecuteReader()
        cmb_lib_search.Items.Clear()
        While reader.Read()
            cmb_lib_search.Items.Add(reader(2).ToString)
        End While
        con.Close()
        reader.Close()

    End Sub
    Public Sub bind_grid()

        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from add_library"
        reader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            DataGridView1.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4),
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

        If txt_lib_add.Text = "" Then
            ErrorProvider1.SetError(txt_lib_add, 1)
            txt_lib_add.BackColor = Color.Red
            txt_lib_add.Select()
            Exit Sub
        End If
        If txt_lib_name.Text = "" Then
            ErrorProvider1.SetError(txt_lib_name, 1)
            txt_lib_name.BackColor = Color.Red
            txt_lib_name.Select()
            Exit Sub
        End If
        If txt_lib_fax.Text = "" Then
            ErrorProvider1.SetError(txt_lib_fax, 1)
            txt_lib_fax.BackColor = Color.Red
            txt_lib_fax.Select()
            Exit Sub
        End If
        If txt_lib_tel.Text = "" Then
            ErrorProvider1.SetError(txt_lib_tel, 1)
            txt_lib_tel.BackColor = Color.Red
            txt_lib_tel.Select()
            Exit Sub
        End If
        If txt_lib_code.Text = "" Then
            ErrorProvider1.SetError(txt_lib_code, 1)
            txt_lib_code.BackColor = Color.Red
            txt_lib_code.Select()
            Exit Sub
        End If

        retreving.retrive.save("insert into add_library (code,lib_name,date,address,fax,phone) values ('" + txt_lib_code.Text + "','" + txt_lib_name.Text + "','" + DateTimePicker1.Text + "','" + txt_lib_add.Text + "','" + txt_lib_fax.Text + "','" + txt_lib_tel.Text + "')")

        bind_grid()
        bind_combo_search()
        clear_txt()

    End Sub

    Private Sub add_library_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bind_grid()
        bind_combo_search()

    End Sub

    Private Sub txt_lib_code_TextChanged(sender As Object, e As EventArgs) Handles txt_lib_code.TextChanged

        ErrorProvider1.Clear()
        txt_lib_code.BackColor = Color.White

    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click

        retreving.retrive.update("update add_library set code='" + txt_lib_code.Text + "',date='" + DateTimePicker1.Text + "',address='" + txt_lib_add.Text + "',fax='" + txt_lib_fax.Text + "',lib_name='" + txt_lib_name.Text + "',phone='" + txt_lib_tel.Text + "' where lib_name='" + cmb_lib_search.Text + "'")
        clear_txt()
        bind_combo_search()
        bind_grid()

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        retreving.retrive.delete("delete from add_library where lib_name='" + cmb_lib_search.Text + "'")
        clear_txt()
        bind_combo_search()
        bind_grid()

    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click

        Me.Dispose()

    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click

        If cmb_lib_search.Text = "" Then
            ErrorProvider1.SetError(cmb_lib_search, 1)
            cmb_lib_search.BackColor = Color.Red
            cmb_lib_search.Select()
            Exit Sub
        End If
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from add_library where lib_name='" + cmb_lib_search.Text + "'"
        reader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            DataGridView1.Rows.Add(reader(0), reader(1), reader(2), reader(3), reader(4),
                                   reader(5), reader(6))
        End While
        con.Close()
        retreving.search_structure.lib_id = Nothing
        retreving.search_structure.lib_code = Nothing
        retreving.search_structure.lib_name = Nothing
        retreving.search_structure.lib_date = Nothing
        retreving.search_structure.lib_address = Nothing
        retreving.search_structure.lib_fax = Nothing
        retreving.search_structure.lib_phone = Nothing
        retreving.search_structure.add_library("select * from add_library where lib_name='" + cmb_lib_search.Text + "'")
        txt_lib_code.Text = retreving.search_structure.lib_code
        txt_lib_name.Text = retreving.search_structure.lib_name
        DateTimePicker1.Text = retreving.search_structure.lib_date
        txt_lib_add.Text = retreving.search_structure.lib_address
        txt_lib_fax.Text = retreving.search_structure.lib_fax
        txt_lib_tel.Text = retreving.search_structure.lib_phone

    End Sub
End Class