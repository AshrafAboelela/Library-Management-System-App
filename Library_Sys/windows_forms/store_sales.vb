Public Class store_sales
    Public Sub clear_txt()
        txt_sale_code.Text = ""
        txt_book_price.Text = ""
        txt_sale_code_search.Text = ""
        txt_payed.Text = ""
        txt_quan.Text = ""
        txt_rem.Text = ""
        txt_total.Text = ""
    End Sub
    Public Sub bind_combo_book()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from books_add"
        reader = cmd.ExecuteReader()
        cmb_book_name.Items.Clear()
        While reader.Read()
            cmb_book_name.Items.Add(reader(2).ToString)
        End While
        con.Close()
        reader.Close()
    End Sub
    Public Sub bind_combo_cust()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from customers"
        reader = cmd.ExecuteReader()
        cmb_cust_name.Items.Clear()
        While reader.Read()
            cmb_cust_name.Items.Add(reader(2).ToString)
        End While
        con.Close()
        reader.Close()
    End Sub
    Public Sub bind_grid()
        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from store_sales"
        reader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            DataGridView1.Rows.Add(reader(1), reader(2), reader(3), reader(4),
                                   reader(5), reader(6), reader(7), reader(8), reader(9))
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
        If txt_sale_code.Text = "" Then
            ErrorProvider1.SetError(txt_sale_code, 1)
            txt_sale_code.BackColor = Color.Red
            txt_sale_code.Select()
            Exit Sub
        End If
        If txt_book_price.Text = "" Then
            ErrorProvider1.SetError(txt_book_price, 1)
            txt_book_price.BackColor = Color.Red
            txt_book_price.Select()
            Exit Sub
        End If
        If txt_payed.Text = "" Then
            ErrorProvider1.SetError(txt_payed, 1)
            txt_payed.BackColor = Color.Red
            txt_payed.Select()
            Exit Sub
        End If
        If txt_quan.Text = "" Then
            ErrorProvider1.SetError(txt_quan, 1)
            txt_quan.BackColor = Color.Red
            txt_quan.Select()
            Exit Sub
        End If
        If txt_rem.Text = "" Then
            ErrorProvider1.SetError(txt_rem, 1)
            txt_rem.BackColor = Color.Red
            txt_rem.Select()
            Exit Sub
        End If
        If txt_total.Text = "" Then
            ErrorProvider1.SetError(txt_total, 1)
            txt_total.BackColor = Color.Red
            txt_total.Select()
            Exit Sub
        End If
        retreving.retrive.save("insert into store_sales (code,book_name,cust_name,quan,book_price,payed,remained,total,sale_date) values ('" + txt_sale_code.Text + "','" + cmb_book_name.Text + "','" + cmb_cust_name.Text + "','" + txt_quan.Text + "','" + txt_book_price.Text + "','" + txt_payed.Text + "','" + txt_rem.Text + "','" + txt_total.Text + "','" + dtp_sale_date.Text + "')")
        clear_txt()
        bind_grid()
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        retreving.retrive.update("update store_sales set code='" + txt_sale_code.Text + "',book_name='" + cmb_book_name.Text + "',cust_name='" + cmb_cust_name.Text + "',quan='" + txt_quan.Text + "',book_price='" + txt_book_price.Text + "',sale_date='" + dtp_sale_date.Text + "',payed='" + txt_payed.Text + "',remained='" + txt_rem.Text + "',total='" + txt_total.Text + "' where code='" + txt_sale_code_search.Text + "'")
        clear_txt()
        bind_grid()
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        retreving.retrive.delete("delete from store_sales where code='" + txt_sale_code_search.Text + "'")
        clear_txt()
        bind_grid()
    End Sub

    Private Sub btn_back_Click(sender As Object, e As EventArgs) Handles btn_back.Click
        Me.Dispose()
    End Sub

    Private Sub btn_search_Click(sender As Object, e As EventArgs) Handles btn_search.Click
        If txt_sale_code_search.Text = "" Then
            ErrorProvider1.SetError(txt_sale_code_search, 1)
            txt_sale_code_search.BackColor = Color.Red
            txt_sale_code_search.Select()
            Exit Sub
        End If

        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from store_sales where code='" + txt_sale_code_search.Text + "'"
        reader = cmd.ExecuteReader()
        DataGridView1.Rows.Clear()
        While reader.Read()
            DataGridView1.Rows.Add(reader(1), reader(2), reader(3), reader(4),
                                   reader(5), reader(6), reader(7), reader(8), reader(9))
        End While
        con.Close()

        retreving.search_structure.book_sale_code = Nothing
        retreving.search_structure.book_sale_name = Nothing
        retreving.search_structure.book_sale_price = Nothing
        retreving.search_structure.cust_name = Nothing
        retreving.search_structure.sale_payed = Nothing
        retreving.search_structure.sale_remain = Nothing
        retreving.search_structure.sale_quan = Nothing
        retreving.search_structure.sale_total = Nothing
        retreving.search_structure.sale_date = Nothing
        retreving.search_structure.store_sale("select * from store_sales where code='" + txt_sale_code_search.Text + "'")
        txt_sale_code.Text = retreving.search_structure.book_sale_code
        txt_book_price.Text = retreving.search_structure.book_sale_price
        txt_payed.Text = retreving.search_structure.sale_payed
        txt_quan.Text = retreving.search_structure.sale_quan
        txt_rem.Text = retreving.search_structure.sale_remain
        txt_total.Text = retreving.search_structure.sale_total
        cmb_book_name.Text = retreving.search_structure.book_sale_name
        cmb_cust_name.Text = retreving.search_structure.cust_name
        dtp_sale_date.Text = retreving.search_structure.sale_date
    End Sub

    Private Sub txt_book_price_TextChanged(sender As Object, e As EventArgs) Handles txt_book_price.TextChanged

        txt_total.Text = Val(txt_book_price.Text) * Val(txt_quan.Text)
    End Sub

    Private Sub txt_quan_TextChanged(sender As Object, e As EventArgs) Handles txt_quan.TextChanged

        txt_total.Text = Val(txt_book_price.Text) * Val(txt_quan.Text)
    End Sub

    Private Sub txt_total_TextChanged(sender As Object, e As EventArgs) Handles txt_total.TextChanged

        txt_rem.Text = Val(txt_total.Text) - Val(txt_payed.Text)
    End Sub

    Private Sub txt_payed_TextChanged(sender As Object, e As EventArgs) Handles txt_payed.TextChanged

        txt_rem.Text = Val(txt_total.Text) - Val(txt_payed.Text)
    End Sub

    Private Sub store_sales_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        bind_combo_book()
        bind_combo_cust()
        bind_grid()
    End Sub
End Class