
Partial Class ch5_1
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim temp As String = ""
        If CheckBox1.Checked = True Then
            temp &= CheckBox1.Text & vbCr
        End If
        If CheckBox2.Checked = True Then
            temp &= CheckBox2.Text & vbCr
        End If
        If CheckBox3.Checked = True Then
            temp &= CheckBox3.Text & vbCr
        End If
        TextBox1.Text = temp
    End Sub
End Class
