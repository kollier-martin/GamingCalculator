Public Class SnakeBody
    ' Creates a snake object with a position and a direction value
    Public direction As String = "stop"
    Public X As Integer
    Public Y As Integer

    ' Subprocedure that creates an object of this class
    Sub New(ByVal d As String, ByVal x As Integer, ByVal y As Integer)
        Me.direction = d
        Me.X = x
        Me.Y = y
    End Sub
End Class
