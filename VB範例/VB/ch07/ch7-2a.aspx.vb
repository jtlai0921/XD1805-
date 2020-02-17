
Partial Class ch7_2a
    Inherits System.Web.UI.Page

    Protected Sub ImageButton1_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton1.Click
        MsgBox("回覆按鈕設定值：vbCritical", vbCritical)
    End Sub

    Protected Sub ImageButton2_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton2.Click
        MsgBox("回覆按鈕設定值：VbQuestion", vbQuestion)
    End Sub

    Protected Sub ImageButton3_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton3.Click
        MsgBox("回覆按鈕設定值：vbExclamation", vbExclamation)
    End Sub

    Protected Sub ImageButton4_Click(sender As Object, e As System.Web.UI.ImageClickEventArgs) Handles ImageButton4.Click
        MsgBox("回覆按鈕設定值：vbInformation", vbInformation)
    End Sub
End Class
