Public Class Form1

    Private Sub S1()
        lblText1.Text = "Hello"
    End Sub
    Private Sub btnSubmit1_Click(sender As Object, e As EventArgs) Handles btnSubmit1.Click
        S1()
    End Sub

    Private Sub S2()
        Dim strText As String
        strText = txtBox1.Text
        lblText2.Text = strText
    End Sub
    Private Sub btnSubmit2_Click(sender As Object, e As EventArgs) Handles btnSubmit2.Click
        S2()
    End Sub

    Private Function S3()
        Return "Hello"
    End Function
    Private Sub btnSubmit3_Click(sender As Object, e As EventArgs) Handles btnSubmit3.Click
        lblText3.Text = S3()
    End Sub

    Private Function S4()
        Dim strText2 As String
        strText2 = txtBox2.Text
        Return strText2
    End Function
    Private Sub btnSubmit4_Click(sender As Object, e As EventArgs) Handles btnSubmit4.Click
        lblText4.Text=S4()
    End Sub
End Class
