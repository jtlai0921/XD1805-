
Partial Class ch7_1_2
    Inherits System.Web.UI.Page

    Protected Sub DropDownList1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles DropDownList1.SelectedIndexChanged
        If DropDownList1.SelectedValue = "1" Then
            Response.Redirect("http://www.ntu.edu.tw")
        ElseIf DropDownList1.SelectedValue = "2" Then
            Response.Redirect("http://www.ntust.edu.tw")
        ElseIf DropDownList1.SelectedValue = "3" Then
            Response.Redirect("http://www.nsysu.edu.tw")
        ElseIf DropDownList1.SelectedValue = "4" Then
            Response.Redirect("http://www.csu.edu.tw")
        End If

    End Sub
End Class
