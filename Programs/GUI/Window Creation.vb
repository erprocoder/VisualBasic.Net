Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim newForm As New Form

        newForm.Text = "It's a new window"
        newForm.Show()

    End Sub
End Class