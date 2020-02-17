
Partial Class ch7_1_3a
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim Chi_Score As Single = 77.5
        Dim Eng_Score As Single = 90
        Dim Math_Score As Single = 85
        Dim Total, Aver As Single
        Response.Write("您的國文成績：" & Chi_Score & "<br>")
        Response.Write("您的英文成績：" & Eng_Score & "<br>")
        Response.Write("您的數學成績：" & Math_Score & "<br>")
        Response.End()  '強迫網頁結束
        Total = Chi_Score + Eng_Score + Math_Score
        Aver = Total / 3
        Response.Write("您的總分：" & Total)
        Response.Write("您的平均成績：" & Aver)
    End Sub
End Class
