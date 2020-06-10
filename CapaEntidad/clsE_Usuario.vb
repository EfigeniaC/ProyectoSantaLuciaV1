Public Class clsE_Usuario
    Private IdUsuario
    Private Usuario
    Private Contrasenia
    Private IdTipoPersona
    Private IdPersona

    Public Property _IdUsuario As Integer
        Get
            Return IdUsuario
        End Get
        Set(value As Integer)
            IdUsuario = value
        End Set
    End Property
    Public Property _Usuario As String
        Get
            Return Usuario
        End Get
        Set(value As String)
            Usuario = value
        End Set
    End Property
    Public Property _Contrasenia As String
        Get
            Return Contrasenia
        End Get
        Set(value As String)
            Contrasenia = value
        End Set
    End Property
    Public Property _IdTipoPersona As Integer
        Get
            Return IdTipoPersona
        End Get
        Set(value As Integer)
            IdTipoPersona = value
        End Set
    End Property
    Public Property _IdPersona As Integer
        Get
            Return IdPersona
        End Get
        Set(value As Integer)
            IdPersona = value
        End Set
    End Property
End Class
