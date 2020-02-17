
Partial Class ch7_2
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        MsgBox("回覆按鈕設定值：vbOkOnly", vbOKOnly)
    End Sub

    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        MsgBox("回覆按鈕設定值：vbOkCancel", vbOKCancel)
    End Sub

    Protected Sub Button3_Click(sender As Object, e As System.EventArgs) Handles Button3.Click
        MsgBox("回覆按鈕設定值：vbAbortRetryIgnore", vbAbortRetryIgnore)
    End Sub

    Protected Sub Button4_Click(sender As Object, e As System.EventArgs) Handles Button4.Click
        MsgBox("回覆按鈕設定值：vbYesNoCancel", vbYesNoCancel)
    End Sub

    Protected Sub Button5_Click(sender As Object, e As System.EventArgs) Handles Button5.Click
        MsgBox("回覆按鈕設定值：vbYesNo", vbYesNo)
    End Sub

    Protected Sub Button6_Click(sender As Object, e As System.EventArgs) Handles Button6.Click
        MsgBox("回覆按鈕設定值：vbRetryCancel", vbRetryCancel)
    End Sub
End Class
