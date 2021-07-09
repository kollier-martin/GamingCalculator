<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCalculator
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpCalc = New System.Windows.Forms.GroupBox()
        Me.btnMultiply = New System.Windows.Forms.Button()
        Me.txtDisplay = New System.Windows.Forms.TextBox()
        Me.btnDivide = New System.Windows.Forms.Button()
        Me.btnSubtract = New System.Windows.Forms.Button()
        Me.btnPlus = New System.Windows.Forms.Button()
        Me.btnZero = New System.Windows.Forms.Button()
        Me.btnTwo = New System.Windows.Forms.Button()
        Me.btnThree = New System.Windows.Forms.Button()
        Me.btnFour = New System.Windows.Forms.Button()
        Me.btnSeven = New System.Windows.Forms.Button()
        Me.btnNine = New System.Windows.Forms.Button()
        Me.btnSix = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnFive = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnEight = New System.Windows.Forms.Button()
        Me.btnGames = New System.Windows.Forms.Button()
        Me.btnOne = New System.Windows.Forms.Button()
        Me.lblGuide = New System.Windows.Forms.Label()
        Me.grpCalc.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpCalc
        '
        Me.grpCalc.BackColor = System.Drawing.Color.Teal
        Me.grpCalc.Controls.Add(Me.btnMultiply)
        Me.grpCalc.Controls.Add(Me.txtDisplay)
        Me.grpCalc.Controls.Add(Me.btnDivide)
        Me.grpCalc.Controls.Add(Me.btnSubtract)
        Me.grpCalc.Controls.Add(Me.btnPlus)
        Me.grpCalc.Controls.Add(Me.btnZero)
        Me.grpCalc.Controls.Add(Me.btnTwo)
        Me.grpCalc.Controls.Add(Me.btnThree)
        Me.grpCalc.Controls.Add(Me.btnFour)
        Me.grpCalc.Controls.Add(Me.btnSeven)
        Me.grpCalc.Controls.Add(Me.btnNine)
        Me.grpCalc.Controls.Add(Me.btnSix)
        Me.grpCalc.Controls.Add(Me.btnEnter)
        Me.grpCalc.Controls.Add(Me.btnFive)
        Me.grpCalc.Controls.Add(Me.btnClear)
        Me.grpCalc.Controls.Add(Me.btnEight)
        Me.grpCalc.Controls.Add(Me.btnGames)
        Me.grpCalc.Controls.Add(Me.btnOne)
        Me.grpCalc.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.grpCalc.Location = New System.Drawing.Point(109, 46)
        Me.grpCalc.Name = "grpCalc"
        Me.grpCalc.Size = New System.Drawing.Size(392, 458)
        Me.grpCalc.TabIndex = 0
        Me.grpCalc.TabStop = False
        '
        'btnMultiply
        '
        Me.btnMultiply.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMultiply.Location = New System.Drawing.Point(277, 337)
        Me.btnMultiply.Name = "btnMultiply"
        Me.btnMultiply.Size = New System.Drawing.Size(48, 34)
        Me.btnMultiply.TabIndex = 3
        Me.btnMultiply.Text = "x"
        Me.btnMultiply.UseVisualStyleBackColor = True
        '
        'txtDisplay
        '
        Me.txtDisplay.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDisplay.Location = New System.Drawing.Point(56, 34)
        Me.txtDisplay.Multiline = True
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.txtDisplay.Size = New System.Drawing.Size(269, 121)
        Me.txtDisplay.TabIndex = 23
        Me.txtDisplay.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnDivide
        '
        Me.btnDivide.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDivide.Location = New System.Drawing.Point(331, 337)
        Me.btnDivide.Name = "btnDivide"
        Me.btnDivide.Size = New System.Drawing.Size(48, 34)
        Me.btnDivide.TabIndex = 2
        Me.btnDivide.Text = "÷"
        Me.btnDivide.UseVisualStyleBackColor = True
        '
        'btnSubtract
        '
        Me.btnSubtract.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubtract.Location = New System.Drawing.Point(331, 283)
        Me.btnSubtract.Name = "btnSubtract"
        Me.btnSubtract.Size = New System.Drawing.Size(48, 34)
        Me.btnSubtract.TabIndex = 1
        Me.btnSubtract.Text = "-"
        Me.btnSubtract.UseVisualStyleBackColor = True
        '
        'btnPlus
        '
        Me.btnPlus.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPlus.Location = New System.Drawing.Point(277, 283)
        Me.btnPlus.Name = "btnPlus"
        Me.btnPlus.Size = New System.Drawing.Size(48, 34)
        Me.btnPlus.TabIndex = 0
        Me.btnPlus.Text = "+"
        Me.btnPlus.UseVisualStyleBackColor = True
        '
        'btnZero
        '
        Me.btnZero.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnZero.Location = New System.Drawing.Point(110, 372)
        Me.btnZero.Name = "btnZero"
        Me.btnZero.Size = New System.Drawing.Size(76, 56)
        Me.btnZero.TabIndex = 17
        Me.btnZero.Text = "0"
        Me.btnZero.UseVisualStyleBackColor = True
        '
        'btnTwo
        '
        Me.btnTwo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTwo.Location = New System.Drawing.Point(110, 188)
        Me.btnTwo.Name = "btnTwo"
        Me.btnTwo.Size = New System.Drawing.Size(76, 56)
        Me.btnTwo.TabIndex = 2
        Me.btnTwo.Text = "2"
        Me.btnTwo.UseVisualStyleBackColor = True
        '
        'btnThree
        '
        Me.btnThree.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnThree.Location = New System.Drawing.Point(191, 188)
        Me.btnThree.Name = "btnThree"
        Me.btnThree.Size = New System.Drawing.Size(76, 56)
        Me.btnThree.TabIndex = 3
        Me.btnThree.Text = "3"
        Me.btnThree.UseVisualStyleBackColor = True
        '
        'btnFour
        '
        Me.btnFour.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFour.Location = New System.Drawing.Point(29, 249)
        Me.btnFour.Name = "btnFour"
        Me.btnFour.Size = New System.Drawing.Size(76, 56)
        Me.btnFour.TabIndex = 4
        Me.btnFour.Text = "4"
        Me.btnFour.UseVisualStyleBackColor = True
        '
        'btnSeven
        '
        Me.btnSeven.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSeven.Location = New System.Drawing.Point(29, 310)
        Me.btnSeven.Name = "btnSeven"
        Me.btnSeven.Size = New System.Drawing.Size(76, 56)
        Me.btnSeven.TabIndex = 7
        Me.btnSeven.Text = "7"
        Me.btnSeven.UseVisualStyleBackColor = True
        '
        'btnNine
        '
        Me.btnNine.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNine.Location = New System.Drawing.Point(191, 310)
        Me.btnNine.Name = "btnNine"
        Me.btnNine.Size = New System.Drawing.Size(76, 56)
        Me.btnNine.TabIndex = 9
        Me.btnNine.Text = "9"
        Me.btnNine.UseVisualStyleBackColor = True
        '
        'btnSix
        '
        Me.btnSix.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSix.Location = New System.Drawing.Point(191, 249)
        Me.btnSix.Name = "btnSix"
        Me.btnSix.Size = New System.Drawing.Size(76, 56)
        Me.btnSix.TabIndex = 6
        Me.btnSix.Text = "6"
        Me.btnSix.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEnter.Location = New System.Drawing.Point(191, 372)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(76, 56)
        Me.btnEnter.TabIndex = 10
        Me.btnEnter.Text = "Enter"
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'btnFive
        '
        Me.btnFive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnFive.Location = New System.Drawing.Point(110, 249)
        Me.btnFive.Name = "btnFive"
        Me.btnFive.Size = New System.Drawing.Size(76, 56)
        Me.btnFive.TabIndex = 5
        Me.btnFive.Text = "5"
        Me.btnFive.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClear.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClear.Location = New System.Drawing.Point(29, 371)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(76, 56)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnEight
        '
        Me.btnEight.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEight.Location = New System.Drawing.Point(110, 310)
        Me.btnEight.Name = "btnEight"
        Me.btnEight.Size = New System.Drawing.Size(76, 56)
        Me.btnEight.TabIndex = 8
        Me.btnEight.Text = "8"
        Me.btnEight.UseVisualStyleBackColor = True
        '
        'btnGames
        '
        Me.btnGames.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGames.Location = New System.Drawing.Point(277, 218)
        Me.btnGames.Name = "btnGames"
        Me.btnGames.Size = New System.Drawing.Size(102, 35)
        Me.btnGames.TabIndex = 13
        Me.btnGames.Text = "Games"
        Me.btnGames.UseVisualStyleBackColor = True
        '
        'btnOne
        '
        Me.btnOne.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOne.Location = New System.Drawing.Point(29, 188)
        Me.btnOne.Name = "btnOne"
        Me.btnOne.Size = New System.Drawing.Size(76, 56)
        Me.btnOne.TabIndex = 1
        Me.btnOne.Text = "1"
        Me.btnOne.UseVisualStyleBackColor = True
        '
        'lblGuide
        '
        Me.lblGuide.AutoSize = True
        Me.lblGuide.Font = New System.Drawing.Font("Microsoft Tai Le", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGuide.Location = New System.Drawing.Point(104, 519)
        Me.lblGuide.Name = "lblGuide"
        Me.lblGuide.Size = New System.Drawing.Size(402, 52)
        Me.lblGuide.TabIndex = 1
        Me.lblGuide.Text = "Please press enter after every operation. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Do not string together operations"
        Me.lblGuide.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'frmCalculator
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Khaki
        Me.ClientSize = New System.Drawing.Size(587, 582)
        Me.Controls.Add(Me.lblGuide)
        Me.Controls.Add(Me.grpCalc)
        Me.Name = "frmCalculator"
        Me.Text = "Calculator v1.0"
        Me.grpCalc.ResumeLayout(False)
        Me.grpCalc.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents grpCalc As GroupBox
    Friend WithEvents btnTwo As Button
    Friend WithEvents btnThree As Button
    Friend WithEvents btnFour As Button
    Friend WithEvents btnSeven As Button
    Friend WithEvents btnNine As Button
    Friend WithEvents btnSix As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnFive As Button
    Friend WithEvents btnClear As Button
    Friend WithEvents btnEight As Button
    Friend WithEvents btnGames As Button
    Friend WithEvents btnOne As Button
    Friend WithEvents btnZero As Button
    Friend WithEvents txtDisplay As TextBox
    Friend WithEvents btnDivide As Button
    Friend WithEvents btnSubtract As Button
    Friend WithEvents btnPlus As Button
    Friend WithEvents btnMultiply As Button
    Friend WithEvents lblGuide As Label
End Class
