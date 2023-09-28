Public Class main
    Private Sub btn_min_Click(sender As Object, e As EventArgs) Handles btn_min.Click
        GroupBox1.Visible = False
        GroupBox2.Visible = False
        GroupBox3.Visible = False
        GroupBox4.Visible = False
        GroupBox5.Visible = False
        GroupBox6.Visible = False
        GroupBox7.Visible = False
        GroupBox8.Visible = False
        GroupBox9.Visible = False
        GroupBox10.Visible = False
    End Sub

    Private Sub btn_max_Click(sender As Object, e As EventArgs) Handles btn_max.Click
        GroupBox1.Visible = True
        GroupBox2.Visible = True
        GroupBox3.Visible = True
        GroupBox4.Visible = True
        GroupBox5.Visible = True
        GroupBox6.Visible = True
        GroupBox9.Visible = True
        GroupBox10.Visible = True
    End Sub

    Private Sub open_1_Click(sender As Object, e As EventArgs) Handles open_1.Click
        btn_1_1.Visible = True
        btn_1_2.Visible = True
        btn_1_3.Visible = True
        btn_1_4.Visible = True
        btn_1_5.Visible = True
    End Sub

    Private Sub close_1_Click(sender As Object, e As EventArgs) Handles close_1.Click
        btn_1_1.Visible = False
        btn_1_2.Visible = False
        btn_1_3.Visible = False
        btn_1_4.Visible = False
        btn_1_5.Visible = False
    End Sub

    Private Sub btn_background_Click(sender As Object, e As EventArgs) Handles btn_background.Click

        OpenFileDialog1.ShowDialog()
        Me.BackgroundImage = Image.FromFile(OpenFileDialog1.FileName)
        Me.BackgroundImageLayout = ImageLayout.Stretch

    End Sub

    Private Sub btn_color_Click(sender As Object, e As EventArgs) Handles btn_color.Click
        ColorDialog1.ShowDialog()
        Me.BackColor = ColorDialog1.Color
    End Sub

    Private Sub btn_back_close_Click(sender As Object, e As EventArgs) Handles btn_back_close.Click
        BackgroundImage = Nothing
    End Sub

    Private Sub main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim iwidth As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim iheight As Integer = Screen.PrimaryScreen.Bounds.Height
        Me.Width = Width
        Me.Height = Height
        Me.Location = New System.Drawing.Point(0, 0)
        lbl_date.Text = Now.Date.ToString()
    End Sub

    Private Sub btn_1_1_Click(sender As Object, e As EventArgs) Handles btn_1_1.Click

        employees_administration.Show()

    End Sub

    Private Sub btn_1_2_Click(sender As Object, e As EventArgs) Handles btn_1_2.Click

        absence.Show()

    End Sub

    Private Sub btn_1_3_Click(sender As Object, e As EventArgs) Handles btn_1_3.Click

        attendance.Show()

    End Sub

    Private Sub btn_1_4_Click(sender As Object, e As EventArgs) Handles btn_1_4.Click

        accounts.Show()
    End Sub

    Private Sub btn_2_1_Click(sender As Object, e As EventArgs) Handles btn_2_1.Click

        add_library.Show()

    End Sub

    Private Sub btn_2_2_Click(sender As Object, e As EventArgs) Handles btn_2_2.Click

        sendig_books_library.Show()

    End Sub

    Private Sub btn_3_1_Click(sender As Object, e As EventArgs) Handles btn_3_1.Click

        books_add.Show()
    End Sub

    Private Sub btn_3_2_Click(sender As Object, e As EventArgs) Handles btn_3_2.Click

        bookscopy_add.Show()
    End Sub

    Private Sub btn_3_3_Click(sender As Object, e As EventArgs) Handles btn_3_3.Click
        full_books_add.Show()
    End Sub

    Private Sub btn_3_4_Click(sender As Object, e As EventArgs) Handles btn_3_4.Click
        messages_add.Show()
    End Sub

    Private Sub btn_3_5_Click(sender As Object, e As EventArgs) Handles btn_3_5.Click

        researchs_add.Show()
    End Sub

    Private Sub btn_4_1_Click(sender As Object, e As EventArgs) Handles btn_4_1.Click
        internal_metaphor.Show()
    End Sub

    Private Sub btn_4_2_Click(sender As Object, e As EventArgs) Handles btn_4_2.Click
        forigen_metaphor.Show()
    End Sub

    Private Sub btn_4_3_Click(sender As Object, e As EventArgs) Handles btn_4_3.Click

        return_books.Show()
    End Sub

    Private Sub btn_4_4_Click(sender As Object, e As EventArgs) Handles btn_4_4.Click

        return_metaphor_books.Show()
    End Sub

    Private Sub btn_4_5_Click(sender As Object, e As EventArgs) Handles btn_4_5.Click
        lost_books.Show()
    End Sub

    Private Sub btn_5_1_Click(sender As Object, e As EventArgs) Handles btn_5_1.Click
        order_books_num.Show()
    End Sub

    Private Sub btn_5_2_Click(sender As Object, e As EventArgs) Handles btn_5_2.Click
        order_books_char.Show()
    End Sub

    Private Sub btn_5_3_Click(sender As Object, e As EventArgs) Handles btn_5_3.Click
        order_books_date.Show()
    End Sub

    Private Sub btn_6_1_Click(sender As Object, e As EventArgs) Handles btn_6_1.Click
        store_buy.Show()
    End Sub

    Private Sub btn_6_2_Click(sender As Object, e As EventArgs) Handles btn_6_2.Click
        store_sales.Show()
    End Sub

    Private Sub btn_6_3_Click(sender As Object, e As EventArgs) Handles btn_6_3.Click
        customers.Show()
    End Sub

    Private Sub btn_6_4_Click(sender As Object, e As EventArgs) Handles btn_6_4.Click
        vendors.Show()
    End Sub

    Private Sub btn_7_1_Click(sender As Object, e As EventArgs) Handles btn_7_1.Click
        month_inventory.Show()
    End Sub

    Private Sub btn_7_2_Click(sender As Object, e As EventArgs) Handles btn_7_2.Click
        year_inventory.Show()
    End Sub

    Private Sub btn_8_1_Click(sender As Object, e As EventArgs) Handles btn_8_1.Click
        academic_booking_form.Show()
    End Sub

    Private Sub btn_8_2_Click(sender As Object, e As EventArgs) Handles btn_8_2.Click
        reserve_group_book.Show()
    End Sub

    Private Sub close_2_Click(sender As Object, e As EventArgs) Handles close_2.Click
        btn_2_1.Visible = False
        btn_2_2.Visible = False
        btn_2_3.Visible = False
    End Sub

    Private Sub open_2_Click(sender As Object, e As EventArgs) Handles open_2.Click
        btn_2_1.Visible = True
        btn_2_2.Visible = True
        btn_2_3.Visible = True
    End Sub

    Private Sub btn_2_3_Click(sender As Object, e As EventArgs) Handles btn_2_3.Click
        books_sending_binding.Show()
    End Sub

    Private Sub close_3_Click(sender As Object, e As EventArgs) Handles close_3.Click
        btn_3_1.Visible = False
        btn_3_2.Visible = False
        btn_3_3.Visible = False
        btn_3_4.Visible = False
        btn_3_5.Visible = False
    End Sub

    Private Sub open_3_Click(sender As Object, e As EventArgs) Handles open_3.Click
        btn_3_1.Visible = True
        btn_3_2.Visible = True
        btn_3_3.Visible = True
        btn_3_4.Visible = True
        btn_3_5.Visible = True
    End Sub

    Private Sub close_4_Click(sender As Object, e As EventArgs) Handles close_4.Click
        btn_4_1.Visible = False
        btn_4_2.Visible = False
        btn_4_3.Visible = False
        btn_4_4.Visible = False
        btn_4_5.Visible = False
    End Sub

    Private Sub open_4_Click(sender As Object, e As EventArgs) Handles open_4.Click
        btn_4_1.Visible = True
        btn_4_2.Visible = True
        btn_4_3.Visible = True
        btn_4_4.Visible = True
        btn_4_5.Visible = True
    End Sub

    Private Sub close_5_Click(sender As Object, e As EventArgs) Handles close_5.Click
        btn_5_1.Visible = False
        btn_5_2.Visible = False
        btn_5_3.Visible = False
    End Sub

    Private Sub open_5_Click(sender As Object, e As EventArgs) Handles open_5.Click
        btn_5_1.Visible = True
        btn_5_2.Visible = True
        btn_5_3.Visible = True
    End Sub

    Private Sub close_6_Click(sender As Object, e As EventArgs) Handles close_6.Click
        btn_6_1.Visible = False
        btn_6_2.Visible = False
        btn_6_3.Visible = False
        btn_6_4.Visible = False
    End Sub

    Private Sub open_6_Click(sender As Object, e As EventArgs) Handles open_6.Click
        btn_6_1.Visible = True
        btn_6_2.Visible = True
        btn_6_3.Visible = True
        btn_6_4.Visible = True
    End Sub

    Private Sub close_7_Click(sender As Object, e As EventArgs) Handles close_7.Click
        btn_7_1.Visible = False
        btn_7_2.Visible = False
    End Sub

    Private Sub open_7_Click(sender As Object, e As EventArgs) Handles open_7.Click
        btn_7_1.Visible = True
        btn_7_2.Visible = True
    End Sub

    Private Sub close_8_Click(sender As Object, e As EventArgs) Handles close_8.Click
        btn_8_1.Visible = False
        btn_8_2.Visible = False
    End Sub

    Private Sub open_8_Click(sender As Object, e As EventArgs) Handles open_8.Click
        btn_8_1.Visible = True
        btn_8_2.Visible = True
    End Sub

    Private Sub close_9_Click(sender As Object, e As EventArgs) Handles close_9.Click
        btn_9_1.Visible = False
    End Sub

    Private Sub open_9_Click(sender As Object, e As EventArgs) Handles open_9.Click
        btn_9_1.Visible = True
    End Sub

    Private Sub btn_9_1_Click(sender As Object, e As EventArgs) Handles btn_9_1.Click
        system_administration.Show()
    End Sub

    Private Sub close_10_Click(sender As Object, e As EventArgs) Handles close_10.Click
        btn_10_1.Visible = False
        btn_10_2.Visible = False
        btn_10_3.Visible = False
        btn_10_4.Visible = False
        btn_10_5.Visible = False
        btn_10_6.Visible = False
    End Sub

    Private Sub open_10_Click(sender As Object, e As EventArgs) Handles open_10.Click
        btn_10_1.Visible = True
        btn_10_2.Visible = True
        btn_10_3.Visible = True
        btn_10_4.Visible = True
        btn_10_5.Visible = True
        btn_10_6.Visible = True
    End Sub

    Private Sub btn_10_1_Click(sender As Object, e As EventArgs) Handles btn_10_1.Click
        academic_booking.Show()
    End Sub

    Private Sub btn_10_2_Click(sender As Object, e As EventArgs) Handles btn_10_2.Click
        library_branches.Show()
    End Sub

    Private Sub btn_10_3_Click(sender As Object, e As EventArgs) Handles btn_10_3.Click
        books_report.Show()
    End Sub

    Private Sub btn_10_4_Click(sender As Object, e As EventArgs) Handles btn_10_4.Click
        emp_admin.Show()
    End Sub

    Private Sub btn_1_5_Click(sender As Object, e As EventArgs) Handles btn_1_5.Click

        all_absence_employees.Show()

    End Sub

    Private Sub btn_10_6_Click(sender As Object, e As EventArgs) Handles btn_10_6.Click
        vendors_report.Show()

    End Sub

    Private Sub btn_10_5_Click(sender As Object, e As EventArgs) Handles btn_10_5.Click
        customers_report.Show()

    End Sub

End Class