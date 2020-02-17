
Partial Class ch3_1_2
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim Stu_Name As String
        Dim Chi_Score, Eng_Score, Aver As Single
        Stu_Name = TextBox1.Text
        Chi_Score = Val(TextBox2.Text)
        Eng_Score = Val(TextBox3.Text) 'kkk
        Aver = (Chi_Score + Eng_Score) / 2
        Label1.Text = Stu_Name & "==>" & Aver & "分"
    End Sub
End Class
