Imports System.Data
Partial Class ch8_5
    Inherits link_table
    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim m_tb As DataTable
        Dim SelectCmd As String
        SelectCmd = "select * from 學生資料表"
        m_tb = get_table(SelectCmd)
        Response.Write(" <h4> 使用DataAdapter 與 DataSet</h4>")
        Response.Write("<Table Border=2>")
        Response.Write("<Tr Align=Center> ")
        Dim k, j As Integer
        For k = 0 To m_tb.Columns.Count - 1
            Response.Write("<Td>")
            Response.Write(m_tb.Columns(k).ColumnName)
            Response.Write("</Td>")
        Next
        Response.Write("</Tr>")
        For k = 0 To m_tb.Rows.Count - 1
            Response.Write("<Tr Align=Center> ")
            For j = 0 To m_tb.Columns.Count - 1
                Response.Write("<Td>")
                Response.Write(m_tb.Rows(k).Item(j))
                Response.Write("</Td>")
            Next
            Response.Write("</Tr>")
        Next
        Response.Write("</Table>")
    End Sub
End Class