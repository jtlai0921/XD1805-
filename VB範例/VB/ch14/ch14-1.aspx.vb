Imports System.Data
Imports System.Data.OleDb
Partial Class ch14_1
    Inherits System.Web.UI.Page

    Protected Sub Button1_Click(sender As Object, e As System.EventArgs) Handles Button1.Click
        If TextBox1.Text <> "" Then
            '宣告資料庫所在的路徑變數
            Dim dbpath As String = "C:\Inetpub\wwwroot\ASPNET\ch14\App_Data\DBMS.mdb" '請務必注意資料庫路徑
            Dim Source As String                     '宣告連線的字串
            Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbpath
            Dim conn As OleDbConnection              '宣告連線的物件
            conn = New OleDbConnection(Source)       '連線
            conn.Open()                              '開啟資料庫
            ' 開啟資料庫
            Dim SelectCmd As String
            SelectCmd = TextBox1.Text
            '宣告物件
            Dim DtApter As OleDbDataAdapter
            Dim DtSet As DataSet
            DtApter = New OleDbDataAdapter(SelectCmd, conn)
            DtSet = New DataSet
            '讀取資料表
            DtApter.Fill(DtSet, "Table")
            GridView1.DataSource = DtSet.Tables("Table")
            GridView1.DataBind()
            conn.Close()         '關閉資料庫
        Else
            MsgBox("您尚未撰寫SQL指令！")
        End If
    End Sub
End Class
