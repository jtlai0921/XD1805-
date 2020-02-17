Imports System.Data
Partial Class ch8_5_3
    Inherits link_table
    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim SelectCmd As String
        SelectCmd = "select * from 學生資料表"
        Dim tb As DataTable = get_table(SelectCmd)
        GridView1.DataSource = tb
        GridView1.DataBind()
    End Sub
End Class

