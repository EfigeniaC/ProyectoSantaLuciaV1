Public Class clsE_Seccion
    Private IdSeccion
    Private Seccion
    Public Property _IdSeccion As Integer
        Get
            Return IdSeccion
        End Get
        Set(value As Integer)
            IdSeccion = value
        End Set
    End Property
    Public Property _Seccion As Char
        Get
            Return Seccion
        End Get
        Set(value As Char)
            Seccion = value
        End Set
    End Property
End Class
