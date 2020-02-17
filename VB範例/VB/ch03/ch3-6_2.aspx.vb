
Partial Class ch3_6_2
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        Dim Score As Integer = 50
        If Score < 60 Then
            MsgBox("您必須補考")
            MsgBox("請再多加油哦！")
            MsgBox("希望補考能夠順利通過")
        End If
    End Sub

    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        Dim Score As Integer = 50
        If Score >= 60 Then
            MsgBox("及格")
        Else
            MsgBox("不及格")
        End If
    End Sub

    Protected Sub Button3_Click(sender As Object, e As System.EventArgs) Handles Button3.Click
        Dim aver As Integer = 50
        Dim result As String
        If aver < 60 Then
            result = "要重修了"
        ElseIf aver >= 60 And aver < 70 Then
            result = "丙等生"
        ElseIf aver >= 70 And aver < 80 Then
            result = "乙等生"
        ElseIf aver >= 80 And aver < 90 Then
            result = "甲等生"
        Else
            result = "優等生"
        End If
        MsgBox(result)
    End Sub

    Protected Sub Button4_Click(sender As Object, e As System.EventArgs) Handles Button4.Click
        Dim aver As Integer = 90
        Dim result As String
        Select Case aver
            Case Is < 60
                result = "要重修了"
            Case 60 To 69
                result = "丙等生"
            Case 70 To 79
                result = "乙等生"
            Case 80 To 89
                result = "甲等生"
            Case Else
                result = "優等生"
        End Select
        MsgBox(result)
    End Sub

    Protected Sub Button5_Click(sender As Object, e As System.EventArgs) Handles Button5.Click
        Dim aver As Integer = 90
        Dim vb As Integer = 100
        Dim result As String
        If aver >= 80 Then
            If vb = 100 Then
                result = "你學業成績不錯，VB程式設計更是高手!!!"
            Else
                result = "你學業成績不錯"
            End If
        Else
            result = "你學業成績還需加油!!!"
        End If
        MsgBox(result)
    End Sub
End Class
