
Partial Class ch3_8_1
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Call MytestSub()  '呼叫副程式
    End Sub

    Sub MytestSub()   '被呼叫的副程式
        Response.Write("副程式測試")
    End Sub
End Class
