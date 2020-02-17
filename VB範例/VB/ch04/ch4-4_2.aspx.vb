
Partial Class ch4_4_2
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Label1.Text = "您剛才按了==>按鈕控制項"
    End Sub

    Protected Sub LinkButton1_Click(sender As Object, e As System.EventArgs) Handles LinkButton1.Click
        Label1.Text = "您剛才按了==>超連結按鈕控制項"
    End Sub
End Class
