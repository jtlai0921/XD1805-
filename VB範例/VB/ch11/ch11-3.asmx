<%@ WebService Language="VB" Class="ch11_3" %>

Imports System.Web
Imports System.Web.Services
Imports System.Web.Services.Protocols

' To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line.
' <System.Web.Script.Services.ScriptService()> _
<WebService(Namespace:="http://tempuri.org/")> _
<WebServiceBinding(ConformsTo:=WsiProfiles.BasicProfile1_1)> _
Public Class ch11_3
    Inherits System.Web.Services.WebService
   
    <WebMethod()> _
    Public Function Add(num1 As Integer, num2 As Integer) As Integer
        Return num1 + num2
    End Function
    
    <WebMethod()> _
    Public Function Subtract(num1 As Integer, num2 As Integer) As Integer
        Return num1 - num2
    End Function
    
    <WebMethod()> _
    Public Function Multiple(num1 As Integer, num2 As Integer) As Integer
        Return num1 * num2
    End Function
    
    <WebMethod()> _
    Public Function Divide(num1 As Integer, num2 As Integer) As Integer
        Return num1 / num2
    End Function
End Class
