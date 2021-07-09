Public Class SnakeRunTime
    Public x As Integer
    Public y As Integer
    Public moveDirection As String
    Private canChangeDirection As Boolean
    Dim rnd As System.Random = New System.Random()
    Public snakeBody As New LinkedList(Of SnakeBody)

    ' Allows creation of a snakeruntime object with a random start position and the ability to change direction
    Sub New()
        setRandomPosition()
        moveDirection = "stop"
        canChangeDirection = True
    End Sub

    ' Set a random position for the snake head to begin at
    Sub setRandomPosition()
        Dim randomX As Integer = newRandValue(1, 14) * 30
        Dim randomY As Integer = newRandValue(1, 14) * 30
        x = randomX
        y = randomY
    End Sub

    ' Draws the snakes added parts
    Sub DrawBody(ByVal G As Graphics)
        ' Places head
        G.FillRectangle(Brushes.AntiqueWhite, Me.x, Me.y, 28, 28)

        ' Draws each piece after food is eaten
        For Each Piece In snakeBody
            G.FillRectangle(Brushes.AntiqueWhite, Piece.X, Piece.Y, 28, 28)
        Next Piece
    End Sub

    ' Generates random number
    Public Function newRandValue(ByVal a As Integer, ByVal b As Integer) As Integer
        Return rnd.Next(a, b + 1)
    End Function

    ' Moves the snake automatically
    Sub Move()
        Select Case moveDirection
            Case "up"
                y = y - 30
            Case "down"
                y = y + 30
            Case "right"
                x = x + 30
            Case "left"
                x = x - 30
        End Select

        For Each Spot In snakeBody
            Select Case Spot.direction
                Case "up"
                    Spot.Y = Spot.Y - 30
                Case "down"
                    Spot.Y = Spot.Y + 30
                Case "right"
                    Spot.X = Spot.X + 30
                Case "left"
                    Spot.X = Spot.X - 30

            End Select
        Next Spot

        canChangeDirection = True
        'change directions

        ' Indicates the tail of the snake and allows it to follow the head
        Dim Tail As LinkedListNode(Of SnakeBody) = snakeBody.Last
        If Tail IsNot Nothing Then
            Do Until Tail.Previous Is Nothing
                Tail.Value.direction = Tail.Previous.Value.direction
                Tail = Tail.Previous
            Loop
        End If

        ' Indicates the head of the snake and allows it to control movement
        Dim Head As LinkedListNode(Of SnakeBody) = snakeBody.First
        If Head IsNot Nothing Then
            Head.Value.direction = moveDirection
        End If
    End Sub

    ' Subprocedure handles the ability to allow the snake to change direction
    Sub changeDirection(ByVal d As String)
        If canChangeDirection = True Then
            canChangeDirection = False
            moveDirection = d
        End If
    End Sub
End Class
