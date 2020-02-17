
Partial Class ch9_6_3a
    Inherits System.Web.UI.Page
    '遞增排序
    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        GridView1.Sort(DropDownList1.SelectedValue, SortDirection.Ascending)
    End Sub
    '遞減排序
    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        GridView1.Sort(DropDownList1.SelectedValue, SortDirection.Descending)
    End Sub
End Class
