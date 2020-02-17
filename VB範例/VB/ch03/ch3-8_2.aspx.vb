
Partial Class ch3_8_2
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim X, Y As Integer
        X = 5
        Y = 10
        Response.Write("「傳值呼叫」呼叫前<hr>")
        Response.Write("X=" & X & "　　　" & "Y=" & Y & "<br>")
        Call CallByValue(X, Y)
        Response.Write("「傳值呼叫」呼叫後<hr>")
        Response.Write("X=" & X & "　　　" & "Y=" & Y & "<br>")
    End Sub

    Sub CallByValue(ByVal A As Integer, ByVal B As Integer)
        A = 15
        B = 30
    End Sub

    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        Dim X, Y As Integer
        X = 5
        Y = 10
        Response.Write("「傳址呼叫」呼叫前<hr>")
        Response.Write("X=" & X & "　　　" & "Y=" & Y & "<br>")
        Call CallByAddress(X, Y)
        Response.Write("「傳址呼叫」呼叫後<hr>")
        Response.Write("X=" & X & "　　　" & "Y=" & Y & "<br>")
    End Sub

    Sub CallByAddress(ByRef A As Integer, ByRef B As Integer)
        A = 15
        B = 30
    End Sub
End Class
