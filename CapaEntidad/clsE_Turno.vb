Public Class clsE_Turno
    Private IdTurno
    Private Turno

    Public Property _IdTurno As Integer
        Get
            Return IdTurno
        End Get
        Set(value As Integer)
            IdTurno = value
        End Set
    End Property
    Public Property _Turno As String
        Get
            Return Turno
        End Get
        Set(value As String)
            Turno = value
        End Set
    End Property
End Class
