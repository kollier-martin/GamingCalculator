Public Class frmGameSelect
    Dim HoverImage As Image
    Private Sub frmGameSelect_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Basic handler for form load events
    End Sub

    Private Sub picRunner_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRunner.MouseEnter
        ' This event handler changes the picture when mouse enters the picture box
        HoverImage = picRunner.Image
        picRunner.Image = picRunnerTwo.Image
    End Sub

    Private Sub picRunner_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picRunner.MouseLeave
        ' This event handler changes the picture to original when mouse leaves the picture box
        picRunner.Image = HoverImage
    End Sub

    Private Sub picSnake_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs) Handles picSnake.MouseEnter
        ' This event handler changes the picture when mouse enters the picture box
        HoverImage = picSnake.Image
        picSnake.Image = picSnakeTwo.Image
    End Sub

    Private Sub picSnake_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs) Handles picSnake.MouseLeave
        ' This event handler changes the picture to original when mouse leaves the picture box
        picSnake.Image = HoverImage
    End Sub

    Private Sub picSnake_Click(sender As Object, e As EventArgs) Handles picSnake.Click
        ' Load Snake
        Dim snakeGame As New frmSnake
        Me.Hide()
        snakeGame.Show()
    End Sub

    Private Sub picRunner_Click(sender As Object, e As EventArgs) Handles picRunner.Click
        ' Load Endless Runner
        Dim runGame As New frmRun
        Me.Hide()
        runGame.Show()
    End Sub

    Private Sub mnuExit_Click(sender As Object, e As EventArgs) Handles mnuExit.Click
        ' Closes the application
        Application.Exit()
    End Sub

    Private Sub mnuReturn_Click(sender As Object, e As EventArgs) Handles mnuReturn.Click
        ' Return to calculator
        Dim math As New frmCalculator
        Me.Hide()
        math.Show()
    End Sub
End Class