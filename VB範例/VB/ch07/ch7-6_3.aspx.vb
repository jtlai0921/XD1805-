
Partial Class ch7_6_3
    Inherits System.Web.UI.Page

    Function GCount(ByVal Counter As Long) As String
        Dim i, SCounter As Integer
        Dim cimg As String = ""
        SCounter = CStr(Counter)
        For i = 1 To Len(SCounter) - 2
            '載入數字的圖片            
            cimg = cimg & "<IMG SRC=images/" & Mid(SCounter, i, 1) & ".bmp>"
        Next i
        GCount = cimg
    End Function

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        '圖形化計數器                    
        Application("ArriveCounter") = Application("ArriveCounter") + 1
        '顯示圖形化計數器的函數    
        Response.Write("《這是一個圖形化計數器》" & "<br>")
        Response.Write("你是本站的第" & GCount(Application("ArriveCounter")) & "位貴賓")
    End Sub
End Class
