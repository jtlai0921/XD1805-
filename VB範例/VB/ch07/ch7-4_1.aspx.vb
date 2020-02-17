
Partial Class ch7_4_1
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Session("Teacher_name") = "Benson_Hung"
        Response.Write("<a href=ch7-4_1a.aspx?name=" & Session("Teacher_name") & ">我的授課老師" & "</a>")
    End Sub
End Class
