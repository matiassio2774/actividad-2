Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Show()

        Dim parar As Integer

        Do While parar < 1000000

            Me.Label1.Text = parar.ToString()

            parar = parar + 1

        Loop
        Form2.Show()
    End Sub
End Class
