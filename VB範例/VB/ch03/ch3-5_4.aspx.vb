
Partial Class ch3_5_4
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim Average As Integer
        Dim Result As String
        Average = 50
        If Average < 60 Then
            Result = "丁等生"
        ElseIf Average >= 60 And Average < 70 Then
            Result = "丙等生"
        ElseIf Average >= 70 And Average < 80 Then
            Result = "乙等生"
        ElseIf Average >= 80 And Average < 90 Then
            Result = "甲等生"
        Else
            Result = "優等生"
        End If
        MsgBox(Result)
    End Sub
End Class
