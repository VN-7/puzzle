﻿Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        '24
        cblev1(Button1, Button2)
        cblev1(Button1, Button4)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        '135
        cblev1(Button2, Button1)
        cblev1(Button2, Button3)
        cblev1(Button2, Button5)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        '26
        cblev1(Button3, Button2)
        cblev1(Button3, Button6)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        '157
        cblev1(Button4, Button1)
        cblev1(Button4, Button5)
        cblev1(Button4, Button7)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        '2468
        cblev1(Button5, Button2)
        cblev1(Button5, Button4)
        cblev1(Button5, Button6)
        cblev1(Button5, Button8)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        '359
        cblev1(Button6, Button3)
        cblev1(Button6, Button5)
        cblev1(Button6, Button9)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        '48
        cblev1(Button7, Button4)
        cblev1(Button7, Button8)
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        '579
        cblev1(Button8, Button5)
        cblev1(Button8, Button7)
        cblev1(Button8, Button9)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        '68
        cblev1(Button9, Button6)
        cblev1(Button9, Button8)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.BackgroundImage = My.Resources._1
        Button2.BackgroundImage = My.Resources._2
        Button3.BackgroundImage = My.Resources._3
        Button4.BackgroundImage = My.Resources._4
        Button5.BackgroundImage = My.Resources._5
        Button6.BackgroundImage = My.Resources._6
        Button7.BackgroundImage = My.Resources._7
        Button8.BackgroundImage = My.Resources._8
    End Sub
End Class
