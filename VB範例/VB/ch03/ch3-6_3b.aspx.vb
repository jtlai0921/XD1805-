
Partial Class ch3_6_3b
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) 'Handles Button1.Click
        Dim i, j As Integer
        Response.Write("<center>")
        Response.Write("題目：九九乘法表的程式" & "<br>")
        Response.Write("<table border=4>")
        For i = 1 To 9
            Response.Write("<tr>")
            For j = 1 To 9
                Response.Write("<td>" & i & "*" & j & "=" & i * j)
            Next j
            Response.Write("</tr>")
        Next i
        Response.Write("</table>")
        Response.Write("</center>")
    End Sub
End Class
