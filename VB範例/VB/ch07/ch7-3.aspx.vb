
Partial Class ch7_3
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim Str1 As String = ""
        Str1 = InputBox("請輸入文字，Quit 表示輸入完畢", "顯示鍵盤所輸入的文字", "Test")
        MsgBox("您輸入的是" & Str1)
    End Sub
End Class
