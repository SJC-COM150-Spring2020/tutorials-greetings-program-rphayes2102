Public Class Greetings
    Private Sub btnClick_Click(sender As Object, e As EventArgs) Handles btnClick.Click

        'Take value from name textbox and print in messagebox
        'MessageBox.Show(txtName.Text)


        'Take vaule from name tetxbox and print to txtOut
        txtOut.Text = "Good Evening " & txtName.Text & ControlChars.CrLf
        txtOut.Text = txtOut.Text & " How are You?"


        'Clear txtName value
        txtName.Clear()
    End Sub

    Private Sub txtOut_TextChanged(sender As Object, e As EventArgs) Handles txtOut.TextChanged

    End Sub
End Class
