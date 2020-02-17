
Partial Class ch2_2_3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Button1.Text = "計算平均"
    End Sub

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim a, b, average As Integer
        a = 60
        b = 70
        average = (a + b) / 2
        MsgBox("平均成績：" & average)
    End Sub

End Class
