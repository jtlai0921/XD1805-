﻿
Partial Class ch7_6_2
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        '文字模式計數器                    
        Application.Lock()   '鎖定Application物件
        Application("ArriveCounter") = Application("ArriveCounter") + 1
        Application.UnLock() '解除Application物件的鎖定                   
        Response.Write("《這是一個文字模式計數器》" & "<br>")
        Response.Write("你是本站的第" & Application("ArriveCounter") & "位貴賓")
    End Sub
End Class
