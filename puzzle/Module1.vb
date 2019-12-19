Module Module1
    Sub cblev1(ByRef button1 As Button, ByRef button2 As Button)
        If button2.Text = "" Then
            button2.Text = button1.Text
            button2.BackgroundImage = button1.BackgroundImage
            button1.Text = ""
            button1.BackgroundImage = Nothing
        End If
    End Sub
End Module
