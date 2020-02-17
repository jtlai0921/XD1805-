
Partial Class ch3_2_1
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        '使用範例時請將MyInt、Dim MyVar與MyVar前方的「 ' 」符號刪除

        'Dim MyVar   '宣告變數
        'MyInt = 10  '使用到未宣告的變數將會產生錯誤
        'MyVar = 20  '使用宣告過的變數就沒有錯誤
    End Sub
End Class
