
Partial Class ch3_2_2
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim i, Sum As Integer
        For i = 1 To 10
            '使用範例時請將Sum = Sun + 1前方的「 ' 」符號刪除
            'Sum = Sun + 1
        Next i
        MsgBox("總數是：" & Sum)
    End Sub
End Class
