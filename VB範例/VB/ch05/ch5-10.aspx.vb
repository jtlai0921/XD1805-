
Partial Class ch5_10
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text = "Benson" And TextBox2.Text = "1012" Then
            Label1.Text = TextBox1.Text
            MultiView1.ActiveViewIndex = 1
        Else
            MsgBox("帳號或密碼有誤！")
        End If
    End Sub
    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        MultiView1.ActiveViewIndex = 0
    End Sub
    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Label1.Text = ""
    End Sub
End Class
