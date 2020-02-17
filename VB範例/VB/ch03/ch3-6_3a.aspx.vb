
Partial Class ch3_6_3a
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) ' Handles Button1.Click
        Randomize()
        Dim A(6) As Integer
        Dim i, j, Point_Num As Integer
        For i = 1 To 100
            Point_Num = Int(Rnd() * 6 + 1)
            A(Point_Num) = A(Point_Num) + 1
        Next
        For j = 1 To 6
            Response.Write(j & "點" & "　" & A(j) & "次" & "<br>")
        Next j
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Response.Write("題目：利用亂數函數投擲骰子100次" & "<br>")
    End Sub
End Class
