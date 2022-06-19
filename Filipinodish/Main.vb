Public Class Main
    Public con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Luis\Documents\Filipinodish.accdb")
    Public cmd As New OleDb.OleDbCommand

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        With Productlist
            .ShowDialog()
        End With
    End Sub
End Class
