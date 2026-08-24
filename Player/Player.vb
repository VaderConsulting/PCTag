Public Class Player

    Private m_Health As Integer = 100
    Private m_Name As String = "Player"

    Public Property Health() As Integer
        Get
            Return m_Health
        End Get
        Set(ByVal value As Integer)
            m_Health = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return m_Name
        End Get
        Set(ByVal value As String)
            m_Name = value
        End Set
    End Property

End Class
