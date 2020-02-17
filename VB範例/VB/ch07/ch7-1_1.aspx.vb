
Partial Class ch7_1_1
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Response.Write("您好嗎？")  '字串資料必須加上雙引號「""」
    End Sub

    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        Response.Write(Now)          '變數資料不能上雙引號「""」
    End Sub

    Protected Sub Button3_Click(sender As Object, e As System.EventArgs) Handles Button3.Click
        Response.Write("現在時間是：" & Now)   '&代表連結符號
    End Sub
End Class
