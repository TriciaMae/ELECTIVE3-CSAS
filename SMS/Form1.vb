Imports System.Net
Public Class SMS_Form
    Function TxtMsg(ByVal mob_num As String, ByVal msg As String, ByVal api As String)
        Using client As New Net.WebClient
            Dim parameter As New Specialized.NameValueCollection
            Dim url As String = "https://www.itexmo.com/php_api/api.php"
            parameter.Add("1", mob_num)
            parameter.Add("2", msg)
            parameter.Add("3", api)
            Dim rpb = client.UploadValues(url, "POST", parameter)
            TxtMsg = (New System.Text.UTF8Encoding).GetString(rpb)
        End Using
    End Function

    Private Sub SendBtn_Click(sender As Object, e As EventArgs) Handles SendBtn.Click
        Dim result = TxtMsg(mob_num.Text, msg.Text, api.Text)
        If result = 0 Then
            MsgBox("Message Sent!")
        Else
            MsgBox("Error number " & result & " was encountered")
        End If
    End Sub
End Class
