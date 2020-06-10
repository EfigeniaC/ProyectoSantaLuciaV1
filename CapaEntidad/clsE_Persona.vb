Public Class clsE_Persona
    Private IdPersona
    Private Nombre
    Private ApellidoPaterno
    Private ApellidoMaterno
    Private IdTipoDocumento
    Private NumDocumento
    Private IdTipoPersona
    Private IdTipoPersonaCargo
    Private Direccion
    Private Email
    Private Telefono
    Private FechaNacimiento

    Public Property _IdPersona As Integer
        Get
            Return IdPersona
        End Get
        Set(value As Integer)
            IdPersona = value
        End Set
    End Property
    Public Property _Nombre As String
        Get
            Return Nombre
        End Get
        Set(value As String)
            Nombre = value
        End Set
    End Property
    Public Property _ApellidoPaterno As String
        Get
            Return ApellidoPaterno
        End Get
        Set(value As String)
            ApellidoPaterno = value
        End Set
    End Property
    Public Property _ApellidoMaterno As String
        Get
            Return ApellidoMaterno
        End Get
        Set(value As String)
            ApellidoMaterno = value
        End Set
    End Property
    Public Property _IdTipoDocumento As Integer
        Get
            Return IdTipoDocumento
        End Get
        Set(value As Integer)
            IdTipoDocumento = value
        End Set
    End Property
    Public Property _NumDocumento As String
        Get
            Return NumDocumento
        End Get
        Set(value As String)
            NumDocumento = value
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
    Public Property _IdTipoPersonaCargo As Integer
        Get
            Return IdTipoPersonaCargo
        End Get
        Set(value As Integer)
            IdTipoPersonaCargo = value
        End Set
    End Property
    Public Property _Direccion As String
        Get
            Return Direccion
        End Get
        Set(value As String)
            Direccion = value
        End Set
    End Property
    Public Property _Email As String
        Get
            Return Email
        End Get
        Set(value As String)
            Email = value
        End Set
    End Property
    Public Property _Telefono As String
        Get
            Return Telefono
        End Get
        Set(value As String)
            Telefono = value
        End Set
    End Property
    Public Property _FechaNacimiento As Date
        Get
            Return FechaNacimiento
        End Get
        Set(value As Date)
            FechaNacimiento = value
        End Set
    End Property

End Class
