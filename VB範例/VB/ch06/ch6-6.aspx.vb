
Partial Class ch6_6
    Inherits System.Web.UI.Page

    Protected Sub CustomValidator1_ServerValidate(source As Object, args As System.Web.UI.WebControls.ServerValidateEventArgs) Handles CustomValidator1.ServerValidate
        If args.Value Mod 2 <> 0 Then   '判斷是否為奇數
            args.IsValid = True   '是奇數
            MsgBox((args.Value) & "是奇數")
        Else
            args.IsValid = False   '是偶數
        End If
    End Sub
End Class
