Imports System.IO
Partial Class ch13_4_3
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim Path As String = Server.MapPath("FileSystem\text3文字檔.txt")
        ' 建立FileInfo物件
        Dim FileInfo As FileInfo = New FileInfo(Path)
        If FileInfo.Exists Then
            FileInfo.Delete()   ' 刪除檔案
            Response.Write("已經刪除指定的檔案")
        Else
            Response.Write("您所指定的檔案不存在，故無法執行刪除動作！")
        End If
    End Sub
End Class
