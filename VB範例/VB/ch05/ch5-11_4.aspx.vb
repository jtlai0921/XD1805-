
Partial Class ch15_11_4
    Inherits System.Web.UI.Page

    Protected Sub Wizard1_FinishButtonClick(sender As Object, e As System.Web.UI.WebControls.WizardNavigationEventArgs) Handles Wizard1.FinishButtonClick
        Label1.Text = "您的姓名：" & TextBox2.Text
        Label1.Text &= "<br>您喜愛的課程：" & DropDownList1.Text
        Label1.Text &= "<br>帳號：" & TextBox3.Text
        Label1.Text &= "<br>密碼：" & TextBox4.Text
    End Sub

End Class
