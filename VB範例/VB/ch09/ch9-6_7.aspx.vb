
Partial Class ch9_6_7
    Inherits System.Web.UI.Page

    Protected Sub GridView1_RowCommand(sender As Object, e As System.Web.UI.WebControls.GridViewCommandEventArgs) Handles GridView1.RowCommand
        Dim RowIndex = e.CommandArgument
        Dim Stu_Name As String = GridView1.Rows(RowIndex).Cells(2).Text
        Dim DB_Score As Integer = Val(GridView1.Rows(RowIndex).Cells(3).Text)
        Dim SA_Score As Integer = Val(GridView1.Rows(RowIndex).Cells(4).Text)
        Dim ASP_NET_Score As Integer = Val(GridView1.Rows(RowIndex).Cells(5).Text)
        Dim PC_Score As Integer = Val(GridView1.Rows(RowIndex).Cells(5).Text)
        Dim Sum = DB_Score + SA_Score + ASP_NET_Score + PC_Score
        If e.CommandName = "Sum" Then
            Label1.Text = Stu_Name & " 同學的總分為：" & Sum
        End If
    End Sub
End Class
