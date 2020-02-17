
Partial Class ch10_1_3a
    Inherits System.Web.UI.Page

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        Label1.Text = "您剛才選取：" & DropDownList1.SelectedItem.Text & " 同學"
    End Sub
End Class
