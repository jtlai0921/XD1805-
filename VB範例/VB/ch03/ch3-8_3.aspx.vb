
Partial Class ch3_8_3
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim Sum As Integer
        Sum = MyFunction(10)   '呼叫函數
        Response.Write("1+2+...+10=" & Sum)
    End Sub

    Function MyFunction(ByVal X As Integer) As Integer    '被呼叫的函數
        Dim i, total As Integer
        For i = 1 To X
            total = total + i
        Next
        MyFunction = total
    End Function

    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        Dim Result As Integer
        Dim X As Integer = 10
        Result = Total(X)
        Response.Write("遞迴函數呼叫10!=1×2×3×4×5×6×....×10=" & Result)
    End Sub

    Function Total(ByVal N As Integer) As Integer                '函數名稱
        If N = 0 Then
            Total = 1
        Else
            Total = N * Total(N - 1)        '函數自己又可以呼叫自己
        End If
    End Function

End Class
