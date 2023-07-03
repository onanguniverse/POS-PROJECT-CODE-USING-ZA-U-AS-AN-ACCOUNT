Imports System.Data.SqlClient

Public Class Form2

    Dim connection As New SqlConnection("Server=DESKTOP-MLUEKGP\SQLEXPRESS; Database = project; Integrated Security = true")

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim command As New SqlCommand("insert into Users(Fname, Lname, age) values(@fn,@ln,@age)", connection)

        command.Parameters.Add("@fn", SqlDbType.VarChar).Value = TextBox1.Text
        command.Parameters.Add("@ln", SqlDbType.VarChar).Value = TextBox2.Text
        command.Parameters.Add("@age", SqlDbType.Int).Value = TextBox3.Text

        connection.Open()
        If command.ExecuteNonQuery() = 1 Then

            MessageBox.Show("New User Added")

        Else

            MessageBox.Show("User Not Added")

        End If

        connection.Close()

    End Sub
End Class