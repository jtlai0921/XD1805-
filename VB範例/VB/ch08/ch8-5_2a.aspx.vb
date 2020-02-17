Partial Class ch8_5_2a
    Inherits link_table
    Dim SelectCmd = "select * from 學生資料表"
    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            ds.DataSource = get_table(SelectCmd)
            ds.DataBind()
        End If
    End Sub
    Sub show_detail(ByVal s As Object, ByVal e As DataListCommandEventArgs)
        If e.CommandName = "show" Then
            ds.SelectedIndex = e.Item.ItemIndex
        ElseIf e.CommandName = "close" Then
            ds.SelectedIndex = -1
        End If
        ds.DataSource = get_table(SelectCmd)
        ds.DataBind()
    End Sub
End Class
