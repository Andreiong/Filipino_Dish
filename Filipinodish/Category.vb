Public Class Category
    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Dispose()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Try
            connection()
            If MsgBox("Do you want to add this category?", vbYesNo + vbQuestion) = vbYes Then
                con.Open()
                cmd.Connection = con
                cmd = New OleDb.OleDbCommand("INSERT INTO tblcategory (category)values(@category)", con)
                cmd.Parameters.AddWithValue("@category", TxtCategory.Text)
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Category has been saved", vbInformation)
                TxtCategory.Clear()
                TxtCategory.Focus()
                With Product
                    .Loadcategory()
                End With
            End If
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class