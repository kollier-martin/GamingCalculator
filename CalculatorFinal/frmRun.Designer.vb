<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRun
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
        Me.components = New System.ComponentModel.Container()
        Me.picObstacle1 = New System.Windows.Forms.PictureBox()
        Me.picRunning = New System.Windows.Forms.PictureBox()
        Me.picFloor = New System.Windows.Forms.PictureBox()
        Me.picObstacle2 = New System.Windows.Forms.PictureBox()
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblScore = New System.Windows.Forms.Label()
        Me.picDead = New System.Windows.Forms.PictureBox()
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lblStart = New System.Windows.Forms.Label()
        CType(Me.picObstacle1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRunning, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFloor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picObstacle2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDead, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'picObstacle1
        '
        Me.picObstacle1.BackColor = System.Drawing.Color.Transparent
        Me.picObstacle1.Image = Global.CalculatorFinal.My.Resources.Resources.obstacle_1
        Me.picObstacle1.Location = New System.Drawing.Point(308, 347)
        Me.picObstacle1.Name = "picObstacle1"
        Me.picObstacle1.Size = New System.Drawing.Size(42, 64)
        Me.picObstacle1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picObstacle1.TabIndex = 0
        Me.picObstacle1.TabStop = False
        Me.picObstacle1.Tag = "obstacle"
        '
        'picRunning
        '
        Me.picRunning.BackColor = System.Drawing.Color.Transparent
        Me.picRunning.Image = Global.CalculatorFinal.My.Resources.Resources.running
        Me.picRunning.Location = New System.Drawing.Point(5, 333)
        Me.picRunning.Name = "picRunning"
        Me.picRunning.Size = New System.Drawing.Size(69, 77)
        Me.picRunning.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picRunning.TabIndex = 1
        Me.picRunning.TabStop = False
        '
        'picFloor
        '
        Me.picFloor.BackColor = System.Drawing.Color.Black
        Me.picFloor.Location = New System.Drawing.Point(1, 410)
        Me.picFloor.Name = "picFloor"
        Me.picFloor.Size = New System.Drawing.Size(797, 39)
        Me.picFloor.TabIndex = 2
        Me.picFloor.TabStop = False
        '
        'picObstacle2
        '
        Me.picObstacle2.BackColor = System.Drawing.Color.Transparent
        Me.picObstacle2.Image = Global.CalculatorFinal.My.Resources.Resources.obstacle_2
        Me.picObstacle2.Location = New System.Drawing.Point(569, 346)
        Me.picObstacle2.Name = "picObstacle2"
        Me.picObstacle2.Size = New System.Drawing.Size(67, 64)
        Me.picObstacle2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picObstacle2.TabIndex = 3
        Me.picObstacle2.TabStop = False
        Me.picObstacle2.Tag = "obstacle"
        '
        'gameTimer
        '
        '
        'lblScore
        '
        Me.lblScore.AutoSize = True
        Me.lblScore.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore.Location = New System.Drawing.Point(12, 9)
        Me.lblScore.Name = "lblScore"
        Me.lblScore.Size = New System.Drawing.Size(70, 25)
        Me.lblScore.TabIndex = 5
        Me.lblScore.Text = "Score:"
        '
        'picDead
        '
        Me.picDead.BackColor = System.Drawing.Color.Transparent
        Me.picDead.Image = Global.CalculatorFinal.My.Resources.Resources.dead
        Me.picDead.Location = New System.Drawing.Point(5, 333)
        Me.picDead.Name = "picDead"
        Me.picDead.Size = New System.Drawing.Size(69, 77)
        Me.picDead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDead.TabIndex = 6
        Me.picDead.TabStop = False
        '
        'lblGameOver
        '
        Me.lblGameOver.AutoSize = True
        Me.lblGameOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.ForeColor = System.Drawing.Color.DarkRed
        Me.lblGameOver.Location = New System.Drawing.Point(552, 18)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(236, 175)
        Me.lblGameOver.TabIndex = 7
        Me.lblGameOver.Text = "Game Over " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Reset Game:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press R" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Return to Game Select:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press Esc"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.CalculatorFinal.My.Resources.Resources.running
        Me.PictureBox2.Location = New System.Drawing.Point(5, 334)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(69, 77)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'lblStart
        '
        Me.lblStart.AutoSize = True
        Me.lblStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStart.Location = New System.Drawing.Point(12, 48)
        Me.lblStart.Name = "lblStart"
        Me.lblStart.Size = New System.Drawing.Size(157, 25)
        Me.lblStart.TabIndex = 10
        Me.lblStart.Text = "Press S to Begin"
        '
        'frmRun
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.lblStart)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.lblScore)
        Me.Controls.Add(Me.picObstacle2)
        Me.Controls.Add(Me.picFloor)
        Me.Controls.Add(Me.picRunning)
        Me.Controls.Add(Me.picObstacle1)
        Me.Controls.Add(Me.picDead)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "frmRun"
        Me.Text = "Endless Runner"
        CType(Me.picObstacle1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRunning, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFloor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picObstacle2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDead, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents picObstacle1 As PictureBox
    Friend WithEvents picRunning As PictureBox
    Friend WithEvents picFloor As PictureBox
    Friend WithEvents picObstacle2 As PictureBox
    Friend WithEvents gameTimer As Timer
    Friend WithEvents lblScore As Label
    Friend WithEvents picDead As PictureBox
    Friend WithEvents lblGameOver As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents lblStart As Label
End Class
