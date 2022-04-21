Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim intSum As Integer


        If (Val(TextBox1.Text) > 0) Then
            intSum = 0
            For x = 1 To Val(TextBox1.Text)
                intSum = intSum + x

            Next x
            Label2.Text = "Summation of " & TextBox1.Text & " is " & Str(intSum) & "."
        Else
            Label2.Text = "Enter a positive integer only."

        End If
    End Sub
End Class
