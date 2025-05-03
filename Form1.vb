Imports MySql.Data.MySqlClient

Public Class Form1
    Dim conn As MySqlConnection
    Dim cmd As MySqlCommand
    Dim connString As String = "server=localhost;user id=root;password=;database=student_db;"

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dtADD.Value = Now
        dtBIRTH.Value = Now
    End Sub

    Private Sub btnSUB_Click(sender As Object, e As EventArgs) Handles btnSUB.Click

        If txtLNAME.Text = "" Or txtFNAME.Text = "" Or txtMNAME.Text = "" Or cboYEAR.SelectedIndex = -1 Or
           txtCN.Text = "" Or txtSTREET.Text = "" Or txtBRGY.Text = "" Or txtMUNI.Text = "" Or
           txtPROV.Text = "" Or txtZIP.Text = "" Or txtGNAME.Text = "" Or txtGFNAME.Text = "" Or
           txtGMNAME.Text = "" Or txtOCC.Text = "" Or txtGNUM.Text = "" Then

            MessageBox.Show("Please fill in all fields before submitting.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        Else

            Try
                conn = New MySqlConnection(connString)
                conn.Open()
                Dim query As String = "INSERT INTO students (lname, fname, mname, year_level, course, date_added, birthdate, contact_no, street, brgy, municipality, province, zip_code, g_lname, g_fname, g_mname, g_occupation, g_contact) " &
                      "VALUES (@lname, @fname, @mname, @year, @course, @add, @birth, @cn, @street, @brgy, @muni, @prov, @zip, @glname, @gfname, @gmname, @occ, @gnum)"

                cmd = New MySqlCommand(query, conn)

                cmd.Parameters.AddWithValue("@lname", txtLNAME.Text)
                cmd.Parameters.AddWithValue("@fname", txtFNAME.Text)
                cmd.Parameters.AddWithValue("@mname", txtMNAME.Text)
                cmd.Parameters.AddWithValue("@year", cboYEAR.Text)
                cmd.Parameters.AddWithValue("@add", dtADD.Value)
                cmd.Parameters.AddWithValue("@birth", dtBIRTH.Value)
                cmd.Parameters.AddWithValue("@cn", txtCN.Text)
                cmd.Parameters.AddWithValue("@street", txtSTREET.Text)
                cmd.Parameters.AddWithValue("@brgy", txtBRGY.Text)
                cmd.Parameters.AddWithValue("@muni", txtMUNI.Text)
                cmd.Parameters.AddWithValue("@prov", txtPROV.Text)
                cmd.Parameters.AddWithValue("@zip", txtZIP.Text)
                cmd.Parameters.AddWithValue("@glname", txtGNAME.Text)
                cmd.Parameters.AddWithValue("@gfname", txtGFNAME.Text)
                cmd.Parameters.AddWithValue("@gmname", txtGMNAME.Text)
                cmd.Parameters.AddWithValue("@occ", txtOCC.Text)
                cmd.Parameters.AddWithValue("@gnum", txtGNUM.Text)
                cmd.Parameters.AddWithValue("@course", cboCOURSE.Text)


                cmd.ExecuteNonQuery()


                MessageBox.Show("Student record saved successfully!")

                ClearFields()

                conn.Close()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message)
            End Try
        End If
    End Sub


    Private Sub ClearFields()
        txtLNAME.Clear()
        txtFNAME.Clear()
        txtMNAME.Clear()
        cboYEAR.SelectedIndex = -1
        dtADD.Value = Now
        dtBIRTH.Value = Now
        txtCN.Clear()
        txtSTREET.Clear()
        txtBRGY.Clear()
        txtMUNI.Clear()
        txtPROV.Clear()
        txtZIP.Clear()
        txtGNAME.Clear()
        txtGFNAME.Clear()
        txtGMNAME.Clear()
        txtOCC.Clear()
        txtGNUM.Clear()
    End Sub

    Private Sub btnCL_Click(sender As Object, e As EventArgs) Handles btnCL.Click

        ClearFields()
    End Sub

    Private Sub btnDEL_Click(sender As Object, e As EventArgs) Handles btnDEL.Click
        Dim lname = InputBox("Enter last name of student to delete:")
        Try
            conn = New MySqlConnection(connString)
            conn.Open()
            Dim query As String = "DELETE FROM students WHERE lname = @lname"
            cmd = New MySqlCommand(query, conn)
            cmd.Parameters.AddWithValue("@lname", lname)

            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Student record deleted.")
            Else
                MessageBox.Show("No student found with that last name.")
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnUP_Click(sender As Object, e As EventArgs) Handles btnUP.Click
        Dim lname = InputBox("Enter last name of student to update:")
        Try
            conn = New MySqlConnection(connString)
            conn.Open()
            Dim query As String = "UPDATE students SET fname=@fname, mname=@mname, year_level=@year, birthdate=@birth, contact_no=@cn WHERE lname=@lname"
            cmd = New MySqlCommand(query, conn)

            cmd.Parameters.AddWithValue("@fname", txtFNAME.Text)
            cmd.Parameters.AddWithValue("@mname", txtMNAME.Text)
            cmd.Parameters.AddWithValue("@year", cboYEAR.Text)
            cmd.Parameters.AddWithValue("@birth", dtBIRTH.Value)
            cmd.Parameters.AddWithValue("@cn", txtCN.Text)
            cmd.Parameters.AddWithValue("@lname", lname)

            If cmd.ExecuteNonQuery() > 0 Then
                MessageBox.Show("Student record updated.")
            Else
                MessageBox.Show("No record found with that last name.")
            End If
            conn.Close()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message)
        End Try
    End Sub

    Private Sub btnEX_Click(sender As Object, e As EventArgs) Handles btnEX.Click
        Dim result = MessageBox.Show("Are you Sure to Exit?", "Confirm", MessageBoxButtons.YesNo)
        If result = DialogResult.Yes Then
            Application.Exit()
        End If
    End Sub

    Private Sub cboYEAR_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboYEAR.SelectedIndexChanged
    End Sub
    Private Sub txtCN_TextChanged(sender As Object, e As EventArgs) Handles txtCN.TextChanged

    End Sub

    Private Sub txtFNAME_TextChanged(sender As Object, e As EventArgs) Handles txtFNAME.TextChanged

    End Sub

    Private Sub txtSTREET_TextChanged(sender As Object, e As EventArgs) Handles txtSTREET.TextChanged

    End Sub

    Private Sub txtZIP_TextChanged(sender As Object, e As EventArgs) Handles txtZIP.TextChanged

    End Sub

    Private Sub txtGNUM_TextChanged(sender As Object, e As EventArgs) Handles txtGNUM.TextChanged

    End Sub

    Private Sub txtOCC_TextChanged(sender As Object, e As EventArgs) Handles txtOCC.TextChanged

    End Sub

    Private Sub cboCOURSE_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboCOURSE.SelectedIndexChanged

    End Sub


End Class
