
Partial Class ch5_5
    Inherits System.Web.UI.Page

    Protected Sub ListBox1_SelectedIndexChanged(sender As Object, e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        Dim Temp As String = ""
        Dim intIndex As Integer
        '用迴圈從 ListBox1 由前至後逐一讀取各項目
        For intIndex = 0 To ListBox1.Items.Count - 1
            '若 Selected 屬性為 True，表示使用者已選擇此項
            If ListBox1.Items(intIndex).Selected Then
                Temp &= ListBox1.Items(intIndex).Text.ToString & " "
            End If
        Next
        Label1.Text = Temp
    End Sub
End Class
