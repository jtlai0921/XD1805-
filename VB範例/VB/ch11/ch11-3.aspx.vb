
Partial Class ch11_3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim result As Integer
        Dim webs As ServiceReference1.ch11_3SoapClient = New ServiceReference1.ch11_3SoapClient()
        result = webs.Add(5, 8)
        Response.Write(result)
    End Sub
End Class
