Public Class retreving
Public Structure retrive
        Shared Sub connection()
            Try
                Dim s As String
                Dim d As String
                Dim u As String
                Dim p As String

                cn.Open(connect)
                rs.CursorLocation = ADODB.CursorLocationEnum.adUseClient
                rs.Open("select * from connection_str where " + "server_name='DESKTOP-E76UUDF\SQLEXPRESS'", cn,
                        ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
                If rs.EOF Or rs.BOF Then
                    MsgBox("عفوا اسم السيرفر غير مسجل من قبل")
                    cn.Close()
                    Exit Sub
                Else
                    s = rs("server_name").Value
                    d = rs("database_name").Value
                    u = rs("user_name").Value
                    p = rs("password").Value
                    provider = "Provider=SQLOLEDB.1;Integrated Security=SSPI;Persist Security Info=False;Initial Catalog='" + d + "';Data Source='" + s + "'"
                    con.ConnectionString = provider
                    con.Close()
                    cn.Close()
                    'MsgBox("Done")
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Shared Sub save(ByVal sqlstatement As String)
            Try
                connection()
                con.ConnectionString = provider
                cmd.Connection = con
                con.Open()
                cmd.CommandText = sqlstatement
                cmd.ExecuteNonQuery()
                con.Close()
                sqlstatement = Nothing
                Library_Sys.saved.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Shared Sub update(ByVal sqlstatement As String)
            Try
                connection()
                con.ConnectionString = provider
                cmd.Connection = con
                con.Open()
                cmd.CommandText = sqlstatement
                cmd.ExecuteNonQuery()
                con.Close()
                sqlstatement = Nothing
                Library_Sys.update.Show()
                'update.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub
        Shared Sub delete(ByVal sqlstatement As String)
            Try
                connection()
                con.ConnectionString = provider
                cmd.Connection = con
                con.Open()
                cmd.CommandText = sqlstatement
                cmd.ExecuteNonQuery()
                con.Close()
                sqlstatement = Nothing
                Library_Sys.delete.Show()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Shared Sub gettotalofbooks()
            Try
                Dim get_total As String
                connection()
                cmd.Connection = con
                con.Open()
                cmd.CommandText = "select count (id) as total from books_add"
                reader = cmd.ExecuteReader()
                reader.Read()
                If reader.HasRows Then
                    get_total = reader("total").ToString()
                    con.Close()
                    reader.Close()
                    retreving.retrive.save("insert into number_books (number) values ('" + get_total.ToString() + "')")
                End If
                con.Close()
                reader.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

    End Structure
    Public Structure search_structure
        Shared abs_id As String
        Shared abs_code As String
        Shared abs_emp_name As String
        Shared abs_job As String
        Shared abs_abs_num As String
        Shared abs_month As String
        Shared abs_day As String
        Shared abs_notes As String
        Shared Sub absence(ByVal sqlstatement As String)
            Try
                cmd.Connection = con
                con.Open()
                cmd.CommandText = sqlstatement
                reader = cmd.ExecuteReader()
                reader.Read()
                If reader.HasRows Then
                    abs_id = reader("id").ToString()
                    abs_code = reader("code").ToString()
                    abs_emp_name = reader("emp_name").ToString()
                    abs_job = reader("job").ToString()
                    abs_abs_num = reader("abs_num").ToString()
                    abs_month = reader("month").ToString()
                    abs_day = reader("day").ToString()
                    abs_notes = reader("notes").ToString()
                    con.Close()
                    reader.Close()
                    reader = Nothing
                Else
                    Library_Sys.notfound.Show()
                    con.Close()
                    reader.Close()
                    reader = Nothing
                    sqlstatement = Nothing
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Shared emp_id As String
        Shared emp_code As String
        Shared emp_name As String
        Shared emp_mobile As String
        Shared emp_date As String
        Shared emp_job As String
        Shared emp_personal As String
        Shared emp_address As String

        Shared Sub employees_administration(ByVal sqlstatement As String)
            Try
                retreving.retrive.connection()
                cmd.Connection = con
                con.Open()
                cmd.CommandText = sqlstatement
                reader = cmd.ExecuteReader()
                reader.Read()
                If reader.HasRows Then
                    emp_id = reader(0).ToString()
                    emp_code = reader(1).ToString()
                    emp_name = reader(2).ToString()
                    emp_mobile = reader(3).ToString()
                    emp_date = reader(4).ToString()
                    emp_job = reader(5).ToString()
                    emp_personal = reader(6).ToString()
                    emp_address = reader(7).ToString()
                    con.Close()
                    reader.Close()
                Else
                    notfound.Show()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Shared acc_id As String
        Shared acc_code As String
        Shared acc_month As String
        Shared acc_emp_name As String
        Shared acc_job As String
        Shared acc_basic As String
        Shared acc_increment As String
        Shared acc_increment_2 As String
        Shared acc_oppo As String
        Shared acc_total As String

        Shared Sub account(ByVal sqlstatement As String)
            Try
                retreving.retrive.connection()
                cmd.Connection = con
                con.Open()
                cmd.CommandText = sqlstatement
                reader = cmd.ExecuteReader()
                reader.Read()
                If reader.HasRows Then
                    acc_id = reader(0).ToString()
                    acc_code = reader(1).ToString()
                    acc_month = reader(2).ToString()
                    acc_emp_name = reader(3).ToString()
                    acc_job = reader(4).ToString()
                    acc_basic = reader(5).ToString()
                    acc_increment = reader(6).ToString()
                    acc_increment_2 = reader(7).ToString()
                    acc_oppo = reader(8).ToString()
                    acc_total = reader(9).ToString()
                    con.Close()
                    reader.Close()
                Else
                    notfound.Show()
                    con.Close()
                    reader.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Shared lib_id As String
        Shared lib_code As String
        Shared lib_date As String
        Shared lib_name As String
        Shared lib_address As String
        Shared lib_fax As String
        Shared lib_phone As String
        Shared Sub add_library(ByVal sqlstatement As String)
            Try
                retreving.retrive.connection()
                cmd.Connection = con
                con.Open()
                cmd.CommandText = sqlstatement
                reader = cmd.ExecuteReader()
                reader.Read()
                If reader.HasRows Then
                    lib_id = reader(0).ToString()
                    lib_code = reader(1).ToString()
                    lib_name = reader(2).ToString()
                    lib_date = reader(3).ToString()
                    lib_address = reader(4).ToString()
                    lib_fax = reader(5).ToString()
                    lib_phone = reader(6).ToString()
                    con.Close()
                    reader.Close()
                Else
                    notfound.Show()
                    con.Close()
                    reader.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Shared acd_id As String
        Shared acd_code As String
        Shared acd_name As String
        Shared acd_date_reserver As String
        Shared acd_duration As String
        Shared acd_price As String
        Shared acd_res As String

        Shared Sub academic_booking(ByVal sqlstatement As String)
            Try
                retreving.retrive.connection()
                cmd.Connection = con
                con.Open()
                cmd.CommandText = sqlstatement
                reader = cmd.ExecuteReader()
                reader.Read()
                If reader.HasRows Then
                    acd_id = reader(0).ToString()
                    acd_code = reader(1).ToString()
                    acd_name = reader(2).ToString()
                    acd_date_reserver = reader(3).ToString()
                    acd_duration = reader(4).ToString()
                    acd_price = reader(5).ToString()
                    acd_res = reader(6).ToString()
                    con.Close()
                    reader.Close()
                Else
                    notfound.Show()
                    con.Close()
                    reader.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Shared book_id As String
        Shared book_code As String
        Shared book_name As String
        Shared auth_name As String
        Shared book_isbn As String
        Shared reg_date As String
        Shared publish_date As String

        Shared Sub books_add(ByVal sqlstatement As String)
            Try
                retreving.retrive.connection()
                cmd.Connection = con
                con.Open()
                cmd.CommandText = sqlstatement
                reader = cmd.ExecuteReader()
                reader.Read()
                If reader.HasRows Then
                    book_id = reader(0).ToString()
                    book_code = reader(1).ToString()
                    book_name = reader(2).ToString()
                    auth_name = reader(3).ToString()
                    book_isbn = reader(4).ToString()
                    publish_date = reader(5).ToString()
                    reg_date = reader(6).ToString()
                    con.Close()
                    reader.Close()
                Else
                    notfound.Show()
                    con.Close()
                    reader.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Shared bc_id As String
        Shared bc_code As String
        Shared bc_book_name As String
        Shared bc_book_num As String
        Shared bc_auth_name As String
        Shared bc_book_isbn As String
        Shared bc_reg_date As String
        Shared bc_book_copy As String

        Shared Sub books_copy_add(ByVal sqlstatement As String)
            Try
                retreving.retrive.connection()
                cmd.Connection = con
                con.Open()
                cmd.CommandText = sqlstatement
                reader = cmd.ExecuteReader()
                reader.Read()
                If reader.HasRows Then
                    bc_id = reader(0).ToString()
                    bc_code = reader(1).ToString()
                    bc_book_name = reader(2).ToString()
                    bc_book_copy = reader(3).ToString()
                    bc_auth_name = reader(4).ToString()
                    bc_book_isbn = reader(5).ToString()
                    bc_reg_date = reader(6).ToString()
                    bc_book_num = reader(7).ToString()
                    con.Close()
                    reader.Close()
                Else
                    notfound.Show()
                    con.Close()
                    reader.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Shared msg_id As String
        Shared msg_code As String
        Shared msg_message_name As String
        Shared msg_researcher_name As String
        Shared msg_reg_date As String

        Shared Sub messages_add(ByVal sqlstatement As String)
            Try
                retreving.retrive.connection()
                cmd.Connection = con
                con.Open()
                cmd.CommandText = sqlstatement
                reader = cmd.ExecuteReader()
                reader.Read()
                If reader.HasRows Then
                    msg_id = reader(0).ToString()
                    msg_code = reader(1).ToString()
                    msg_message_name = reader(2).ToString()
                    msg_researcher_name = reader(3).ToString()
                    msg_reg_date = reader(4).ToString()
                    con.Close()
                    reader.Close()
                Else
                    notfound.Show()
                    con.Close()
                    reader.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Shared res_id As String
        Shared res_code As String
        Shared res_name As String
        Shared res_researcher_name As String
        Shared res_reg_date As String

        Shared Sub research_add(ByVal sqlstatement As String)
            Try
                retreving.retrive.connection()
                cmd.Connection = con
                con.Open()
                cmd.CommandText = sqlstatement
                reader = cmd.ExecuteReader()
                reader.Read()
                If reader.HasRows Then
                    res_id = reader(0).ToString()
                    res_code = reader(1).ToString()
                    res_name = reader(2).ToString()
                    res_researcher_name = reader(3).ToString()
                    res_reg_date = reader(4).ToString()
                    con.Close()
                    reader.Close()
                Else
                    notfound.Show()
                    con.Close()
                    reader.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Shared book_buy_code As String
        Shared book_buy_name As String
        Shared ven_name As String
        Shared book_buy_price As String
        Shared buy_payed As String
        Shared buy_remain As String
        Shared buy_quan As String
        Shared buy_total As String
        Shared buy_date As String

        Shared Sub store_buy(ByVal sqlstatement As String)
            Try
                retreving.retrive.connection()
                cmd.Connection = con
                con.Open()
                cmd.CommandText = sqlstatement
                reader = cmd.ExecuteReader()
                reader.Read()
                If reader.HasRows Then
                    book_buy_code = reader(1).ToString()
                    ven_name = reader(2).ToString()
                    book_buy_name = reader(3).ToString()
                    buy_quan = reader(4).ToString()
                    book_buy_price = reader(5).ToString()
                    buy_payed = reader(6).ToString()
                    buy_remain = reader(7).ToString()
                    buy_total = reader(8).ToString()
                    buy_date = reader(9).ToString()
                    con.Close()
                    reader.Close()
                Else
                    notfound.Show()
                    con.Close()
                    reader.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

        Shared book_sale_code As String
        Shared book_sale_name As String
        Shared cust_name As String
        Shared book_sale_price As String
        Shared sale_payed As String
        Shared sale_remain As String
        Shared sale_quan As String
        Shared sale_total As String
        Shared sale_date As String

        Shared Sub store_sale(ByVal sqlstatement As String)
            Try
                retreving.retrive.connection()
                cmd.Connection = con
                con.Open()
                cmd.CommandText = sqlstatement
                reader = cmd.ExecuteReader()
                reader.Read()
                If reader.HasRows Then
                    book_sale_code = reader(1).ToString()
                    cust_name = reader(2).ToString()
                    book_sale_name = reader(3).ToString()
                    sale_quan = reader(4).ToString()
                    book_sale_price = reader(5).ToString()
                    sale_payed = reader(6).ToString()
                    sale_total = reader(7).ToString()
                    sale_remain = reader(8).ToString()
                    sale_date = reader(9).ToString()
                    con.Close()
                    reader.Close()
                Else
                    notfound.Show()
                    con.Close()
                    reader.Close()
                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End Sub

    End Structure
End Class
