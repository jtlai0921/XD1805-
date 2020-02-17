
Partial Class ch12_1_5a
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Me.IsPostBack = False Then buildTreeView()
    End Sub
    Sub buildTreeView()
        '清空tree view
        Me.TreeView1.Nodes.Clear()
        '建立節點
        BuildChild(0, Me.TreeView1.Nodes)
    End Sub
    '建立子節點的遞迴函式
    Sub BuildChild(ByVal RootUid As Integer, ByRef Nodes As Web.UI.WebControls.TreeNodeCollection)
        AccessDataSource1.SelectCommand = "select * from TreeView資料表 where 根節點=" & RootUid
        Dim dv As Data.DataView = AccessDataSource1.Select(New DataSourceSelectArguments)
        For i As Integer = 0 To dv.Count - 1
            Dim NewNode As TreeNode
            NewNode = New TreeNode
            NewNode.Text = dv.Item(i).Item("章節編號") & " " & dv.Item(i).Item("章節名稱")
            Nodes.Add(NewNode)
            BuildChild(dv.Item(i).Item("單元序號"), NewNode.ChildNodes)
        Next
    End Sub
    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Label1.Text = ""
        Dim i As Integer
        Dim count As Integer = 1
        For i = 0 To TreeView1.CheckedNodes.Count - 1
            Label1.Text = Label1.Text & "<br><b>" & count & "</b>　" & TreeView1.CheckedNodes(i).Text
            count += 1
        Next
    End Sub
End Class
