Public Class FormAccueil
    Private Sub FormAccueil_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Acceuil"

        For i As Integer = 0 To 15
            create_button(i)
        Next
    End Sub


    Private Sub create_button(i As Integer)
        Dim b As New Button
        b.Name = i
        b.Text = "Test " & i
        b.Location = New Point(10 * (i / 5), (i / 10) * b.Height + 10)
        b.Width = 200

        AddHandler b.Click, AddressOf Case_Click

        Controls.Add(b)
    End Sub

    Private Sub Case_Click(sender As Object, e As EventArgs)
        Console.WriteLine(Convert.ToInt32(sender.Name))
    End Sub
End Class
