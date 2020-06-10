Public Class clsE_Asignatura
    Private IdAsignatura
    Private NombreAsignatura

    Public Property _IdAsignatura As Integer
        Get
            Return IdAsignatura
        End Get
        Set(value As Integer)
            IdAsignatura = value
        End Set
    End Property
    Public Property _NombreAsignatura As String
        Get
            Return NombreAsignatura
        End Get
        Set(value As String)
            NombreAsignatura = value
        End Set
    End Property
End Class
