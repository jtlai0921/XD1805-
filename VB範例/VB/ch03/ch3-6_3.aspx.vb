
Partial Class ch3_6_3
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Response.Write("求1+2+3+...+10的程式")
        Dim i, sum As Integer
        sum = 0
        For i = 1 To 10
            sum = sum + i
        Next
        Response.Write("總和是：" & sum)
    End Sub
End Class
