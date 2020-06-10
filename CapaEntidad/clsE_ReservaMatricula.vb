Public Class clsE_ReservaMatricula
    Private IdReservaMatricula
    Private Estado
    Private Costo
    Private IdMatricula
    Public Property _IdReservaMatricula As Integer
        Get
            Return IdReservaMatricula
        End Get
        Set(value As Integer)
            IdReservaMatricula = value
        End Set
    End Property
    Public Property _Estado As String
        Get
            Return Estado
        End Get
        Set(value As String)
            Estado = value
        End Set
    End Property
    Public Property _Costo As Double
        Get
            Return Costo
        End Get
        Set(value As Double)
            Costo = value
        End Set
    End Property
    Public Property _IdMatricula As Integer
        Get
            Return IdMatricula
        End Get
        Set(value As Integer)
            IdMatricula = value
        End Set
    End Property
End Class
