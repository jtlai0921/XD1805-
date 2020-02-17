Imports System.Data
Imports System.Data.OleDb
Partial Class ch14_2d
    Inherits System.Web.UI.Page
    Dim conn As OleDbConnection              '宣告連線的物件
    Dim Stu_ID As String = ""

    Protected Sub Menu1_MenuItemClick(sender As Object, e As System.Web.UI.WebControls.MenuEventArgs) Handles Menu1.MenuItemClick
        MultiView1.ActiveViewIndex = Menu1.SelectedValue
        If MultiView1.ActiveViewIndex = 3 Then
            Stu_ID = InputBox("請輸入學號")
            Call Con_DB()    '呼叫連接資料庫之副程式
            REM =====顯示學生之學號與姓名清單==========
            Dim SelectCmd As String
            SelectCmd = "select * from 學生資料表 Where 學號='" & Stu_ID & "' "
            Dim Cmd As OleDbCommand = New OleDbCommand(SelectCmd, conn)
            Dim reader As OleDbDataReader
            reader = Cmd.ExecuteReader()
            '顯示資料表欄位的所有資料
            If reader.Read() Then
                Label1.Text = "學號：" & reader.Item("學號") & "  姓名：" & reader.Item("姓名")
            Else
                MsgBox("您不是學員！")
            End If
            conn.Close()
        End If
    End Sub

    Protected Sub Page_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        If Not IsPostBack Then
            Call Show_Record1()    '呼叫設定系碼[顯示科系代碼表]
            Call Show_Record2()    '呼叫課程管理[顯示課程管理表]
            Call Show_Record3()    '呼叫學生管理[顯示學生管理表]
            Call Show_Dept_No()    '呼叫顯示科系代碼選項
            Call Show_Subject()    '呼叫顯示全部課程
        End If
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

    Sub Show_Record3()   '學生管理[顯示學生管理表]
        Call Con_DB()    '呼叫連接資料庫之副程式
        Dim SelectCmd As String
        SelectCmd = "select 學號,姓名,系名 from 學生資料表,科系代碼資料表 where 學生資料表.系碼=科系代碼資料表.系碼 Order by 學號"
        '宣告物件
        Dim DtApter As OleDbDataAdapter
        Dim DtSet As DataSet
        DtApter = New OleDbDataAdapter(SelectCmd, conn)
        DtSet = New DataSet
        '讀取資料表
        DtApter.Fill(DtSet, "Student")
        GridView3.DataSource = DtSet.Tables("Student")
        GridView3.DataBind()
        conn.Close()                       ' 關閉資料庫
    End Sub

    Sub Show_Dept_No()
        Call Con_DB()    '呼叫連接資料庫之副程式
        Dim SelectCmd As String
        SelectCmd = "select Distinct * from 科系代碼資料表"
        Dim Cmd As OleDbCommand = New OleDbCommand(SelectCmd, conn)
        Dim reader As OleDbDataReader
        reader = Cmd.ExecuteReader()
        '顯示資料表欄位的所有資料
        While reader.Read()
            DropDownList2.Items.Add(reader.Item("系碼") & "/" & reader.Item("系名"))
        End While
        conn.Close()                       ' 關閉資料庫
    End Sub

    Sub Display_Dept_No_Name()
        Call Con_DB()    '呼叫連接資料庫之副程式
        ' DropDownList2.Items.Clear()
        Dim SelectCmd As String
        SelectCmd = "select 科系代碼資料表.系碼,系名 from 科系代碼資料表,學生資料表 where 科系代碼資料表.系碼=學生資料表.系碼 And 學號='" & ID & "'"
        Dim Cmd As OleDbCommand = New OleDbCommand(SelectCmd, conn)
        Dim reader As OleDbDataReader
        ' MsgBox(SelectCmd)
        reader = Cmd.ExecuteReader()
        '顯示資料表欄位的所有資料
        While reader.Read()
            DropDownList2.Text = reader.Item("系碼") & "/" & reader.Item("系名")
        End While
        conn.Close()                       ' 關閉資料庫
    End Sub

    Sub Show_Subject()
        Call Con_DB()    '呼叫連接資料庫之副程式 
        Dim SelectCmd As String
        SelectCmd = "select * from 課程資料表"
        Dim Cmd As OleDbCommand = New OleDbCommand(SelectCmd, conn)
        Dim reader As OleDbDataReader
        reader = Cmd.ExecuteReader()
        '顯示資料表欄位的所有資料
        While reader.Read()
            CheckBoxList1.Items.Add(reader.Item("課號") & "/" & reader.Item("課名"))
        End While
        conn.Close()                       ' 關閉資料庫
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

    '三、學生管理[查詢功能]
    Protected Sub Button9_Click(sender As Object, e As System.EventArgs) Handles Button9.Click
        ID = InputBox("請輸入學號")
        Call Con_DB()    '呼叫連接資料庫之副程式
        Dim SelectCmd As String
        SelectCmd = "select * from 學生資料表 Where 學號='" & ID & "'"
        Dim Cmd As OleDbCommand = New OleDbCommand(SelectCmd, conn)
        Dim reader As OleDbDataReader
        reader = Cmd.ExecuteReader()
        '顯示資料表欄位的所有資料
        While reader.Read()
            TextBox6.Text = reader.Item("學號")
            TextBox7.Text = reader.Item("姓名")
        End While
        conn.Close()                       ' 關閉資料庫
        Call Display_Dept_No_Name()
    End Sub

    '三、學生管理[新增功能]
    Protected Sub Button10_Click(sender As Object, e As System.EventArgs) Handles Button10.Click
        Call Con_DB()    '呼叫連接資料庫之副程式
        Dim InsertCmd As String
        InsertCmd = "Insert Into 學生資料表(學號,姓名,系碼) Values('" & TextBox6.Text.Trim() & "','" & TextBox7.Text.Trim() & "','" & Mid(DropDownList2.Text.Trim(), 1, 4) & "')"
        Dim cmd As OleDbCommand = New OleDbCommand(InsertCmd, conn)
        cmd.ExecuteNonQuery()
        conn.Close()                              ' 關閉資料庫
        MsgBox("新增成功！")
        Call Show_Record3()
    End Sub

    '三、學生管理[修改功能]
    Protected Sub Button11_Click(sender As Object, e As System.EventArgs) Handles Button11.Click
        Call Con_DB()    '呼叫連接資料庫之副程式
        Dim UpdateCmd As String
        UpdateCmd = "UPDATE 學生資料表 SET 學號='" & TextBox6.Text.Trim() & "',姓名='" & TextBox7.Text.Trim() & "' ,系碼='" & Mid(DropDownList2.Text.Trim(), 1, 4) & "' WHERE 學號='" & TextBox6.Text.Trim() & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(UpdateCmd, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("修改成功！")
        Call Show_Record3()
    End Sub

    '三、學生管理[刪除功能]
    Protected Sub Button12_Click(sender As Object, e As System.EventArgs) Handles Button12.Click
        ID = InputBox("請輸入學號")
        Call Con_DB()    '呼叫連接資料庫之副程式
        Dim DeleteCmd As String
        DeleteCmd = "Delete From 學生資料表 WHERE 學號='" & ID & "'"
        Dim cmd As OleDbCommand = New OleDbCommand(DeleteCmd, conn)
        cmd.ExecuteNonQuery()
        conn.Close()
        MsgBox("刪除成功！")
        Call Show_Record3()
    End Sub

    Protected Sub Button13_Click(sender As Object, e As System.EventArgs) Handles Button13.Click

    End Sub

    Protected Sub Button14_Click(sender As Object, e As System.EventArgs) Handles Button14.Click
        Dim Temp As String = ""
        Dim intIndex As Integer
        For intIndex = 0 To CheckBoxList1.Items.Count - 1
            If CheckBoxList1.Items(intIndex).Selected = True Then
                Temp &= CheckBoxList1.Items(intIndex).ToString & vbNewLine
            End If
        Next
        TextBox8.Text = Temp
    End Sub

    Protected Sub Button15_Click(sender As Object, e As System.EventArgs) Handles Button15.Click
        Dim dbpath As String = "C:\Inetpub\wwwroot\ASPNET\ch14\App_Data\DBMS1.mdb"        '宣告資料庫所在的路徑變數
        Dim Source As String                     '宣告連線的字串
        Source = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbpath
        Dim InsertCmd As String
        Dim Temp As String = ""
        Dim intIndex As Integer

        For intIndex = 0 To CheckBoxList1.Items.Count - 1
            If CheckBoxList1.Items(intIndex).Selected = True Then
                Dim conn As OleDbConnection              '宣告連線的物件
                conn = New OleDbConnection(Source)       '連線
                conn.Open()                              '開啟資料庫
                InsertCmd = "Insert Into 選課資料表(學號,課號) Values('" & Mid(Label1.Text.Trim(), 4, 5) & "','" & Mid(CheckBoxList1.Items(intIndex).ToString, 1, 4) & "')"
                MsgBox(InsertCmd)
                Dim cmd As OleDbCommand = New OleDbCommand(InsertCmd, conn)
                cmd.ExecuteNonQuery()
                conn.Close()
            End If
        Next
        MsgBox("加選成功！")
    End Sub

End Class
