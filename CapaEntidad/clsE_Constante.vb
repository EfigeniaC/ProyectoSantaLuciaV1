Public Class clsE_Constante
    Private IdConstante
    Private NombreConstante
    Private Categoria

    Public Property _IdConstante As Integer
        Get
            Return IdConstante
        End Get
        Set(value As Integer)
            IdConstante = value
        End Set
    End Property
    Public Property _NombreConstante As String
        Get
            Return NombreConstante
        End Get
        Set(value As String)
            NombreConstante = value
        End Set
    End Property
    Public Property _Categoria As String
        Get
            Return Categoria
        End Get
        Set(value As String)
            Categoria = value
        End Set
    End Property

End Class
