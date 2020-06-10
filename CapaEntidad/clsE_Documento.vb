Public Class clsE_Documento
    Private IdDocumento
    Private IdAlumno
    Private IdGrado
    Private IdSeccion
    Private IdAnioEscolar

    Public Property _IdDocumento As Integer
        Get
            Return IdDocumento
        End Get
        Set(value As Integer)
            IdDocumento = value
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
    Public Property _IdGrado As Integer
        Get
            Return IdGrado
        End Get
        Set(value As Integer)
            IdGrado = value
        End Set
    End Property
    Public Property _IdSeccion As Integer
        Get
            Return IdSeccion
        End Get
        Set(value As Integer)
            IdSeccion = value
        End Set
    End Property
    Public Property _IdAnioEscolar As Integer
        Get
            Return IdAnioEscolar
        End Get
        Set(value As Integer)
            IdAnioEscolar = value
        End Set
    End Property
End Class
