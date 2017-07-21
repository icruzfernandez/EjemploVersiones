Public Class frmejemplo
    Private Sub btnmensaje_Click(sender As Object, e As EventArgs) Handles btnmensaje.Click
        If Not String.IsNullOrEmpty(txtmensaje.Text) Then
            MessageBox.Show("Mensaje ingresado por el usuario: " & txtmensaje.Text)
        Else
            MessageBox.Show("no hay mensaje que mostrar")
        End If

    End Sub
End Class