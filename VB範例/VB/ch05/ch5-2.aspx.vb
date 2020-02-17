
Partial Class ch5_2
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim Temp As String = ""
        Dim intIndex As Integer
        For intIndex = 0 To CheckBoxList1.Items.Count - 1
            If CheckBoxList1.Items(intIndex).Selected Then
                Temp &= CheckBoxList1.Items(intIndex).Text.ToString & vbCr
            End If
        Next
        TextBox1.Text = Temp
    End Sub
End Class
