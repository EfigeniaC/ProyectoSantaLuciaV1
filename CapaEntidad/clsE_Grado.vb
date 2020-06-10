Public Class clsE_Grado
    Private IdGrado
    Private Grado
    Private IdTurno
    Public Property _IdGrado As Integer
        Get
            Return IdGrado
        End Get
        Set(value As Integer)
            IdGrado = value
        End Set
    End Property
    Public Property _Grado As Integer
        Get
            Return Grado
        End Get
        Set(value As Integer)
            Grado = value
        End Set
    End Property
    Public Property _IdTurno As Integer
        Get
            Return IdTurno
        End Get
        Set(value As Integer)
            IdTurno = value
        End Set
    End Property
End Class
