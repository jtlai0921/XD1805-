
Partial Class ch7_1_3b
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim UserName As String
        Dim Password As String
        UserName = ""
        Password = "12345"
        If UserName = "" Then
            Response.Write("對不起，你沒有輸入帳號")
            Response.End()
        End If
        If Password = "" Then
            Response.Write("對不起，你沒有輸入密碼")
            Response.End()
        End If
        Response.Write(UserName & "請記住您註冊的密碼：" & Password)
    End Sub
End Class
