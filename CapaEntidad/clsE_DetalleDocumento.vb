Public Class clsE_DetalleDocumento
    Private IdDetalleDocumento
    Private IdAsignatura
    Private IdDocumento
    Private IdDocente

    Public Property _IdDetalleDocumento As Integer
        Get
            Return IdDetalleDocumento
        End Get
        Set(value As Integer)
            IdDetalleDocumento = value
        End Set
    End Property
    Public Property _IdAsignatura As Integer
        Get
            Return IdAsignatura
        End Get
        Set(value As Integer)
            IdAsignatura = value
        End Set
    End Property
    Public Property _IdDocumento As Integer
        Get
            Return IdDocumento
        End Get
        Set(value As Integer)
            IdDocumento = value
        End Set
    End Property
    Public Property _IdDocente As Integer
        Get
            Return IdDocente
        End Get
        Set(value As Integer)
            IdDocente = value
        End Set
    End Property
End Class
