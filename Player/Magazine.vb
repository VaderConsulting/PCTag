Public Class Magazine

    Private m_Bullets As New Collections.SortedList

    Public Property Bullets() As Collections.SortedList
        Get
            Return m_Bullets
        End Get
        Set(ByVal value As Collections.SortedList)
            m_Bullets = value
        End Set
    End Property

End Class
