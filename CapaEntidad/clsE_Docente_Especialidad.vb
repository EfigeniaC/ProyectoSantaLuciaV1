Public Class clsE_Docente_Especialidad
    Private IdDocente
    Private IdEspecialidad
    Private IdDocenteEspecialidad

    Public Property _IdDocente As Integer
        Get
            Return IdDocente
        End Get
        Set(value As Integer)
            IdDocente = value
        End Set
    End Property
    Public Property _IdEspecialidad As Integer
        Get
            Return IdEspecialidad
        End Get
        Set(value As Integer)
            IdEspecialidad = value
        End Set
    End Property
    Public Property _IdDocenteEspecialidad As Integer
        Get
            Return IdDocenteEspecialidad
        End Get
        Set(value As Integer)
            IdDocenteEspecialidad = value
        End Set
    End Property
End Class
