
Partial Class ch7_2b
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim Msg_Value As String
        Msg_Value = MsgBox("這是一筆重要的機密資料" + Chr(13) + "你的確定要刪除嗎?", vbQuestion + vbYesNo, "刪除記錄")
        If Msg_Value = vbYes Then
            MsgBox("機密資料刪除成功了!!!", , "刪除成功了")
        Else
            MsgBox("不刪除了!!!", , "刪除失敗")
        End If
    End Sub
End Class
