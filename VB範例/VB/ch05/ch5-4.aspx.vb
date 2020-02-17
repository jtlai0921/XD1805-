
Partial Class ch5_4
    Inherits System.Web.UI.Page

    Protected Sub RadioButtonList1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles RadioButtonList1.SelectedIndexChanged
        Label1.Text = RadioButtonList1.SelectedItem.Text
    End Sub
End Class
