Imports System.Drawing
Imports System.Random
Imports System.Linq
Imports System.Data
Imports System.Comp

Public Class frmRun
    ' Frames that the game runs in
    Dim maxFrameRate As Integer = 30
    Dim frameSeconds As Integer = TimeOfDay.Second
    Dim frameRate As Integer = 30
    Dim x As Control

    ' Speeds of actions
    Dim jumpSpeed As Integer = 8
    Dim obstacleMovement As Integer = 10
    Dim score As Long = 0

    ' Obstacle Spawning
    Dim rnd As System.Random = New System.Random()

    ' Declares if the game is over
    Dim isGameOver As Boolean = False
    Dim isJumping As Boolean = False

    Public Sub StartGame()
        Reset()
    End Sub

    Public Sub Reset()
        ' Resets the game
        isJumping = False : jumpSpeed = 0
        isGameOver = False
        score = 0 : lblScore.Text = lblScore.Text & "" & score.ToString()

        picRunning.Image = PictureBox2.Image
        picRunning.Top = picFloor.Top - picRunning.Height

        Dim newPosition As Integer
        picObstacle1.Left = 640 + (picObstacle1.Left + newPosition + picObstacle2.Width * 3)
        picObstacle2.Left = 640 + (picObstacle2.Left + newPosition + picObstacle2.Width * 3)

        gameTimer.Start()
    End Sub

    Public Function CollisionUpdates() As Boolean
        For Each x In Me.Controls
            If x.Tag = "obstacle" Then
                If picRunning.Bounds.IntersectsWith(x.Bounds) Then
                    isGameOver = True
                End If
            End If
        Next
        Return isGameOver
    End Function

    Private Sub frmRun_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Handles form loading
        lblGameOver.Visible = False
        PictureBox2.Visible = False
        picDead.Visible = False
        lblScore.Visible = False

        Me.Show()
        Me.Focus()

        score = 0 : lblScore.Text += "" & score.ToString()
    End Sub

    Public Sub frmRun_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        ' Jumps if the spacebar is pressed
        Select Case True
            Case Keys.S
                lblScore.Visible = True
                StartGame()

            Case Keys.Space
                isJumping = True

            Case Keys.R
                Reset()

            Case Keys.Escape
                Me.Close()

                Dim frmGameReturn As New frmGameSelect
                frmGameReturn.Show()
        End Select
    End Sub

    Public Sub frmRun_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        ' Drops the character after spacebar is released
        Select Case True
            Case Keys.Space
                isJumping = False
        End Select
    End Sub

    Private Sub StartGame(sender As Object, e As EventArgs) Handles gameTimer.Tick
        ' Starts the Game
        picRunning.Top += jumpSpeed

        While isGameOver = False

            CollisionUpdates()

            If isJumping = True Then
                jumpSpeed = -10
            Else
                jumpSpeed = 10
            End If

            ' For each item on the form
            For Each x In Me.Controls
                If x.Tag = "obstacle" Then
                    x.Left -= obstacleMovement
                    If x.Left + x.Width < -140 Then
                        x.Left = Me.ClientSize.Width + rnd.Next(200, 800)
                        score += 1
                    End If
                End If
            Next

            If picRunning.Top >= 320 And isJumping = False Then
                picRunning.Top = picFloor.Top - picRunning.Height
                jumpSpeed = 0
            End If

            If isGameOver = True Then
                obstacleMovement = 0
                picRunning.Image = picDead.Image

                lblGameOver.Visible = True

                isGameOver = True
            End If

            gameTimer.Interval = 1
            gameTimer.Start()
        End While
    End Sub
End Class