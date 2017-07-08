Public Class frmTanks
    Public tank1 As Tanks
    Public tank2 As Tanks
    '  Public Bullets1(mBullets) As PictureBox
    '  Public Bullets2(mBullets) As PictureBox
    ' Public b1Directions(mBullets) As Integer
    ' Public b2Directions(mBullets) As Integer
    Dim Bullet1 As PictureBox
    Dim Bullet2 As PictureBox
    Dim Bullet1Direction As Integer
    Dim Bullet2Direction As Integer

    Public Const dirStop As Integer = 0
    Public Const dirUp As Integer = 1
    Public Const dirLeft As Integer = 4
    Public Const dirRight As Integer = 2
    Public Const dirDown As Integer = 3
    Public Const tMove As Integer = 7
    Public Const jumpBack As Integer = 2
    Public Const mBullets As Integer = 3
    Public Const bulletShift As Integer = 15

    Public score1 As Integer = 0
    Public newscore1 As Integer = 0
    Public score2 As Integer = 0

    Dim clock As Integer = 0
    'Dim pctTank As System.Windows.Forms.PictureBox
    'Dim pctTank2 As System.Windows.Forms.PictureBox
    Dim deathCount As Integer = 0
    Public Const deathWait As Integer = 100

    Public Sub setup()

    End Sub

    Private Sub frmTanks_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Me.Load

        tank1 = New Tanks(12, 124)
        tank2 = New Tanks(52, 234)
        pctTankTwo.Image = My.Resources.Tank2Up
        pctTank1.Image = My.Resources.SovietTank1Up
        Bullet1Direction = dirStop
        Bullet2Direction = dirStop
        Bullet1 = New PictureBox()
        Bullet2 = New PictureBox()
 

    End Sub
    Private Sub frmTank_KeyDown(ByVal sender As Object, ByVal e As KeyEventArgs) Handles Me.KeyDown
 
        If tank2.disabledStatus() = False Then


            Select Case e.KeyCode

                'Tank 2
                'W
                Case Keys.W
                    tank2.SetDirection(dirUp)
                    pctTankTwo.Image = My.Resources.Tank2Up
                    'A
                Case Keys.A
                    tank2.SetDirection(dirLeft)
                    pctTankTwo.Image = My.Resources.Tank2Left
                    'S
                Case Keys.S
                    tank2.SetDirection(dirDown)
                    pctTankTwo.Image = My.Resources.Tank2Down
                    'D
                Case Keys.D
                    tank2.SetDirection(dirRight)
                    pctTankTwo.Image = My.Resources.Tank2Right
                Case Keys.Space
                    'shooting
                    If tank2.addBullet() = True Then
                        Select Case tank2.getSDirection()
                            Case dirUp
                                'Up
                                Bullet2.Left = pctTankTwo.Left + 25
                                Bullet2.Top = pctTankTwo.Top - 16
                            Case dirDown
                                'Down
                                Bullet2.Left = pctTankTwo.Left + 100 - 25
                                Bullet2.Top = pctTankTwo.Top + 100 + 1
                            Case dirLeft
                                'Left
                                Bullet2.Left = pctTankTwo.Left - 1
                                Bullet2.Top = pctTankTwo.Top + 60
                            Case dirRight
                                'Right
                                Bullet2.Left = pctTankTwo.Left + 101
                                Bullet2.Top = pctTankTwo.Top + 25
                        End Select
                        Bullet2Direction = tank2.getSDirection()
                        Bullet2.Image = My.Resources.Bullet1
                        Me.Controls.Add(Bullet2)


                    End If
            End Select
        End If

        '  Tank 1

        If tank1.disabledStatus() = False Then

            Select Case e.KeyCode
                'Tank 1
                Case Keys.Up
                    tank1.SetDirection(dirUp)
                    pctTank1.Image = My.Resources.SovietTank1Up
                Case Keys.Down
                    tank1.SetDirection(dirDown)
                    pctTank1.Image = My.Resources.SovietTank1Down
                Case Keys.Left
                    tank1.SetDirection(dirLeft)
                    pctTank1.Image = My.Resources.SovietTank1Left
                Case Keys.Right
                    tank1.SetDirection(dirRight)
                    pctTank1.Image = My.Resources.SovietTank1Right

                Case Keys.NumPad0
                    'shooting

                    If tank1.addBullet() = True Then
                
                        Select Case tank1.getSDirection()
                            Case dirUp
                                'Up
                                Bullet1.Left = pctTank1.Left + 25
                                Bullet1.Top = pctTank1.Top - 16
                            Case dirDown
                                'Down
                                Bullet1.Left = pctTank1.Left + 100 - 25
                                Bullet1.Top = pctTank1.Top + 100 + 1
                            Case dirLeft
                                'Left
                                Bullet1.Left = pctTank1.Left - 1
                                Bullet1.Top = pctTank1.Top + 60
                            Case dirRight
                                'Right
                                Bullet1.Left = pctTank1.Left + 101
                                Bullet1.Top = pctTank1.Top + 25
                        End Select
                        Bullet1Direction = tank1.getSDirection()
                        Bullet1.Image = My.Resources.Bullet1
                        Bullet1.Visible = True

                        Me.Controls.Add(Bullet1)


                    End If
            End Select
        End If
    End Sub
   
    Private Sub frmTanks_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        If tank1.disabledStatus() = False Then
            If e.KeyCode = Keys.Up Or e.KeyCode = Keys.Down Or e.KeyCode = Keys.Left Or e.KeyCode = Keys.Right Then
                tank1.SetDirection(dirStop)
            End If
        End If

        If tank2.disabledStatus() = False Then
            If e.KeyCode = Keys.W Or e.KeyCode = Keys.S Or e.KeyCode = Keys.A Or e.KeyCode = Keys.D Then
                tank2.SetDirection(dirStop)
            End If
        End If

        e.Handled = True
    End Sub


    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim numberB1 As Integer
        Dim numberB2 As Integer
        clock = clock + 1

        ' Tank 2 bullet actions
        numberB2 = tank2.getBullets()
        If numberB2 = 1 Then
            Select Case Bullet2Direction
                Case dirUp
                    Bullet2.Top = Bullet2.Top - bulletShift
                Case dirDown
                    Bullet2.Top = Bullet2.Top + bulletShift
                Case dirLeft
                    Bullet2.Left = Bullet2.Left - bulletShift
                Case dirRight
                    Bullet2.Left = Bullet2.Left + bulletShift
            End Select
            If Bullet2.Top <= 20 Or Bullet2.Top >= 600 Or Bullet2.Left <= 0 Or Bullet2.Left >= 1200 Then
                tank2.removeBullet()
                Me.Controls.Remove(Bullet2)
            End If
            ' check if the bullet hit the obstacle
            If CollisionBulletWall(Bullet2, pctObstacle) = True Then
                tank2.removeBullet()
                Me.Controls.Remove(Bullet2)
            End If
            ' check if we hit the other tank
            If CollisionBulletTank(Bullet2, pctTank1) = True Then
                tank2.removeBullet()
                Me.Controls.Remove(Bullet2)
                tank1.disable()
                tank1.SetDirection(dirStop)
                'cmdRestart.Visible = True
                'handle scores
                clock = 0
                lblScore1.Text = score1
                score2 = score2 + 1
                lblScore2.Text = score2

                'pctTank2.Image = My.Resources.Death2
            End If
        End If

        numberB1 = tank1.getBullets()
        If numberB1 = 1 Then


            Select Case Bullet1Direction
                Case dirUp
                    Bullet1.Top = Bullet1.Top - bulletShift
                Case dirDown
                    Bullet1.Top = Bullet1.Top + bulletShift
                Case dirLeft
                    Bullet1.Left = Bullet1.Left - bulletShift
                Case dirRight
                    Bullet1.Left = Bullet1.Left + bulletShift
            End Select

            If Bullet1.Top <= 20 Or Bullet1.Top >= 600 Or Bullet1.Left <= 0 Or Bullet1.Left >= 1200 Then
                tank1.removeBullet()
                Me.Controls.Remove(Bullet1)
            End If
            If CollisionBulletWall(Bullet1, pctObstacle) = True Then
                tank1.removeBullet()
                Me.Controls.Remove(Bullet1)
            End If
            If CollisionBulletTank(Bullet1, pctTankTwo) = True Then
                tank1.removeBullet()
                Me.Controls.Remove(Bullet1)
                tank2.disable()
                tank2.SetDirection(dirStop)
                'cmdRestart.Visible = True
                'Handle scores
                clock = 0

                lblScore2.Text = score2
                score1 = score1 + 1
                lblScore1.Text = score1

            End If
        End If

        If tank2.disabledStatus() = False Then


            Select Case tank2.getDirection()
                'Tank 2
                'W
                Case dirUp

                    If (pctTankTwo.Top - tMove >= 20) Then
                        pctTankTwo.Top = pctTankTwo.Top - tMove
                        If Collision(pctTankTwo, pctTank1) = True Then
                            pctTankTwo.Top = pctTankTwo.Top + tMove + 4
                        End If
                        If CollisionWall(pctTankTwo, pctObstacle) = True Then
                            pctTankTwo.Top = pctTankTwo.Top + tMove + 4
                        End If
                    End If
                    'e.Handled = True
                    'A
                Case dirLeft

                    If (pctTankTwo.Left - tMove >= 0) Then
                        pctTankTwo.Left = pctTankTwo.Left - tMove
                        If Collision(pctTankTwo, pctTank1) = True Or CollisionWall(pctTankTwo, pctObstacle) = True Then
                            pctTankTwo.Left = pctTankTwo.Left + tMove + 4
                        End If
                    End If
                    'e.Handled = True
                    'S
                Case dirDown

                    If (pctTankTwo.Top + tMove <= 590) Then
                        pctTankTwo.Top = pctTankTwo.Top + tMove
                        If Collision(pctTankTwo, pctTank1) = True Or CollisionWall(pctTankTwo, pctObstacle) = True Then
                            pctTankTwo.Top = pctTankTwo.Top - tMove - 4
                        End If
                    End If
                    ' e.Handled = True
                    'D
                Case dirRight

                    If (pctTankTwo.Left <= 1200) Then
                        pctTankTwo.Left = pctTankTwo.Left + tMove
                        If Collision(pctTankTwo, pctTank1) = True Or CollisionWall(pctTankTwo, pctObstacle) = True Then
                            pctTankTwo.Left = pctTankTwo.Left - tMove - 4
                        End If
                    End If
                    'e.Handled = True

            End Select

        Else
            ' Tank 2 is dead, let us spin it
            Dim tankD2 As Integer
            deathCount = deathCount + 1
            tankD2 = tank2.getDirection()
            If tankD2 = dirStop Then
                tankD2 = dirUp
            End If
            Select Case tankD2
                'Tank 2
                Case dirUp
                    tank2.SetDirection(dirRight)
                    pctTankTwo.Image = My.Resources.Tank2Up
                Case dirDown
                    tank2.SetDirection(dirLeft)
                    pctTankTwo.Image = My.Resources.Tank2Down
                Case dirLeft
                    tank2.SetDirection(dirUp)
                    pctTankTwo.Image = My.Resources.Tank2Left
                Case dirRight
                    tank2.SetDirection(dirDown)
                    pctTankTwo.Image = My.Resources.Tank2Right
            End Select
        End If

        'Tank 1
        If tank1.disabledStatus() = False Then


            Select Case tank1.getDirection()

                Case dirUp

                    If (pctTank1.Top - tMove >= 20) Then
                        pctTank1.Top = pctTank1.Top - tMove
                        If Collision(pctTank1, pctTankTwo) = True Then
                            pctTank1.Top = pctTank1.Top + tMove + jumpBack
                        End If
                        If CollisionWall(pctTank1, pctObstacle) = True Then
                            pctTank1.Top = pctTank1.Top + tMove + jumpBack
                        End If

                    End If
                Case dirDown

                    If (pctTank1.Top - tMove <= 590) Then
                        pctTank1.Top = pctTank1.Top + tMove
                        If Collision(pctTank1, pctTankTwo) = True Or CollisionWall(pctTank1, pctObstacle) = True Then
                            pctTank1.Top = pctTank1.Top - tMove - jumpBack
                        End If
                    End If
                Case dirLeft
                    If (pctTank1.Left + tMove >= 0) Then
                        pctTank1.Left = pctTank1.Left - tMove
                        If Collision(pctTank1, pctTankTwo) = True Or CollisionWall(pctTank1, pctObstacle) = True Then
                            pctTank1.Left = pctTank1.Left + tMove + jumpBack
                        End If

                    End If
                Case dirRight
                    If (pctTank1.Left <= 1200) Then
                        pctTank1.Left = pctTank1.Left + tMove
                        If Collision(pctTank1, pctTankTwo) = True Or CollisionWall(pctTank1, pctObstacle) = True Then
                            pctTank1.Left = pctTank1.Left - tMove - jumpBack
                        End If
                    End If
            End Select
        Else
            ' Tank 1 is dead, let us spin it
            Dim tankD As Integer
            tankD = tank1.getDirection()
            deathCount = deathCount + 1
            If tankD = dirStop Then
                tankD = dirUp
            End If
            Select Case tankD
                'Tank 1
                Case dirUp
                    tank1.SetDirection(dirRight)
                    pctTank1.Image = My.Resources.SovietTank1Up
                Case dirDown
                    tank1.SetDirection(dirLeft)
                    pctTank1.Image = My.Resources.SovietTank1Down
                Case dirLeft
                    tank1.SetDirection(dirUp)
                    pctTank1.Image = My.Resources.SovietTank1Left
                Case dirRight
                    tank1.SetDirection(dirLeft)
                    pctTank1.Image = My.Resources.SovietTank1Right
            End Select

        End If

        If deathCount >= deathWait Then
            restart()
        End If
    End Sub

    Public Function Collision(ByVal t1 As System.Windows.Forms.PictureBox, ByVal t2 As System.Windows.Forms.PictureBox) As Boolean
        If isInside(t1.Left, t1.Top, t2) = True Then
            Return True
        End If
        If isInside(t1.Left + 100, t1.Top, t2) = True Then
            Return True
        End If
        If isInside(t1.Left, t1.Top + 100, t2) = True Then
            Return True
        End If
        If isInside(t1.Left + 100, t1.Top + 100, t2) = True Then
            Return True
        End If

        Return False

    End Function
    Public Function CollisionWall(ByVal t1 As System.Windows.Forms.PictureBox, ByVal o As System.Windows.Forms.PictureBox) As Boolean
        If isInsideWall(t1.Left, t1.Top, o) = True Then
            Return True
        End If
        If isInsideWall(t1.Left + 100, t1.Top, o) = True Then
            Return True
        End If
        If isInsideWall(t1.Left, t1.Top + 100, o) = True Then
            Return True
        End If
        If isInsideWall(t1.Left + 100, t1.Top + 100, o) = True Then
            Return True
        End If

        Return False

    End Function
    Public Function CollisionBulletWall(ByVal b As System.Windows.Forms.PictureBox, ByVal o As System.Windows.Forms.PictureBox) As Boolean
        If isInsideWall(b.Left, b.Top, o) = True Then
            Return True
        End If
        If isInsideWall(b.Left + 15, b.Top, o) = True Then
            Return True
        End If
        If isInsideWall(b.Left, b.Top + 15, o) = True Then
            Return True
        End If
        If isInsideWall(b.Left + 15, b.Top + 15, o) = True Then
            Return True
        End If

        Return False

    End Function
    Public Function CollisionBulletTank(ByVal b As System.Windows.Forms.PictureBox, ByVal t As System.Windows.Forms.PictureBox) As Boolean
        If isInside(b.Left, b.Top, t) = True Then
            Return True
        End If
        If isInside(b.Left + 15, b.Top, t) = True Then
            Return True
        End If
        If isInside(b.Left, b.Top + 15, t) = True Then
            Return True
        End If
        If isInside(b.Left + 15, b.Top + 15, t) = True Then
            Return True
        End If

        Return False

    End Function

    Public Function isInside(ByVal x As Integer, ByVal y As Integer, ByVal t As System.Windows.Forms.PictureBox) As Boolean

        ' checks to see is point (x,y) is inside the box of pictureBox t.
        If x >= t.Left And x <= t.Left + 100 And y >= t.Top And y <= t.Top + 100 Then
            Return True
        End If
        Return False

    End Function

    Public Function isInsideWall(ByVal x As Integer, ByVal y As Integer, ByVal t As System.Windows.Forms.PictureBox) As Boolean

        ' checks to see is point (x,y) is inside the box of pictureBox t.
        If x >= t.Left And x <= t.Left + 174 And y >= t.Top And y <= t.Top + 174 Then
            Return True
        End If
        Return False

    End Function

   
    Private Sub cmdRestart_Click(sender As Object, e As EventArgs) Handles cmdRestart.Click
        cmdRestart.Visible = False
        tank1.SetDirection(dirStop)
        tank2.SetDirection(dirStop)
        tank1.enable()
        tank2.enable()
        tank1.removeBullet()
        tank2.removeBullet()

        pctTankTwo.Left = 12
        pctTankTwo.Top = 530
        pctTankTwo.Image = My.Resources.Tank2Up

        pctTank1.Left = 1172
        pctTank1.Top = 530
        pctTank1.Image = My.Resources.SovietTank1Up
        '  cmdRestart.Text = "Wait for it"
        clock = 0
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        score1 = 0
        score2 = 0
        newscore1 = 0
        lblScore1.Text = score1
        lblScore2.Text = score2

    End Sub

    Private Sub restart()
        tank1.SetDirection(dirStop)
        tank2.SetDirection(dirStop)
        tank1.enable()
        tank2.enable()
        tank1.removeBullet()
        tank2.removeBullet()

        pctTankTwo.Left = 12
        pctTankTwo.Top = 530
        pctTankTwo.Image = My.Resources.Tank2Up

        pctTank1.Left = 1172
        pctTank1.Top = 530
        pctTank1.Image = My.Resources.SovietTank1Up
        '  cmdRestart.Text = "Wait for it"
        clock = 0
        deathCount = 0
    End Sub

    Public Sub newGame()
        score1 = 0
        score2 = 0
        lblScore1.Text = score1
        lblScore2.Text = score2

        restart()
    End Sub

    Private Sub SaveScoreToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveScoreToolStripMenuItem.Click
        frmScore.ShowDialog()
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        Dim fileReader As String
        Dim currentDir As String = Environment.CurrentDirectory
        fileReader = My.Computer.FileSystem.ReadAllText(currentDir & "\RegionOfTanks-Scores.txt")
        MsgBox(fileReader)
    End Sub
End Class