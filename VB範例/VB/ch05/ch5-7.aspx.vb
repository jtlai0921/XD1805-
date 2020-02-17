
Partial Class ch5_7
    Inherits System.Web.UI.Page

    Protected Sub Calendar1_SelectionChanged(sender As Object, e As System.EventArgs) Handles Calendar1.SelectionChanged
        Label1.Text = "您剛才點選的日期為：" & Calendar1.SelectedDate
    End Sub
End Class
