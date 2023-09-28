Imports ADODB

Public Class login
    Public Sub check_status()
        Dim emp_admin As Boolean
        Dim add_library As Boolean
        Dim inventory As Boolean
        Dim books_add As Boolean
        Dim archiving As Boolean
        Dim metaphor As Boolean
        Dim academic_booking As Boolean
        Dim store_library As Boolean
        Dim sys_admin As Boolean
        Dim reports As Boolean

        retreving.retrive.connection()
        cmd.Connection = con
        con.Open()
        cmd.CommandText = "select * from permissions where emp_name='" + txt_user.Text + "'"
        reader = cmd.ExecuteReader()
        reader.Read()
        If reader.HasRows Then
            emp_admin = reader(4).ToString()
            add_library = reader(5).ToString()
            inventory = reader(6).ToString()
            books_add = reader(7).ToString()
            store_library = reader(8).ToString()
            metaphor = reader(9).ToString()
            archiving = reader(10).ToString()
            academic_booking = reader(11).ToString()
            sys_admin = reader(12).ToString()
            reports = reader(13).ToString()
            reader.Close()
            con.Close()
        Else
            MsgBox("عفوا لا توجد اى صلاحيات للدخول")
            con.Close()
            reader.Close()
        End If
        If emp_admin = True Then
            With main
                .open_1.Enabled = True
                .close_1.Enabled = True
            End With
        Else
            With main
                .open_1.Enabled = False
                .close_1.Enabled = False
            End With
        End If
        If add_library = True Then
            With main
                .open_2.Enabled = True
                .close_2.Enabled = True
            End With
        Else
            With main
                .open_2.Enabled = False
                .close_2.Enabled = False
            End With
        End If
        If books_add = True Then
            With main
                .open_3.Enabled = True
                .close_3.Enabled = True
            End With
        Else
            With main
                .open_3.Enabled = False
                .close_3.Enabled = False
            End With
        End If
        If metaphor = True Then
            With main
                .open_4.Enabled = True
                .close_4.Enabled = True
            End With
        Else
            With main
                .open_4.Enabled = False
                .close_4.Enabled = False
            End With
        End If

        If archiving = True Then
            With main
                .open_5.Enabled = True
                .close_5.Enabled = True
            End With
        Else
            With main
                .open_5.Enabled = False
                .close_5.Enabled = False
            End With
        End If
        If store_library = True Then
            With main
                .open_6.Enabled = True
                .close_6.Enabled = True
            End With
        Else
            With main
                .open_6.Enabled = False
                .close_6.Enabled = False
            End With
        End If
        If inventory = True Then
            With main
                .open_7.Enabled = True
                .close_7.Enabled = True
            End With
        Else
            With main
                .open_7.Enabled = False
                .close_7.Enabled = False
            End With
        End If

        If academic_booking = True Then
            With main
                .open_8.Enabled = True
                .close_8.Enabled = True
            End With
        Else
            With main
                .open_8.Enabled = False
                .close_8.Enabled = False
            End With
        End If

        If sys_admin = True Then
            With main
                .open_9.Enabled = True
                .close_9.Enabled = True
            End With
        Else
            With main
                .open_9.Enabled = False
                .close_9.Enabled = False
            End With
        End If

        If reports = True Then
            With main
                .open_10.Enabled = True
                .close_10.Enabled = True
            End With
        Else
            With main
                .open_10.Enabled = False
                .close_10.Enabled = False
            End With
        End If

    End Sub
    Public Sub cleartxt()
        txt_server.Text = ""
        txt_database.Text = ""
        txt_user_server.Text = ""
        txt_pass_server.Text = ""
    End Sub

    Private Sub btn_record_Click(sender As Object, e As EventArgs) Handles btn_record.Click
        Try
            Dim x As String = "Provider=microsoft.ACE.oledb.12.0;Data Source=administration.accdb;Persist Security Info=False"
            cn.Open(x)
            rs.CursorLocation = CursorLocationEnum.adUseClient
            rs.Open("connection_str", cn, CursorTypeEnum.adOpenStatic, LockTypeEnum.adLockOptimistic)
            rs.AddNew()
            rs("server_name").Value = txt_server.Text
            rs("database_name").Value = txt_database.Text
            rs("user_name").Value = txt_user_server.Text
            rs("password").Value = txt_pass_server.Text
            rs.Update()
            rs.Close()
            MsgBox("تم تسجيل التوصيل بقاعدة البيانات", MsgBoxStyle.OkOnly + vbInformation, "تاكيد")
            retreving.retrive.connection()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cleartxt()
    End Sub

    Private Sub btn_cancel_Click(sender As Object, e As EventArgs) Handles btn_cancel.Click
        cleartxt()
    End Sub

    Private Sub btn_end_Click(sender As Object, e As EventArgs) Handles btn_end.Click
        End
    End Sub

    Private Sub btn_manager_Click(sender As Object, e As EventArgs) Handles btn_manager.Click
        Try
            If txt_pass.Text = "" Then
                MsgBox("يرجى كتابة كلمة المرور")
                Exit Sub
            End If
            If txt_user.Text = "" Then
                MsgBox("يرجى كتابة اسم المستخدم ")
                Exit Sub
            End If
            cn.Open(connect)
            rs.CursorLocation = CursorLocationEnum.adUseClient
            rs.Open("select * from general_manager where user_name='" + txt_user.Text + "' and password='" + txt_pass.Text + "'",
                    cn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
            If rs.EOF Or rs.BOF Then
                notfound.Show()
                cn.Close()
            Else
                main.Show()
                main.lbl_user.Text = txt_user.Text
                cn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_branch_manager_Click(sender As Object, e As EventArgs) Handles btn_branch_manager.Click
        Try
            If txt_pass.Text = "" Then
                MsgBox("يرجى كتابة كلمة المرور")
                Exit Sub
            End If
            If txt_user.Text = "" Then
                MsgBox("يرجى كتابة اسم المستخدم ")
                Exit Sub
            End If
            cn.Open(connect)
            rs.CursorLocation = CursorLocationEnum.adUseClient
            rs.Open("select * from branch_manager where user_name='" + txt_user.Text + "' and password='" + txt_pass.Text + "'",
                    cn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
            If rs.EOF Or rs.BOF Then
                notfound.Show()
                cn.Close()
            Else
                main.Show()
                main.lbl_user.Text = txt_user.Text
                cn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btn_emp_Click(sender As Object, e As EventArgs) Handles btn_emp.Click
        Try
            If txt_pass.Text = "" Then
                MsgBox("يرجى كتابة كلمة المرور")
                Exit Sub
            End If
            If txt_user.Text = "" Then
                MsgBox("يرجى كتابة اسم المستخدم ")
                Exit Sub
            End If
            cn.Open(connect)
            rs.CursorLocation = CursorLocationEnum.adUseClient
            rs.Open("select * from employees where user_name='" + txt_user.Text + "' and password='" + txt_pass.Text + "'",
                    cn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockOptimistic)
            If rs.EOF Or rs.BOF Then
                notfound.Show()
                cn.Close()
            Else
                main.Show()
                main.lbl_user.Text = txt_user.Text
                cn.Close()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub chk_lib_manager_CheckStateChanged(sender As Object, e As EventArgs) Handles chk_lib_manager.CheckStateChanged
        If chk_lib_manager.Checked = True Then
            btn_manager.Visible = True
            btn_branch_manager.Visible = False
            btn_emp.Visible = False
        Else
            btn_manager.Visible = False
            btn_branch_manager.Visible = False
            btn_emp.Visible = False
        End If
    End Sub

    Private Sub chk_branch_CheckStateChanged(sender As Object, e As EventArgs) Handles chk_branch.CheckStateChanged
        If chk_branch.Checked = True Then
            btn_manager.Visible = False
            btn_branch_manager.Visible = True
            btn_emp.Visible = False
        Else
            btn_manager.Visible = False
            btn_branch_manager.Visible = False
            btn_emp.Visible = False
        End If
    End Sub

    Private Sub chk_emp_CheckStateChanged(sender As Object, e As EventArgs) Handles chk_emp.CheckStateChanged
        If chk_emp.Checked = True Then
            btn_manager.Visible = False
            btn_branch_manager.Visible = False
            btn_emp.Visible = True
        Else
            btn_manager.Visible = False
            btn_branch_manager.Visible = False
            btn_emp.Visible = False
        End If
    End Sub

End Class