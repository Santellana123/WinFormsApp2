Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim x As Contacto = New Contacto
        x.NombreProp = NOMBRE1.Text
        x.telefonoProp = NOMBRE2.Text
        x.FechaNacimientoProp = DateTime.Parse("2003/01/01")
        MsgBox(x.ToString())

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub NOMBRE1_TextChanged(sender As Object, e As EventArgs) Handles NOMBRE1.TextChanged

    End Sub
End Class
