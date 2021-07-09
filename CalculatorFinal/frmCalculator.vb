Imports System.Drawing

Public Class frmCalculator
    ' Declare class variables
    Dim givenInput As Double
    Dim outPut As Double

    ' Indicates which operator to use in the final calculation
    Dim subtractClicked As Boolean = False
    Dim plusClicked As Boolean = False
    Dim divideClicked As Boolean = False
    Dim multiplyClicked As Boolean = False

    Private Sub frmCalculator_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.NumPad1
                txtDisplay.Text += btnOne.Text
            Case Keys.NumPad2
                txtDisplay.Text += btnTwo.Text
            Case Keys.NumPad3
                txtDisplay.Text += btnThree.Text
            Case Keys.NumPad4
                txtDisplay.Text += btnFour.Text
            Case Keys.NumPad5
                txtDisplay.Text += btnFive.Text
            Case Keys.NumPad6
                txtDisplay.Text += btnSix.Text
            Case Keys.NumPad7
                txtDisplay.Text += btnSeven.Text
            Case Keys.NumPad8
                txtDisplay.Text += btnEight.Text
            Case Keys.NumPad9
                txtDisplay.Text += btnNine.Text
            Case Keys.NumPad0
                txtDisplay.Text += btnZero.Text
            Case Keys.Back
                txtDisplay.Text -= ""
            Case Keys.Add
                btnPlus.PerformClick()
            Case Keys.Subtract
                btnSubtract.PerformClick()
            Case Keys.Divide
                btnDivide.PerformClick()
            Case Keys.Multiply
                btnMultiply.PerformClick()
            Case Keys.Enter
                btnEnter.PerformClick()
        End Select
    End Sub
    Private Sub btnOne_Click(sender As Object, e As EventArgs) Handles btnOne.Click
        ' Inserts the number 1 into the label object
        txtDisplay.Text += btnOne.Text
    End Sub

    Private Sub btnTwo_Click(sender As Object, e As EventArgs) Handles btnTwo.Click
        ' Inserts the number 2 into the label object
        txtDisplay.Text += btnTwo.Text
    End Sub

    Private Sub btnThree_Click(sender As Object, e As EventArgs) Handles btnThree.Click
        ' Inserts the number 3 into the label object
        txtDisplay.Text += btnThree.Text
    End Sub

    Private Sub btnFour_Click(sender As Object, e As EventArgs) Handles btnFour.Click
        ' Inserts the number 4 into the label object
        txtDisplay.Text += btnFour.Text
    End Sub

    Private Sub btnFive_Click(sender As Object, e As EventArgs) Handles btnFive.Click
        ' Inserts the number 5 into the label object
        txtDisplay.Text += btnFive.Text
    End Sub

    Private Sub btnSix_Click(sender As Object, e As EventArgs) Handles btnSix.Click
        ' Inserts the number 6 into the label object
        txtDisplay.Text += btnSix.Text
    End Sub

    Private Sub btnSeven_Click(sender As Object, e As EventArgs) Handles btnSeven.Click
        ' Inserts the number 7 into the label object
        txtDisplay.Text += btnSeven.Text
    End Sub

    Private Sub btnEight_Click(sender As Object, e As EventArgs) Handles btnEight.Click
        ' Inserts the number 8 into the label object
        txtDisplay.Text += btnEight.Text
    End Sub

    Private Sub btnNine_Click(sender As Object, e As EventArgs) Handles btnNine.Click
        ' Inserts the number 9 into the label object
        txtDisplay.Text += btnNine.Text
    End Sub

    Private Sub btnZero_Click(sender As Object, e As EventArgs) Handles btnZero.Click
        ' Inserts the number 0 into the label object
        txtDisplay.Text += btnZero.Text
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clears the display and resets class variables for new numbers to be used
        txtDisplay.Text = ""
        givenInput = 0
        outPut = 0
    End Sub

    Private Sub btnGames_Click(sender As Object, e As EventArgs) Handles btnGames.Click
        ' This event handler loads the form that allows the user to choose what game to play

        ' Hides the current form
        Me.Hide()

        ' Loads the game select form
        Dim selectFrm As New frmGameSelect
        selectFrm.Show()
    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        ' This event handler displays the calculated value

        ' Case statements to check if the button was clicked last and calculates according to last clicked button
        Select Case True
            Case plusClicked
                ' Adds the user's input
                outPut = givenInput + Val(txtDisplay.Text)
            Case subtractClicked
                ' Subtract the user's input
                outPut = givenInput - Val(txtDisplay.Text)
            Case divideClicked
                ' Checks if the user is dividing by 0
                If Val(txtDisplay.Text) <> 0 Then
                    outPut = givenInput / Val(txtDisplay.Text)
                Else
                    ' If dividing by 0, throw error message
                    MsgBox("Cannot divide by 0", MsgBoxStyle.Critical & MsgBoxStyle.OkOnly, "Arithmetic Error")
                End If
            Case multiplyClicked
                ' Multiply the user's input
                outPut = givenInput * Val(txtDisplay.Text)
        End Select

        ' Displays calculated operation
        txtDisplay.Text = outPut
    End Sub



    Private Sub btnPlus_Click(sender As Object, e As EventArgs) Handles btnPlus.Click
        ' Adds the user's input
        givenInput = Val(txtDisplay.Text)
        txtDisplay.Text = ""

        ' Sets addition button clicked to true and others to false
        plusClicked = True
        multiplyClicked = False
        subtractClicked = False
        divideClicked = False
    End Sub

    Private Sub btnMultiply_Click(sender As Object, e As EventArgs) Handles btnMultiply.Click
        ' Multiplies the user's input
        givenInput = Val(txtDisplay.Text)
        txtDisplay.Text = ""
        Console.WriteLine("Given Input = " & givenInput)

        ' Sets mulitplication button clicked to true and others to false
        plusClicked = False
        multiplyClicked = True
        subtractClicked = False
        divideClicked = False
    End Sub

    Private Sub btnSubtract_Click(sender As Object, e As EventArgs) Handles btnSubtract.Click
        ' Subtracts the user's input
        givenInput = Val(txtDisplay.Text)
        txtDisplay.Text = ""

        ' Sets minus button clicked to true and others to false
        plusClicked = False
        multiplyClicked = False
        subtractClicked = True
        divideClicked = False
    End Sub

    Private Sub btnDivide_Click(sender As Object, e As EventArgs) Handles btnDivide.Click
        ' Initiates try statement to see if the user is dividing by 0

        ' Divides the user's input
        givenInput = Val(txtDisplay.Text)
        txtDisplay.Text = ""

        ' Sets divide button clicked to true and others to false
        plusClicked = False
        multiplyClicked = False
        subtractClicked = False
        divideClicked = True
    End Sub
    Private Sub frmCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Holds the splash screen for 3 seconds
        Threading.Thread.Sleep(3000)

        ' Enables the use of the keypad for entry
        Me.KeyPreview = True
    End Sub

    Private Sub grpCalc_Paint(ByVal Sender As Object, ByVal e As PaintEventArgs) Handles grpCalc.Paint

        Dim Rect As Rectangle = grpCalc.ClientRectangle()

        ControlPaint.DrawBorder3D(e.Graphics, Rect, Border3DStyle.Raised)

    End Sub

End Class
