Class MainWindow
    Dim movearm As Boolean = False
    Dim mousescreen As Boolean = False
    Dim rigthLeg As New Line
    Dim rightarmangle As Double
    Dim a As Double
    Dim b As Double
    Dim x As Double
    Dim y As Double
    Dim i As Double
    Dim j As Double
    Dim LowLeftLeg As New Line
    Dim LowRightLeg As New Line
    Dim UpLeftLeg As New Line
    Dim UpRightLeg As New Line
    Dim MoveR As Double = 0
    Dim angleR As Double = 0
    Dim angleRlow As Double = 0
    Dim MoveL As Double = 0
    Dim angleL As Double = 0
    Dim angleLlow As Double = 0
    Dim move As Integer = 0

    Dim Tronch As New Line
    Dim LeftArm As New Line
    Dim RightForeArm As New Line
    Dim RightArm As New Line
    Dim Head As New Ellipse
    Private TheGround As New Line


    Private Function Ground() As Line

        Dim MyGround As New Line
        Dim MyScaleTransform As New ScaleTransform()
        Dim MyTransformGroups As New TransformGroup()
        MyGround.X1 = 0
        MyGround.Y1 = 220
        MyGround.X2 = 525
        MyGround.Y2 = 220
        MyGround.Stroke = Brushes.Brown
        MyGround.StrokeThickness = 12
        MyScaleTransform.ScaleX = 1
        MyTransformGroups.Children.Add(MyScaleTransform)
        MyGround.RenderTransform = MyTransformGroups
        Oscar.Children.Add(MyGround)
        Return MyGround
    End Function

    Private Function TheHead(motion As Double) As Ellipse
        Dim MyHead As New Ellipse
        Dim MyTranslate As New TranslateTransform()
        Dim MyTransformGroups As New TransformGroup()

        MyHead.Width = 35
        MyHead.Height = 35
        MyHead.Stroke = Brushes.Black
        MyHead.Fill = Brushes.Black
        MyHead.StrokeThickness = 2
        Canvas.SetLeft(MyHead, 233)
        Canvas.SetTop(MyHead, 66)

        MyHead.RenderTransformOrigin = New Point(0.486, 0.971)
        MyTranslate.X = MyTranslate.X + motion
        MyTransformGroups.Children.Add(MyTranslate)
        MyHead.RenderTransform = MyTransformGroups
        Oscar.Children.Add(MyHead)
        Return MyHead

    End Function


    Private Function TheRightForeArm(motion As Double, i As Double, j As Double, rotx As Double, roty As Double) As Line
        Dim MyRightForeArm As New Line
        Dim MyTranslate As New TranslateTransform()
        Dim MyTransformGroups As New TransformGroup()
        Dim MyScaleTransform As New ScaleTransform()
        Dim RotateTransform As New RotateTransform()
        Dim mySkew As New SkewTransform()


        If mousescreen = True Then
            MyRightForeArm.X1 = i
            MyRightForeArm.Y1 = j

            MyRightForeArm.X2 = rotx
            MyRightForeArm.Y2 = roty
        Else
            MyRightForeArm.X1 = 280
            MyRightForeArm.Y1 = 100

            MyRightForeArm.X2 = 220
            MyRightForeArm.Y2 = 95

        End If
        MyRightForeArm.Stroke = Brushes.Black
        MyRightForeArm.StrokeThickness = 3
        MyRightForeArm.RenderTransformOrigin = New Point(0.796, 0.941)
        MyScaleTransform.ScaleX = 1
        MyScaleTransform.ScaleY = 1
        RotateTransform.Angle = 0
        MyTranslate.X = (MyTranslate.X + motion)
        mySkew.AngleX = 0
        mySkew.AngleY = 0
        MyTransformGroups.Children.Add(MyScaleTransform)
        MyTransformGroups.Children.Add(RotateTransform)
        MyTransformGroups.Children.Add(MyTranslate)
        MyTransformGroups.Children.Add(mySkew)
        MyRightForeArm.RenderTransform = MyTransformGroups
        Oscar.Children.Add(MyRightForeArm)
        Return MyRightForeArm
    End Function

    Private Function TheRightArm(motion As Double, theangle As Double) As Line
        Dim MyRightArm As New Line
        Dim MyTranslate As New TranslateTransform()
        Dim MyTransformGroups As New TransformGroup()
        Dim MyScaleTransform As New ScaleTransform()
        Dim RotateTransform As New RotateTransform()
        Dim mySkew As New SkewTransform()

        MyRightArm.X1 = 250
        MyRightArm.Y1 = 100
        MyRightArm.X2 = 220
        MyRightArm.Y2 = 95
        MyRightArm.Stroke = Brushes.Black
        MyRightArm.StrokeThickness = 3
        MyRightArm.RenderTransformOrigin = New Point(1, 0.99)
        MyScaleTransform.ScaleX = 1
        MyScaleTransform.ScaleY = 1
        RotateTransform.Angle = theangle
        MyTranslate.X = (MyTranslate.X + motion)
        mySkew.AngleX = 0
        mySkew.AngleY = 0
        MyTransformGroups.Children.Add(MyScaleTransform)
        MyTransformGroups.Children.Add(RotateTransform)
        MyTransformGroups.Children.Add(MyTranslate)
        MyTransformGroups.Children.Add(mySkew)
        MyRightArm.RenderTransform = MyTransformGroups
        Oscar.Children.Add(MyRightArm)
        Return MyRightArm

    End Function

    Private Function TheLeftArm(motion As Double, x As Double, y As Double) As Line
        Dim MyLeftArm As New Line

        Dim MyTranslate As New TranslateTransform()
        Dim MyTransformGroups As New TransformGroup()
        Dim MyScaleTransform As New ScaleTransform()
        Dim RotateTransform As New RotateTransform()
        Dim mySkew As New SkewTransform()

        MyLeftArm.X1 = 250
        MyLeftArm.Y1 = 100

        If mousescreen = True Then
            MyLeftArm.X2 = x
            MyLeftArm.Y2 = y
        Else
            MyLeftArm.X2 = 320
            MyLeftArm.Y2 = 100
        End If
        MyLeftArm.Stroke = Brushes.Black
        MyLeftArm.StrokeThickness = 3
        MyLeftArm.RenderTransformOrigin = New Point(0.781, 0.99)
        MyScaleTransform.ScaleX = 1
        MyScaleTransform.ScaleY = 1
        RotateTransform.Angle = 0
        MyTranslate.X = (MyTranslate.X + motion)
        mySkew.AngleX = 0
        mySkew.AngleY = 0
        MyTransformGroups.Children.Add(MyScaleTransform)
        MyTransformGroups.Children.Add(RotateTransform)
        MyTransformGroups.Children.Add(MyTranslate)
        MyTransformGroups.Children.Add(mySkew)
        MyLeftArm.RenderTransform = MyTransformGroups
        Oscar.Children.Add(MyLeftArm)
        Return MyLeftArm

    End Function

    Private Function TheTronch(motion As Double) As Line
        Dim MyTronch As New Line
        Dim MyTranslate As New TranslateTransform()
        Dim MyTransFormGroups As New TransformGroup()
        MyTronch.X1 = 250
        MyTronch.Y1 = 100
        MyTronch.X2 = 250
        MyTronch.Y2 = 160
        MyTronch.Stroke = Brushes.Black
        MyTronch.StrokeThickness = 3
        MyTronch.RenderTransformOrigin = New Point(0.996, 0.812)
        MyTranslate.X = MyTranslate.X + motion
        MyTransFormGroups.Children.Add(MyTranslate)
        MyTronch.RenderTransform = MyTransFormGroups
        Oscar.Children.Add(MyTronch)
        Return MyTronch
    End Function

    Function MoveUpRleg(x As Double, y As Double, CORX As Double, CORY As Double) As Line
        Dim UpRleg As New Line
        Dim RotateTransform As New RotateTransform()
        Dim MyTranslate As New TranslateTransform()
        Dim MyTransFormGroups As New TransformGroup()

        UpRleg.X1 = 250
        UpRleg.Y1 = 160
        UpRleg.X2 = 250
        UpRleg.Y2 = 190
        UpRleg.Stroke = Brushes.Green
        UpRleg.StrokeThickness = 3
        UpRleg.RenderTransformOrigin = New Point(0.996, 0.842)
        RotateTransform.Angle = y * 2
        MyTranslate.X = x

        MyTransFormGroups.Children.Add(RotateTransform)
        MyTransFormGroups.Children.Add(MyTranslate)
        UpRleg.RenderTransform = MyTransFormGroups
        Oscar.Children.Add(UpRleg)

        Return UpRleg
    End Function

    Function MoveLowRleg(X As Double, MOVE As Double, corx As Double, cory As Double, rotx As Double, roty As Double) As Line
        Dim LowRleg As New Line
        Dim RotateTransform As New RotateTransform()
        Dim MyTranslate As New TranslateTransform()
        Dim MyTransFormGroups As New TransformGroup()

        LowRleg.X1 = corx
        LowRleg.Y1 = cory
        LowRleg.X2 = rotx
        LowRleg.Y2 = roty
        LowRleg.Stroke = Brushes.Red
        LowRleg.StrokeThickness = 3
        LowRleg.RenderTransformOrigin = New Point(0.998, 0.865)
        'RotateTransform.Angle = X * 2
        MyTranslate.X = MOVE
        'MyTranslate.Y = 0


        MyTransFormGroups.Children.Add(RotateTransform)
        MyTransFormGroups.Children.Add(MyTranslate)
        LowRleg.RenderTransform = MyTransFormGroups
        Oscar.Children.Add(LowRleg)

        Return LowRleg
    End Function

    Function MoveUpLleg(x As Double, y As Double, CORX As Double, CORY As Double) As Line
        Dim UpLleg As New Line
        Dim RotateTransform As New RotateTransform()
        Dim MyTranslate As New TranslateTransform()
        Dim MyTransFormGroups As New TransformGroup()

        UpLleg.X1 = 250
        UpLleg.Y1 = 160
        UpLleg.X2 = 250
        UpLleg.Y2 = 190
        UpLleg.Stroke = Brushes.Blue
        UpLleg.StrokeThickness = 3
        UpLleg.RenderTransformOrigin = New Point(0.996, 0.842)
        RotateTransform.Angle = y * 2
        MyTranslate.X = x





        MyTransFormGroups.Children.Add(RotateTransform)
        MyTransFormGroups.Children.Add(MyTranslate)
        UpLleg.RenderTransform = MyTransFormGroups
        Oscar.Children.Add(UpLleg)
        Return UpLleg
    End Function

    Function MoveLowLleg(X As Double, MOVE As Double, corx As Double, cory As Double, rotx As Double, roty As Double) As Line
        Dim LowLleg As New Line
        Dim RotateTransform As New RotateTransform()
        Dim MyTranslate As New TranslateTransform()
        Dim MyTransFormGroups As New TransformGroup()

        LowLleg.X1 = corx
        LowLleg.Y1 = cory
        LowLleg.X2 = rotx
        LowLleg.Y2 = roty
        LowLleg.Stroke = Brushes.Yellow
        LowLleg.StrokeThickness = 3
        LowLleg.RenderTransformOrigin = New Point(0.998, 0.865)
        'RotateTransform.Angle =
        MyTranslate.X = MOVE
        'MyTranslate.Y


        MyTransFormGroups.Children.Add(RotateTransform)
        MyTransFormGroups.Children.Add(MyTranslate)
        LowLleg.RenderTransform = MyTransFormGroups
        Oscar.Children.Add(LowLleg)
        Return LowLleg
    End Function





    Private Sub MainWindow_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Dim cordexR As Double = 0
        Dim cordeyR As Double = 0
        Dim rotatexR As Double = 0
        Dim rotateyR As Double = 0

        Dim cordexL As Double = 0
        Dim cordeyL As Double = 0
        Dim rotatexL As Double = 0
        Dim rotateyL As Double = 0

        If e.Key = Key.Right Then
            moveForwardR() : moveForwardL() : movearm = True

        End If

        'has to go backwards
        If e.Key = Key.Left Then
            MoveBackwardsR() : MoveBackwardsL() : movearm = True


        End If

        cordexR = 250 + (30 * Math.Sin(-angleR * 2 * (Math.PI / 180)))
        cordeyR = 160 + (30 * Math.Cos(-angleR * 2 * (Math.PI / 180)))
        rotatexR = 250 + (30 * Math.Sin(-angleRlow * 2 * (Math.PI / 180)))
        rotateyR = 190 + (30 * Math.Cos(-angleRlow * 2 * (Math.PI / 180)))

        cordexL = 250 + (30 * Math.Sin(-angleL * 2 * (Math.PI / 180)))
        cordeyL = 160 + (30 * Math.Cos(-angleL * 2 * (Math.PI / 180)))
        rotatexL = 250 + (30 * Math.Sin(-angleLlow * 2 * (Math.PI / 180)))
        rotateyL = 190 + (30 * Math.Cos(-angleLlow * 2 * (Math.PI / 180)))

        Oscar.Children.Remove(UpLeftLeg) : Oscar.Children.Remove(UpRightLeg)
        Oscar.Children.Remove(LowRightLeg) : Oscar.Children.Remove(LowLeftLeg)
        UpLeftLeg = MoveUpLleg(MoveL, angleL, cordexL, cordeyL)
        LowLeftLeg = MoveLowLleg(angleLlow, MoveL, cordexL, cordeyL, rotatexL, rotateyL)
        UpRightLeg = MoveUpRleg(MoveR, angleR, cordexR, cordeyR)
        LowRightLeg = MoveLowRleg(angleRlow, MoveR, cordexR, cordeyR, rotatexR, rotateyR)


        Oscar.Children.Remove(Tronch)
        Oscar.Children.Remove(LeftArm) : Oscar.Children.Remove(RightArm) : Oscar.Children.Remove(RightForeArm) : Oscar.Children.Remove(Head)

        Tronch = TheTronch(MoveR) : LeftArm = TheLeftArm(MoveR, x, y) : RightArm = TheRightArm(MoveR, rightarmangle)
        RightForeArm = TheRightForeArm(MoveR, i, j, a, b) : Head = TheHead(MoveR)
        TheGround = Ground()
    End Sub

    Sub moveForwardR()
        MoveR = MoveR + 5 : angleR = angleR + 3 : angleRlow = angleRlow + 9

        If angleRlow > 18 Then
            angleR = -9
            If angleR = -9 Then
                angleRlow = -18
            Else
            End If
        End If


    End Sub

    Sub MoveBackwardsR()
        MoveR = MoveR - 5 : angleR = angleR - 3 : angleRlow = angleRlow - 9

        If angleRlow < -18 Then
            angleR = 9
            If angleR = 9 Then
                angleRlow = 18
            Else
            End If
        End If
    End Sub

    Sub moveForwardL()
        MoveL = MoveL + 5 : angleL = angleL - 3 : angleLlow = angleLlow - 7.5

        If angleLlow < -18 Then
            angleL = 6
            If angleL = 6 Then
                angleLlow = 18
            Else
            End If
        End If
    End Sub

    Sub MoveBackwardsL()
        MoveL = MoveL - 5 : angleL = angleL + 3 : angleLlow = angleLlow + 7.5

        If angleLlow > 18 Then
            angleL = -6
            If angleL = -6 Then
                angleLlow = -18
            Else
            End If
        End If
    End Sub

    Private Sub MainWindow_MouseMove(sender As Object, e As MouseEventArgs) Handles Me.MouseMove

        Dim distance As Double
        Dim distance2 As Double
        Dim Rarmlength As Double
        Dim anotherangle As Double
        Dim newangle As Double
        Dim RFarmlegth As Double

        Dim position As Point = Mouse.GetPosition(Oscar)
        mousescreen = True

        Rarmlength = Math.Sqrt((250 - 220) ^ 2 + (100 - 95) ^ 2)


        Select Case position.X
            Case >= 250
                rightarmangle = Math.Atan((100 - position.Y) / (250 - position.X)) * (180 / Math.PI)
            Case < 250
                rightarmangle = Math.Atan((100 - position.Y) / (250 - position.X)) * (180 / Math.PI) + 180
        End Select
        'rightarmangle = Math.Atan((100 - position.Y) / (250 - position.X)) * (180 / Math.PI)

        'another angle is the Angle between the rigth arm and the horizontal
        anotherangle = Math.Atan((250 - 220) / (100 - 95)) * (180 / Math.PI)
        newangle = 180 - anotherangle

        a = 250 + (Rarmlength * Math.Sin((-rightarmangle - newangle) * (Math.PI / 180)))
        b = 100 + (Rarmlength * Math.Cos((-rightarmangle - newangle) * (Math.PI / 180)))

        distance = Math.Sqrt((position.X - 250) ^ 2 + (position.Y - 100) ^ 2)
        distance2 = Math.Sqrt((position.X - a) ^ 2 + (position.Y - b) ^ 2)
        RFarmlegth = Math.Sqrt((220 - 280) ^ 2 + (100 - 95) ^ 2)

        If distance = 0 Then
            distance = 1
        End If

        If distance2 = 0 Then
            distance = 1
        End If

        i = ((RFarmlegth / distance2) * (position.X - a)) + a
        j = ((RFarmlegth / distance2) * (position.Y - b)) + b


        x = ((70 / distance) * (position.X - 250)) + 250
        y = ((70 / distance) * (position.Y - 100)) + 100


        'If movearm = True And mousescreen = True Then
        Oscar.Children.Remove(LeftArm) : Oscar.Children.Remove(RightForeArm)
            Oscar.Children.Remove(RightArm)
            LeftArm = TheLeftArm(MoveR, x, y)
            RightForeArm = TheRightForeArm(MoveR, i, j, a, b)
            RightArm = TheRightArm(MoveR, rightarmangle)
        'Else
        'End If

    End Sub
End Class


