Public Class clsE_Especialidad
    Private IdEspecialidad
    Private Especialidad

    Public Property _IdEspecialidad As Integer
        Get
            Return IdEspecialidad
        End Get
        Set(value As Integer)
            IdEspecialidad = value
        End Set
    End Property
    Public Property _Especialidad As String
        Get
            Return Especialidad
        End Get
        Set(value As String)
            Especialidad = value
        End Set
    End Property
End Class
