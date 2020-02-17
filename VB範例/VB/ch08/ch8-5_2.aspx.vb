Partial Class ch8_5_2
    Inherits link_table

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim SelectCmd As String
        SelectCmd = "select * from 學生資料表"
        ds.DataSource = get_table(SelectCmd)
        ds.DataBind()
    End Sub
End Class
