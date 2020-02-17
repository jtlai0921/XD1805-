
Partial Class ch3_7_3
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) ' Handles Button1.Click
        Dim A(4) As Integer
        Dim i, sum As Integer
        For i = 0 To 4
            A(i) = InputBox("請輸入成績 " & i & "：")
        Next i
        sum = A(0) + A(1) + A(2) + A(3) + A(4)
        Label1.Text = "總和為：" & sum
    End Sub

    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) ' Handles Button2.Click
        Dim A(4) As Integer
        Dim i, sum As Integer
        For i = 0 To 4
            A(i) = InputBox("請輸入成績 " & i & "：")
            sum = sum + A(i)
        Next i
        Label1.Text = "總和為：" & sum
    End Sub
End Class
