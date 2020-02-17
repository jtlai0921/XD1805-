
Partial Class ch3_6_1
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim A, B, C, D As Single
        A = 20         '將20指定給A
        B = 40         '將40指定給B
        C = A + B      '將A與B的值相加後，再指定給C
        D = A / B      '將A與B的值相除後，再指定給D
        Response.Write("C=" & C)
        Response.Write("<br>")
        Response.Write("D=" & D)
    End Sub
End Class
