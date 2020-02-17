
Partial Class ch5_6
    Inherits System.Web.UI.Page

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        Label1.Text = DropDownList1.SelectedItem.Text.ToString
    End Sub
End Class
