Public Class Greetings
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click
        'Print Greetings to listbox
        lstOut.Items.Add("Good Evening " & txtName.Text)
        lstOut.Items.Add("How are you? ")


        'Clear txtName value
        txtName.Clear()

    End Sub

    Private Sub txtOut_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Greetings_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        'Clear txtName value
        txtName.Clear()
        lstOut.Items.Clear()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'when user exits the program
        Beep()
        Application.Exit()
    End Sub
End Class
