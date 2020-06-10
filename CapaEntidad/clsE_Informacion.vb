Public Class clsE_Informacion
    Private IdInformacion
    Private Nombre
    Private Estado
    Private IdAlumno
    Public Property _IdInformacion As Integer
        Get
            Return IdInformacion
        End Get
        Set(value As Integer)
            IdInformacion = value
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
    Public Property _Estado As Char
        Get
            Return Estado
        End Get
        Set(value As Char)
            Estado = value
        End Set
    End Property
    Public Property _IdAlumno As Integer
        Get
            Return IdAlumno
        End Get
        Set(value As Integer)
            IdAlumno = value
        End Set
    End Property
End Class
