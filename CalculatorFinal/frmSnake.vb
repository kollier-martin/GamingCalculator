' Allows more control over run-time and desgin behavior
Imports System.ComponentModel

' Allows the drawing of the snake
Imports System.Drawing

Public Class frmSnake
    ' Declare class variables
    ' Dim rand As System.Random = New System.Random
    Dim Canvas As Graphics
    Dim BitmapGraphics As Graphics
    Dim Background As Bitmap
    Dim Rect As Rectangle

    Const _frmHeight = 30
    Const _frmWidth = 480
    Const _aWidth As Integer = 28
    Const _aHeight As Integer = 28

    ' Initialzie a new instance of the class SnakeRunTime
    Dim newSnake As New SnakeRunTime

    ' Declares if the game is over
    Dim isGameOver As Boolean = False

    ' Tells the user how long their snake is
    Dim snakeLength As Integer = 0

    ' Declares if the game is running or not
    Dim isRunning As Boolean = True

    ' Frames that the game runs in
    Dim maxFrameRate As Integer = 60
    Dim frameSeconds As Integer = TimeOfDay.Second
    Dim frameRate As Integer = 60

    ' Keeps up with the food position
    Dim foodHorizontal As Integer
    Dim foodVertical As Integer

    Private Sub gameTimer_Tick(sender As System.Object, e As System.EventArgs) Handles gameTimer.Tick
        ' Keeps the game running and keeps up with the time ran
        ' Frame refreshing
        If frameSeconds = TimeOfDay.Second And isRunning = True Then
            frameRate = frameRate + 1
        Else
            maxFrameRate = frameRate
            frameRate = 0
            frameSeconds = TimeOfDay.Second
        End If
    End Sub

    Private Sub GameStart()
        ' This subprocedure handles the runtime of the game

        ' Initialize Variables
        Dim autoMove As Integer = 0
        Dim lose As Boolean = False

        ' Loops while the game is running
        Do While isRunning = True
            Application.DoEvents()

            ' If the player has not died yet
            If isGameOver = False Then

                ' Create background
                InitializeBackground()

                ' Calls the sub procedure to indefinitely check collisions
                checkCollisions()

                ' When the player presses a key, this block keeps the snake running for as long as the game is running
                ' without the player losing
                autoMove = autoMove + 1
                If autoMove > (maxFrameRate / 6) Then
                    newSnake.Move()
                    autoMove = Nothing
                End If
            Else
                InitializeBackground()
                If lose = False Then
                    lose = True
                End If
            End If

            gameTimer.Interval = 45000
            gameTimer.Start()
        Loop
        Me.Close()
    End Sub

    Private Sub InitializeBackground()
        ' Draw background with nested for loop
        For x As Integer = 0 To _frmWidth Step _frmHeight
            For y As Integer = 0 To _frmWidth Step _frmHeight
                ' Draws the borders for the snake to be maintained in
                If x = 0 Or y = 0 Or x = _frmWidth Or y = _frmWidth Then
                    Canvas.FillEllipse(Brushes.IndianRed, x, y, _aWidth, _aHeight)
                Else
                    ' Draws the playing field
                    Canvas.FillRectangle(Brushes.Black, x, y, _aWidth, _aHeight)
                End If
                ' Next x,y variables fills across the form
                ' Next by itself will only fill one rectangle
            Next y
        Next x

        ' Creates a basic graphic object for the Snake
        newSnake.DrawBody(Canvas)

        ' Fills the snake with color
        Canvas.FillRectangle(Brushes.DarkSeaGreen, foodHorizontal, foodVertical, _aWidth, _aHeight)
        lblLength.Text = "Snake Length: " & snakeLength.ToString()

        ' When the game is over, display the losing labels
        If isGameOver = True Then
            lblRestartQuit.Visible = True
            lblGameOver.Visible = True
        End If

        ' Makes the canvas
        Canvas = Graphics.FromImage(Background)

        ' Places the background
        BitmapGraphics.DrawImage(Background, 0, 0, Me.Width, Me.Height)

        ' Turns canvas black
        Canvas.Clear(Color.Black)
    End Sub

    Private Sub spawnFood()
        ' This sub proecdure randomly generates and places the food for the snake to eat

        Dim bitmapLocation = newSnake.newRandValue(1, 14) * _frmHeight

        ' If snake eats the food, add it to snake and create another piece randomly
        For Each Piece In newSnake.snakeBody
            If (Piece.X = bitmapLocation And Piece.Y = bitmapLocation) Or (newSnake.x = bitmapLocation And newSnake.y = bitmapLocation) Then
                spawnFood()
                Return
            End If
        Next Piece

        ' Places food at a random location
        foodHorizontal = newSnake.newRandValue(1, 14) * _frmHeight : foodVertical = newSnake.newRandValue(1, 14) * _frmHeight

    End Sub

    Private Sub checkCollisions()
        ' This for loop detects if the head of the snake hits another part of the snake
        For Each Tail In newSnake.snakeBody
            If newSnake.x = Tail.X And newSnake.y = Tail.Y Then
                isGameOver = True
            End If
        Next Tail

        ' If the snake runs off the screen, replace it on the other side of the screen
        ' Wanted to make snake reappear on other side of the screen when it collided but that didn't happen
        If newSnake.x < 30 Or newSnake.x > 450 Or newSnake.y < 30 Or newSnake.y > 450 Then
            'For Each Snake In newSnake.snakeBody
            '    Snake.X = 30 * 15
            '    Snake.Y = 30 * 15
            'Next Snake

            isGameOver = True
        End If

        ' Checks if the snake head runs into the food
        If newSnake.x = foodHorizontal And newSnake.y = foodVertical Then
            snakeLength = snakeLength + 1

            ' Spawns food at random position
            spawnFood()

            Dim newBodyX As Integer
            Dim newBoydY As Integer
            Dim lastBodyX As Integer = newSnake.x
            Dim lastBodyY As Integer = newSnake.y
            Dim lastDirection As String = newSnake.moveDirection

            ' If the snake has more than one part to it
            If newSnake.snakeBody.Count > 0 Then
                ' Set variables to last position and direction of the snake
                lastBodyX = newSnake.snakeBody.Last.Value.X
                lastBodyY = newSnake.snakeBody.Last.Value.Y
                lastDirection = newSnake.snakeBody.Last.Value.direction
            End If

            ' Maintains the last direction the user was going
            Select Case lastDirection
                Case "up"
                    newBodyX = lastBodyX
                    newBoydY = lastBodyY + _frmHeight
                Case "down"
                    newBodyX = lastBodyX
                    newBoydY = lastBodyY - _frmHeight
                Case "left"
                    newBodyX = lastBodyX + _frmHeight
                    newBoydY = lastBodyY
                Case "right"
                    newBodyX = lastBodyX - _frmHeight
                    newBoydY = lastBodyY

            End Select

            ' Adds new piece to snake
            Dim block As New SnakeBody(lastDirection, newBodyX, newBoydY)
            newSnake.snakeBody.AddLast(block)

        End If
    End Sub

    Private Sub frmSnake_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' This event handler reads the input from the keyboard to change the direction of the snake
        ' The user can not go backwards
        Select Case e.KeyCode
            Case Keys.Up
                If newSnake.moveDirection <> "down" Then
                    newSnake.changeDirection("up")
                End If

            Case Keys.Down
                If newSnake.moveDirection <> "up" Then
                    newSnake.changeDirection("down")
                End If

            Case Keys.Left
                If newSnake.moveDirection <> "right" Then
                    newSnake.changeDirection("left")
                End If

            Case Keys.Right
                If newSnake.moveDirection <> "left" Then
                    newSnake.changeDirection("right")
                End If

            Case Keys.E
                restartGame()
            Case Keys.Escape
                isRunning = False
                Me.Hide()
                Me.Refresh()

                Dim frmGameReturn As New frmGameSelect
                frmGameReturn.Show()
        End Select
    End Sub

    Private Sub restartGame()
        ' Puts the snake in a stop position and resets the game
        newSnake.moveDirection = "stop"
        newSnake.snakeBody.Clear()
        newSnake.setRandomPosition()

        ' Hides losing labels
        lblGameOver.Visible = False
        lblRestartQuit.Visible = False

        ' Resets lose condition
        isGameOver = False
    End Sub

    Private Sub frmSnake_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' This handler allows the user to see the form and interact with it
        Me.Show()
        Me.Focus()

        ' Enables the use of the keypad for entry
        Me.KeyPreview = True

        ' Creates the graphics for the game
        Canvas = Me.CreateGraphics
        BitmapGraphics = Me.CreateGraphics
        Background = New Bitmap(Me.Width, Me.Height)

        ' Hides losing labels
        lblGameOver.Visible = False
        lblRestartQuit.Visible = False

        ' Spawns the food
        spawnFood()

        ' Starts the game
        GameStart()
    End Sub


    Private Sub frmSnake_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        ' When form is closed the memory is dumped, removing the graphics drawn
        Canvas.Dispose()
        BitmapGraphics.Dispose()
        Background.Dispose()
    End Sub

    Private Sub frmSnake_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        ' If the user decides to close the game while running
        If isRunning = True Then
            isRunning = False
            e.Cancel = True
        End If
    End Sub
End Class