Imports System.IO

Public Class Product
    Public con As New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Luis\Documents\Filipinodish.accdb")
    Public cmd As New OleDb.OleDbCommand
    Public read As OleDb.OleDbDataReader

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        Me.Dispose()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        With Category
            .ShowDialog()
        End With
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Using ofd As New OpenFileDialog With {.Filter = "(Image.Files)|*.jpg;*.png|Jpg,|*.jpg|Png,|*.png", .Multiselect = False, .Title = "Select Image"}

            If ofd.ShowDialog = 1 Then
                PictureBox1.BackgroundImage = Image.FromFile(ofd.FileName)
            End If
        End Using
    End Sub

    Sub Loadcategory()
        cboCategory.Items.Clear()
        con.Open()
        cmd = New OleDb.OleDbCommand("SELECT * FROM tblcategory", con)
        read = cmd.ExecuteReader()
        While read.Read
            cboCategory.Items.Add(read.Item("category").ToString)
        End While
        read.Close()
        con.Close()

    End Sub

    Private Sub btnadd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnadd.Click
        Try
            If MsgBox("Add this record?", vbYesNo + vbQuestion) = vbYes Then
                Dim msstream As New MemoryStream
                PictureBox1.BackgroundImage.Save(msstream, System.Drawing.Imaging.ImageFormat.Jpeg)
                Dim arrImage() As Byte = msstream.GetBuffer

                con.Open()
                cmd.Connection = con
                cmd = New OleDb.OleDbCommand("INSERT INTO filipinodish (Item,Price,Category,Image) values(@Item,@Price,@Category,@Image)", con)
                With cmd.Parameters
                    .AddWithValue("@Item", txtProduct.Text)
                    .AddWithValue("@Price", txtPrice.Text)
                    .AddWithValue("@Category", cboCategory.Text)
                    .AddWithValue("@Image", arrImage)
                End With
                cmd.ExecuteNonQuery()
                con.Close()
                MsgBox("Record has been saved", vbInformation)
            End If
        Catch ex As Exception
            con.Close()
            MsgBox(ex.Message, vbCritical)
        End Try
    End Sub
End Class