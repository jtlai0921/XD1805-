﻿
Partial Class ch3_6_3g
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) ' Handles Button1.Click
        Response.Write("題目：利用Do---Loop Until來求1+2+3+...+10的程式" & "<br><hr>")
        Dim X, sum As Integer
        X = 0
        sum = 0
        Do
            sum = sum + X
            X = X + 1
        Loop Until X > 10
        Response.Write("總和是：" & sum)
    End Sub
End Class
