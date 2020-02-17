
Partial Class ch9_6_6a
    Inherits System.Web.UI.Page

    Protected Sub GridView1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles GridView1.SelectedIndexChanged
        Label1.Text = GridView1.SelectedRow.Cells(3).Text & "同學"
    End Sub
End Class
