Public Class clsE_DetalleMatricula
    Private idDetalleMatricula
    Private IdMatricula
    Private IdDocumento

    Public Property _idDetalleMatricula As Integer
        Get
            Return idDetalleMatricula
        End Get
        Set(value As Integer)
            idDetalleMatricula = value
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
    Public Property _IdDocumento As Integer
        Get
            Return IdDocumento
        End Get
        Set(value As Integer)
            IdDocumento = value
        End Set
    End Property
End Class
