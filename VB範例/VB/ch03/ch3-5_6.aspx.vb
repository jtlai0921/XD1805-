
Partial Class ch3_5_6
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim R As Integer = 5
        Response.Write("圓的半徑是：" & R)
    End Sub

    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        Response.Write("圓面積是：" & "圓周率*半徑^2")
    End Sub

    Protected Sub Button3_Click(sender As Object, e As System.EventArgs) Handles Button3.Click
        Dim R As Integer = 5
        Const PI As Single = 3.14
        Response.Write("圓面積是：" & PI * R ^ 2)
    End Sub

    Protected Sub Button4_Click(sender As Object, e As System.EventArgs) Handles Button4.Click
        Dim A As Integer = 3
        Dim B As Integer = 5
        Response.Write(A + B)    '結果：8
    End Sub

    Protected Sub Button5_Click(sender As Object, e As System.EventArgs) Handles Button5.Click
        Dim A As Char = "3"
        Dim B As Char = "5"
        Response.Write(A + B)    '結果：35
    End Sub
End Class
