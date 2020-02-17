Imports System.Data
Imports System.Data.OleDb
Partial Class ch14_2b
    Inherits System.Web.UI.Page
    Dim conn As OleDbConnection              '宣告連線的物件

    Protected Sub Menu1_MenuItemClick(sender As Object, e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu1.MenuItemClick
        MultiView1.ActiveViewIndex = Menu1.SelectedValue
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Call Show_Record1()    '呼叫設定系碼[顯示科系代碼表]
        Call Show_Record2()    '呼叫課程管理[顯示課程管理表]
    End Sub

    Sub Con_DB()    '連接資料庫之副程式
        '宣告資料庫所在的路徑變數
        Dim dbpath As String = "C:\Inetpub\wwwroot\ASPNET\ch14\App_Data\DBMS1.mdb"
        Dim Source As String                     '宣告連線的字串
        Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbpath
        conn = New OleDbConnection(Source)       '連線
        conn.Open()                              '開啟資料庫
    End Sub

    Sub Show_Record1()   '設定系碼[顯示科系代碼表]
        Call Con_DB()    '呼叫連接資料庫之副程式
        ' 開啟資料庫
        Dim SelectCmd As String
        SelectCmd = "select * from 科系代碼資料表 order by 系碼 ASC"
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
    End Sub

    Sub Show_Record2()   '課程管理[顯示課程管理表]
        Call Con_DB()    '呼叫連接資料庫之副程式
        ' 開啟資料庫
        Dim SelectCmd As String
        SelectCmd = "select * from 課程資料表 order by 課號 ASC"
        '宣告物件
        Dim DtApter As OleDbDataAdapter
        Dim DtSet As DataSet
        DtApter = New OleDbDataAdapter(SelectCmd, conn)
        DtSet = New DataSet
        '讀取資料表
        DtApter.Fill(DtSet, "Table")
        GridView2.DataSource = DtSet.Tables("Table")
        GridView2.DataBind()
        conn.Close()         '關閉資料庫
    End Sub

    '設定系碼[查詢功能]
    Protected Sub Button1_Click1(sender As Object, e As System.EventArgs) Handles Button1.Click
        ID = InputBox("請輸入系碼")
        Call Con_DB()    '呼叫連接資料庫之副程式
        Dim SelectCmd As String
        SelectCmd = "select * from 科系代碼資料表 Where 系碼='" & ID & "'"
        Dim Cmd As OleDbCommand = New OleDbCommand(SelectCmd, conn)
        Dim reader As OleDbDataReader
        reader = Cmd.ExecuteReader()
        '顯示資料表欄位的所有資料
        While reader.Read()
            TextBox1.Text = reader.Item("系碼")
            TextBox2.Text = reader.Item("系名")
            TextBox3.Text = reader.Item("系主任")
        End While
        conn.Close()                       ' 關閉資料庫
    End Sub

    '一、設定系碼[新增功能]
    Protected Sub Button2_Click(sender As Object, e As System.EventArgs) Handles Button2.Click
        Call Con_DB()    '呼叫連接資料庫之副程式
        Dim InsertCmd As String
        InsertCmd = "Insert Into 科系代碼資料表(系碼,系名,系主任) Values('" & TextBox1.Text.Trim() & "','" & TextBox2.Text.Trim() & "','" & TextBox3.Text.Trim() & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(InsertCmd, conn)
        cmd.ExecuteNonQuery()
        conn.Close()                              ' 關閉資料庫
        MsgBox("新增成功！")
        Call Show_Record1()
    End Sub

    '一、設定系碼[修改功能]
    Protected Sub Button3_Click(sender As Object, e As System.EventArgs) Handles Button3.Click
        Call Con_DB()    '呼叫連接資料庫之副程式
        Dim UpdateCmd As String
        UpdateCmd = "UPDATE 科系代碼資料表 SET 系碼='" & TextBox1.Text.Trim() & "',系名='" & TextBox2.Text.Trim() & "' ,系主任='" & TextBox3.Text.Trim() & "' WHERE 系碼='" & TextBox1.Text.Trim() & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(UpdateCmd, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("修改成功！")
        Call Show_Record1()
    End Sub

    '一、設定系碼[刪除功能]
    Protected Sub Button4_Click(sender As Object, e As System.EventArgs) Handles Button4.Click
        ID = InputBox("請輸入系碼")
        Call Con_DB()    '呼叫連接資料庫之副程式
        Dim DeleteCmd As String
        DeleteCmd = "Delete From 科系代碼資料表 WHERE 系碼='" & ID & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(DeleteCmd, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("刪除成功！")
        Call Show_Record1()
    End Sub

    '二、課程管理[查詢功能]
    Protected Sub Button5_Click1(sender As Object, e As System.EventArgs) Handles Button5.Click
        ID = InputBox("請輸入系碼")
        Call Con_DB()    '呼叫連接資料庫之副程式
        Dim SelectCmd As String
        SelectCmd = "select * from 課程資料表 Where 課號='" & ID & "'"
        Dim Cmd As OleDbCommand = New OleDbCommand(SelectCmd, conn)
        Dim reader As OleDbDataReader
        reader = Cmd.ExecuteReader()
        '顯示資料表欄位的所有資料
        If reader.Read() Then
            TextBox4.Text = reader.Item("課號")
            TextBox5.Text = reader.Item("課名")
            DropDownList1.Text = reader.Item("學分數")
            If reader.Item("必選修") = "必" Then
                RadioButton1.Checked = True
                RadioButton2.Checked = False
            Else
                RadioButton1.Checked = False
                RadioButton2.Checked = True
            End If
        End If
        conn.Close()                       ' 關閉資料庫
    End Sub


    '二、課程管理[新增功能]
    Protected Sub Button6_Click(sender As Object, e As System.EventArgs) Handles Button6.Click
        Call Con_DB()    '呼叫連接資料庫之副程式                          
        Dim sp As String
        Dim InsertCmd As String
        If RadioButton1.Checked = True Then
            sp = "必"
        Else
            sp = "選"
        End If
        InsertCmd = "Insert Into 課程資料表(課號,課名,學分數,必選修) Values('" & TextBox4.Text.Trim() & "','" & TextBox5.Text.Trim() & "','" & DropDownList1.Text.Trim() & "','" & sp & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(InsertCmd, conn)
        cmd.ExecuteNonQuery()
        conn.Close()                              ' 關閉資料庫
        MsgBox("新增成功！")
        Call Show_Record2()
    End Sub

    '二、課程管理[修改功能]
    Protected Sub Button7_Click(sender As Object, e As System.EventArgs) Handles Button7.Click
        Call Con_DB()    '呼叫連接資料庫之副程式       
        Dim sp As String
        Dim UpdateCmd As String
        If RadioButton1.Checked = True Then
            sp = "必"
        Else
            sp = "選"
        End If
        UpdateCmd = "UPDATE 課程資料表 SET 課號='" & TextBox4.Text.Trim() & "',課名='" & TextBox5.Text.Trim() & "' ,學分數='" & DropDownList1.Text.Trim() & "', 必選修='" & sp & "' WHERE 課號='" & TextBox4.Text.Trim() & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(UpdateCmd, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("修改成功！")
        Call Show_Record2()
    End Sub

    '二、課程管理[刪除功能]
    Protected Sub Button8_Click(sender As Object, e As System.EventArgs) Handles Button8.Click
        ID = InputBox("請輸入系碼")
        Call Con_DB()    '呼叫連接資料庫之副程式
        Dim DeleteCmd As String
        DeleteCmd = "Delete From 課程資料表 WHERE 課號='" & ID & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(DeleteCmd, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("刪除成功！")
        Call Show_Record2()
    End Sub

End Class
