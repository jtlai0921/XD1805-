Imports System.IO
Partial Class ch13_4_4
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        ' 取得實際路徑
        Dim Path As String = Server.MapPath(Request.ServerVariables("PATH_INFO"))
        ' 建立FileInfo物件
        Dim FileInfo As FileInfo = New FileInfo(Path)
        ' 顯示檔案資訊
        Response.Write("檔案名稱: " & FileInfo.Name & "<br/>")
        Response.Write("檔案全名: " & FileInfo.FullName & "<br/>")
        Response.Write("檔案副檔名: " & FileInfo.Extension & "<br/>")
        Response.Write("父資料夾名稱: " & FileInfo.Directory.Name & "<br/>")
        Response.Write("父資料夾全名: " & FileInfo.DirectoryName & "<br/>")
        Response.Write("建立日期: " & FileInfo.CreationTime & "<br/>")
        Response.Write("最後存取時間: " & FileInfo.LastAccessTime & "<br/>")
        Response.Write("最後修改時間: " & FileInfo.LastWriteTime & "<br/>")
        Response.Write("檔案大小: " & FileInfo.Length & "<br/>")
    End Sub
End Class
