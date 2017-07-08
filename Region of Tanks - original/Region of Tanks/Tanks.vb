Public Class Tanks
    Dim direction As Integer
    Dim shootingDirection As Integer
    Dim top As Integer
    Dim left As Integer
    Dim width As Integer = 100
    Dim height As Integer = 100
    Dim bullets As Integer = 0
    Dim isDisabled As Boolean
    'direction values stop = 0
    'up = 1, right = 2, down= 3, left= 4
    Public Const maxBullets As Integer = 1
    Public Sub New(ByVal ulX As Integer, ByVal ulY As Integer)
        top = ulY
        left = ulX
        direction = 0
        shootingDirection = 1
        isDisabled = False
    End Sub

    Public Sub SetDirection(ByVal dir As Integer)
        direction = dir
        If dir <> 0 Then
            shootingDirection = dir
        End If
    End Sub

    Public Function getDirection() As Integer
        Return direction
    End Function

    Public Function getSDirection() As Integer
        Return shootingDirection
    End Function
    Public Function addBullet() As Boolean
        If bullets = maxBullets Then
            Return False
        Else
            bullets = bullets + 1
            Return True
        End If
    End Function
    Public Function removeBullet() As Boolean
        If bullets <= 0 Then
            Return False
        Else
            bullets = bullets - 1
            Return True
        End If
    End Function
    Public Sub disable()
        isDisabled = True
    End Sub
    Public Function disabledStatus() As Boolean
        Return isDisabled
    End Function
    Public Sub enable()
        isDisabled = False
    End Sub
    Public Function getBullets() As Integer
        Return bullets
    End Function

End Class
