
Partial Class ch3_4
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        REM ===設計一個求圓面積與圓周長的程式===
        REM 宣告變數
        Dim A As Single              '宣告「圓面積」變數
        Dim L As Single              '宣告「圓周長」變數
        Dim R As Integer             '宣告「半徑」變數
        Const PI As Single = 3.14    '宣告「圓周率」為.14的常數
        R = 3                        '初值設定
        REM 處理
        A = PI * R ^ 2               '計算圓面積
        L = 2 * PI * R               '計算圓周長
        REM 輸出
        MsgBox("圓面積=" & A & vbNewLine & "圓周長=" & L)
    End Sub
End Class
