Public Class clsE_Matricula
    Private IdMatricula
    Private Fecha
    Private Estado
    Private IdDocumento
    Public Property _IdMatricula As Integer
        Get
            Return IdMatricula
        End Get
        Set(value As Integer)
            IdMatricula = value
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
    Public Property _Estado As Char
        Get
            Return Estado
        End Get
        Set(value As Char)
            Estado = value
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
