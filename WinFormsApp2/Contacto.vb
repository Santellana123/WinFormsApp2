Public Class Contacto

    Inherits Persona
        Public telefono As String
        Public Property telefonoProp() As String
            Get
                Return telefono
            End Get
            Set(ByVal value As String)
                telefono = value
            End Set
        End Property
        Public Sub Contacto()

            telefono = String.Empty
        End Sub
        Public Overrides Function ToString() As String
            Return MyBase.ToString() + " " + telefono
        End Function

    End Class
