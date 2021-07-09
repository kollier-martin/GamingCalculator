<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSnake
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
        Me.lblLength = New System.Windows.Forms.Label()
        Me.lblRestartQuit = New System.Windows.Forms.Label()
        Me.lblGameOver = New System.Windows.Forms.Label()
        Me.gameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblLength
        '
        Me.lblLength.AutoSize = True
        Me.lblLength.BackColor = System.Drawing.Color.Black
        Me.lblLength.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLength.ForeColor = System.Drawing.Color.Gold
        Me.lblLength.Location = New System.Drawing.Point(708, 64)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(145, 25)
        Me.lblLength.TabIndex = 0
        Me.lblLength.Text = "Snake Length: "
        '
        'lblRestartQuit
        '
        Me.lblRestartQuit.AutoSize = True
        Me.lblRestartQuit.BackColor = System.Drawing.Color.Black
        Me.lblRestartQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRestartQuit.ForeColor = System.Drawing.Color.Crimson
        Me.lblRestartQuit.Location = New System.Drawing.Point(708, 101)
        Me.lblRestartQuit.Name = "lblRestartQuit"
        Me.lblRestartQuit.Size = New System.Drawing.Size(302, 125)
        Me.lblRestartQuit.TabIndex = 1
        Me.lblRestartQuit.Text = "Restart Game:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press E" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Return to the game select screen:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Press Esc"
        '
        'lblGameOver
        '
        Me.lblGameOver.AutoSize = True
        Me.lblGameOver.BackColor = System.Drawing.Color.Black
        Me.lblGameOver.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameOver.ForeColor = System.Drawing.Color.Crimson
        Me.lblGameOver.Location = New System.Drawing.Point(708, 27)
        Me.lblGameOver.Name = "lblGameOver"
        Me.lblGameOver.Size = New System.Drawing.Size(122, 25)
        Me.lblGameOver.TabIndex = 2
        Me.lblGameOver.Text = "Game Over"
        '
        'gameTimer
        '
        '
        'frmSnake
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1117, 629)
        Me.Controls.Add(Me.lblGameOver)
        Me.Controls.Add(Me.lblRestartQuit)
        Me.Controls.Add(Me.lblLength)
        Me.Name = "frmSnake"
        Me.Text = "Snake"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblLength As Label
    Friend WithEvents lblRestartQuit As Label
    Friend WithEvents lblGameOver As Label
    Friend WithEvents gameTimer As Timer
End Class
