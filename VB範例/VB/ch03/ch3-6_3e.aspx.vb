
Partial Class ch3_6_3e
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) ' Handles Button1.Click
        Dim A As Integer = 2
        Dim I As Integer = 1
        While A < 1000
            A *= 2
            I += 1
        End While
        Response.Write("2的 " & I & " 次方才會大於1,000")
    End Sub
End Class
