<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTanks
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
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.pctObstacle = New System.Windows.Forms.PictureBox()
        Me.pctTankTwo = New System.Windows.Forms.PictureBox()
        Me.pctTank1 = New System.Windows.Forms.PictureBox()
        Me.MenuStrip2 = New System.Windows.Forms.MenuStrip()
        Me.ScoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SaveScoreToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmdRestart = New System.Windows.Forms.Button()
        Me.lblScore1 = New System.Windows.Forms.Label()
        Me.lblScore2 = New System.Windows.Forms.Label()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClearToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        CType(Me.pctObstacle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctTankTwo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pctTank1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'pctObstacle
        '
        Me.pctObstacle.Image = Global.Region_of_Tanks.My.Resources.Resources.Obstacle
        Me.pctObstacle.Location = New System.Drawing.Point(543, 256)
        Me.pctObstacle.Name = "pctObstacle"
        Me.pctObstacle.Size = New System.Drawing.Size(174, 174)
        Me.pctObstacle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.pctObstacle.TabIndex = 4
        Me.pctObstacle.TabStop = False
        '
        'pctTankTwo
        '
        Me.pctTankTwo.Image = Global.Region_of_Tanks.My.Resources.Resources.Tank2Up
        Me.pctTankTwo.Location = New System.Drawing.Point(12, 530)
        Me.pctTankTwo.Name = "pctTankTwo"
        Me.pctTankTwo.Size = New System.Drawing.Size(100, 100)
        Me.pctTankTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctTankTwo.TabIndex = 1
        Me.pctTankTwo.TabStop = False
        '
        'pctTank1
        '
        Me.pctTank1.Image = Global.Region_of_Tanks.My.Resources.Resources.SovietTank1Up
        Me.pctTank1.Location = New System.Drawing.Point(1172, 530)
        Me.pctTank1.Name = "pctTank1"
        Me.pctTank1.Size = New System.Drawing.Size(100, 100)
        Me.pctTank1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pctTank1.TabIndex = 0
        Me.pctTank1.TabStop = False
        '
        'MenuStrip2
        '
        Me.MenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScoreToolStripMenuItem})
        Me.MenuStrip2.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip2.Name = "MenuStrip2"
        Me.MenuStrip2.Size = New System.Drawing.Size(1284, 24)
        Me.MenuStrip2.TabIndex = 5
        Me.MenuStrip2.Text = "MenuStrip2"
        '
        'ScoreToolStripMenuItem
        '
        Me.ScoreToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SaveScoreToolStripMenuItem, Me.ViewToolStripMenuItem, Me.ToolStripSeparator1, Me.ClearToolStripMenuItem})
        Me.ScoreToolStripMenuItem.Name = "ScoreToolStripMenuItem"
        Me.ScoreToolStripMenuItem.Size = New System.Drawing.Size(48, 20)
        Me.ScoreToolStripMenuItem.Text = "Score"
        '
        'SaveScoreToolStripMenuItem
        '
        Me.SaveScoreToolStripMenuItem.Name = "SaveScoreToolStripMenuItem"
        Me.SaveScoreToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.SaveScoreToolStripMenuItem.Text = "Save"
        '
        'cmdRestart
        '
        Me.cmdRestart.Location = New System.Drawing.Point(543, 31)
        Me.cmdRestart.Name = "cmdRestart"
        Me.cmdRestart.Size = New System.Drawing.Size(174, 35)
        Me.cmdRestart.TabIndex = 6
        Me.cmdRestart.Text = "Restart"
        Me.cmdRestart.UseVisualStyleBackColor = True
        Me.cmdRestart.Visible = False
        '
        'lblScore1
        '
        Me.lblScore1.AutoSize = True
        Me.lblScore1.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore1.Location = New System.Drawing.Point(1223, 38)
        Me.lblScore1.Name = "lblScore1"
        Me.lblScore1.Size = New System.Drawing.Size(50, 18)
        Me.lblScore1.TabIndex = 7
        Me.lblScore1.Text = "Score"
        '
        'lblScore2
        '
        Me.lblScore2.AutoSize = True
        Me.lblScore2.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblScore2.Location = New System.Drawing.Point(9, 38)
        Me.lblScore2.Name = "lblScore2"
        Me.lblScore2.Size = New System.Drawing.Size(50, 18)
        Me.lblScore2.TabIndex = 8
        Me.lblScore2.Text = "Score"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'ClearToolStripMenuItem
        '
        Me.ClearToolStripMenuItem.Name = "ClearToolStripMenuItem"
        Me.ClearToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.ClearToolStripMenuItem.Text = "Clear"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(149, 6)
        '
        'frmTanks
        '
        Me.ClientSize = New System.Drawing.Size(1284, 642)
        Me.Controls.Add(Me.lblScore2)
        Me.Controls.Add(Me.lblScore1)
        Me.Controls.Add(Me.cmdRestart)
        Me.Controls.Add(Me.pctTankTwo)
        Me.Controls.Add(Me.pctTank1)
        Me.Controls.Add(Me.pctObstacle)
        Me.Controls.Add(Me.MenuStrip2)
        Me.MainMenuStrip = Me.MenuStrip2
        Me.Name = "frmTanks"
        Me.Text = "Tanks"
        CType(Me.pctObstacle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctTankTwo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pctTank1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip2.ResumeLayout(False)
        Me.MenuStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pctTank As System.Windows.Forms.PictureBox
    Friend WithEvents pctTank2 As System.Windows.Forms.PictureBox
    Friend WithEvents pctBullet1 As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblLives1 As System.Windows.Forms.Label
    Friend WithEvents lblLives2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PlayToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MultiplayerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SinglplayerToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents pctBullet2 As System.Windows.Forms.PictureBox
    Friend WithEvents pctTank1 As System.Windows.Forms.PictureBox
    Friend WithEvents pctTankTwo As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents pctObstacle As System.Windows.Forms.PictureBox
    Friend WithEvents MenuStrip2 As System.Windows.Forms.MenuStrip
    Friend WithEvents ScoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cmdRestart As System.Windows.Forms.Button
    Friend WithEvents lblScore1 As System.Windows.Forms.Label
    Friend WithEvents lblScore2 As System.Windows.Forms.Label
    Friend WithEvents SaveScoreToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ClearToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
