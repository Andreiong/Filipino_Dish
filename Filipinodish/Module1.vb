Imports MySql.Data.MySqlClient
Module Module1
    Public con As New MySqlConnection
    Public cmd As New MySqlCommand
    Public read As MySqlDataReader

    Sub connection()
        con = New MySqlConnection
        With con
            .ConnectionString = "server=localhost;user id=root;password=;database= filipinodish"
        End With
    End Sub
End Module
