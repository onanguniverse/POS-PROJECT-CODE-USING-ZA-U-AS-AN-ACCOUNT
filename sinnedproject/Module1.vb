Imports System.Data.SqlClient
Module Module1
    Public con As New SqlConnection
    Public cmd As New SqlCommand
    Sub opencon()
        con.ConnectionString = "Data Source=DESKTOP-MLUEKGP\SQLEXPRESS;Initial Catalog=softwaredesign;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False"
    End Sub
End Module
