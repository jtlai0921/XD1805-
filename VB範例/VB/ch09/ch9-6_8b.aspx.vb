
Partial Class ch9_7_8b
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Session("Stu_Id") = Request.QueryString("Stu_Id")
        Response.Write("傳遞的值為：" & Session("Stu_Id"))
    End Sub
End Class
