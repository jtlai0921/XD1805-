
Partial Class ch5_3
    Inherits System.Web.UI.Page

    Protected Sub RadioButton1_CheckedChanged(sender As Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            Label1.Text = RadioButton1.Text
        End If
    End Sub

    Protected Sub RadioButton2_CheckedChanged(sender As Object, e As System.EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked = True Then
            Label1.Text = RadioButton2.Text
        End If
    End Sub
End Class
