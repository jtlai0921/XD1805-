
Partial Class ch7_3a
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim chi, eng, average, total As Integer
        '輸入資料
        chi = Val(InputBox("請輸入國文成績：", "國文成績"))
        eng = Val(InputBox("請輸入英文成績：", "英文成績"))
        '處理資料
        total = chi + eng
        average = total / 2
        '輸出結果
        Label1.Text = chi
        Label2.Text = eng
        Label3.Text = average
    End Sub
End Class
