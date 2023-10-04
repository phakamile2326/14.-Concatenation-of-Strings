Public Class Form1
    Private Sub btnOk_Click(sender As Object, e As EventArgs) Handles btnOk.Click

        Dim Text1, Text2, Text3, Text4 As String
        Text1 = "Visual"
        Text2 = "Studio"
        Text3 = "2022"
        Text4 = (TextBox1.Text) & (TextBox2.Text) & (TextBox3.Text)
        MsgBox(Text4)



    End Sub
End Class
