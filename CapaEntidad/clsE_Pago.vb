Public Class clsE_Pago
    Private IdPago
    Private Monto
    Private IdApoderado
    Private IdReservaMatricula
    Private Fecha
    Public Property _IdPago As Integer
        Get
            Return IdPago
        End Get
        Set(value As Integer)
            IdPago = value
        End Set
    End Property
    Public Property _Monto As Double
        Get
            Return Monto
        End Get
        Set(value As Double)
            Monto = value
        End Set
    End Property
    Public Property _IdApoderado As Integer
        Get
            Return IdApoderado
        End Get
        Set(value As Integer)
            IdApoderado = value
        End Set
    End Property
    Public Property _IdReservaMatricula As Integer
        Get
            Return IdReservaMatricula
        End Get
        Set(value As Integer)
            IdReservaMatricula = value
        End Set
    End Property
    Public Property _Fecha As Date
        Get
            Return Fecha
        End Get
        Set(value As Date)
            Fecha = value
        End Set
    End Property
End Class
