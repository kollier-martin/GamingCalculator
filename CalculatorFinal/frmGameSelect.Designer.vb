<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGameSelect
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lblSelectGame = New System.Windows.Forms.Label()
        Me.lblSnake = New System.Windows.Forms.Label()
        Me.lblRunner = New System.Windows.Forms.Label()
        Me.picRunner = New System.Windows.Forms.PictureBox()
        Me.picSnake = New System.Windows.Forms.PictureBox()
        Me.picRunnerTwo = New System.Windows.Forms.PictureBox()
        Me.picSnakeTwo = New System.Windows.Forms.PictureBox()
        Me.MenuStrip = New System.Windows.Forms.MenuStrip()
        Me.ToolMenu = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuReturn = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.picRunner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnake, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRunnerTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSnakeTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSelectGame
        '
        Me.lblSelectGame.AutoSize = True
        Me.lblSelectGame.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSelectGame.Location = New System.Drawing.Point(305, 52)
        Me.lblSelectGame.Name = "lblSelectGame"
        Me.lblSelectGame.Size = New System.Drawing.Size(189, 25)
        Me.lblSelectGame.TabIndex = 2
        Me.lblSelectGame.Text = "Select Game to Play"
        '
        'lblSnake
        '
        Me.lblSnake.AutoSize = True
        Me.lblSnake.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSnake.Location = New System.Drawing.Point(191, 378)
        Me.lblSnake.Name = "lblSnake"
        Me.lblSnake.Size = New System.Drawing.Size(63, 24)
        Me.lblSnake.TabIndex = 3
        Me.lblSnake.Text = "Snake"
        '
        'lblRunner
        '
        Me.lblRunner.AutoSize = True
        Me.lblRunner.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRunner.Location = New System.Drawing.Point(517, 378)
        Me.lblRunner.Name = "lblRunner"
        Me.lblRunner.Size = New System.Drawing.Size(140, 24)
        Me.lblRunner.TabIndex = 4
        Me.lblRunner.Text = "Google Runner"
        '
        'picRunner
        '
        Me.picRunner.Image = Global.CalculatorFinal.My.Resources.Resources.dead
        Me.picRunner.Location = New System.Drawing.Point(443, 129)
        Me.picRunner.Name = "picRunner"
        Me.picRunner.Size = New System.Drawing.Size(289, 230)
        Me.picRunner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picRunner.TabIndex = 1
        Me.picRunner.TabStop = False
        '
        'picSnake
        '
        Me.picSnake.Image = Global.CalculatorFinal.My.Resources.Resources.snake
        Me.picSnake.Location = New System.Drawing.Point(77, 128)
        Me.picSnake.Name = "picSnake"
        Me.picSnake.Size = New System.Drawing.Size(286, 230)
        Me.picSnake.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSnake.TabIndex = 0
        Me.picSnake.TabStop = False
        '
        'picRunnerTwo
        '
        Me.picRunnerTwo.Image = Global.CalculatorFinal.My.Resources.Resources.running
        Me.picRunnerTwo.Location = New System.Drawing.Point(443, 128)
        Me.picRunnerTwo.Name = "picRunnerTwo"
        Me.picRunnerTwo.Size = New System.Drawing.Size(289, 230)
        Me.picRunnerTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picRunnerTwo.TabIndex = 5
        Me.picRunnerTwo.TabStop = False
        '
        'picSnakeTwo
        '
        Me.picSnakeTwo.Image = Global.CalculatorFinal.My.Resources.Resources.snake1
        Me.picSnakeTwo.Location = New System.Drawing.Point(77, 129)
        Me.picSnakeTwo.Name = "picSnakeTwo"
        Me.picSnakeTwo.Size = New System.Drawing.Size(286, 229)
        Me.picSnakeTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picSnakeTwo.TabIndex = 6
        Me.picSnakeTwo.TabStop = False
        '
        'MenuStrip
        '
        Me.MenuStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolMenu})
        Me.MenuStrip.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip.Name = "MenuStrip"
        Me.MenuStrip.Size = New System.Drawing.Size(800, 28)
        Me.MenuStrip.TabIndex = 7
        Me.MenuStrip.Text = "MenuStrip1"
        '
        'ToolMenu
        '
        Me.ToolMenu.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuReturn, Me.mnuExit})
        Me.ToolMenu.Name = "ToolMenu"
        Me.ToolMenu.Size = New System.Drawing.Size(58, 24)
        Me.ToolMenu.Text = "&Menu"
        '
        'mnuReturn
        '
        Me.mnuReturn.Name = "mnuReturn"
        Me.mnuReturn.Size = New System.Drawing.Size(218, 26)
        Me.mnuReturn.Text = "&Return to Arithmetic"
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(218, 26)
        Me.mnuExit.Text = "&Exit"
        '
        'frmGameSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblRunner)
        Me.Controls.Add(Me.lblSnake)
        Me.Controls.Add(Me.lblSelectGame)
        Me.Controls.Add(Me.picRunner)
        Me.Controls.Add(Me.picSnake)
        Me.Controls.Add(Me.picRunnerTwo)
        Me.Controls.Add(Me.picSnakeTwo)
        Me.Controls.Add(Me.MenuStrip)
        Me.MainMenuStrip = Me.MenuStrip
        Me.Name = "frmGameSelect"
        Me.Text = "Game Select"
        CType(Me.picRunner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnake, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRunnerTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSnakeTwo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip.ResumeLayout(False)
        Me.MenuStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picSnake As PictureBox
    Friend WithEvents picRunner As PictureBox
    Friend WithEvents lblSelectGame As Label
    Friend WithEvents lblSnake As Label
    Friend WithEvents lblRunner As Label
    Friend WithEvents picRunnerTwo As PictureBox
    Friend WithEvents picSnakeTwo As PictureBox
    Friend WithEvents MenuStrip As MenuStrip
    Friend WithEvents ToolMenu As ToolStripMenuItem
    Friend WithEvents mnuReturn As ToolStripMenuItem
    Friend WithEvents mnuExit As ToolStripMenuItem
End Class
