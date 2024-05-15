Imports System.Text.RegularExpressions
Public Class SIGNUP
    Private CON As New ADODB.Connection
    Private SQ As String
    Private RS As New ADODB.Recordset

    Private Sub CONNECT()
CON1:
        If RS.State = 1 Then RS.Close()
        CON.CursorLocation = ADODB.CursorLocationEnum.adUseClient
        Try
            CON.Open("Provider=SQLOLEDB.1;Password=123;Persist Security Info=True;User ID=sa;Initial Catalog=DBTEST;Data Source=DESKTOP-RC61TL0\SQLEXPRESS")
            CON.CommandTimeout = 420
        Catch ex As Exception
            If MsgBox("SERVER NOT CONNECTED", MsgBoxStyle.Critical & vbCrLf & "TRY AGAIN ?", vbYesNo) = vbYes Then
                GoTo CON1
            End If
        End Try

    End Sub

    Dim UID As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CONNECT()
        TXT_NAME.Select()
        CALLUID()
    End Sub

    Private Sub BTN_SAVE_Click(sender As Object, e As EventArgs) Handles BTN_SAVE.Click
        If RS.State = 1 Then RS.Close()
        If CON.State = 0 Then CON.Open()

        Dim regex As Regex = New Regex("^[^@\s]+@[^@\s]+\.[^@\s]+$")
        Dim isvalid As Boolean = regex.IsMatch(TXT_MAIL.Text.Trim)

        CALLCHECKUSER()

        If TXT_NAME.Text = "" Then
            MsgBox("Please enter Username ", MsgBoxStyle.Exclamation, "SIGN UP")
            TXT_NAME.Focus()
            Exit Sub
        ElseIf TXT_PASS.Text = "" Then
            MsgBox("Please enter Password ", MsgBoxStyle.Exclamation, "SIGN UP")
            TXT_PASS.Focus()
            Exit Sub
        ElseIf Not isvalid Then
            MsgBox("Please enter a valid email address ", MsgBoxStyle.Exclamation, "SIGN UP")
            TXT_MAIL.Focus()
            Exit Sub
        End If

        If RS.State = 1 Then RS.Close()
        If CON.State = 0 Then CON.Open()

        RS.Open("Select * From USER_PASS WHERE USER_ID=999999", CON, 1, 3, 1)
        If RS.EOF = True Then
            RS.AddNew()
            RS.Fields("USER_ID").Value = UID
            RS.Fields("USER_NAME").Value = TXT_NAME.Text
            RS.Fields("USER_PASS").Value = TXT_PASS.Text
            RS.Fields("USER_GENDER").Value = CMB_GENDER.Text
            RS.Fields("USER_MAIL").Value = TXT_MAIL.Text
            RS.Fields("USER_MOBILE").Value = Val(TXT_MOBILE.Text)
            RS.Fields("USER_ADDRESS").Value = TXT_ADDRESS.Text
            RS.Update()

            'SQ = "INSERT INTO USER_PASS VALUES(UID,'" & TXT_NAME.Text & "','" & TXT_PASS.Text & "')"
            'RS = CON.Execute(SQ)

            MsgBox("RECORD INSERTED SUCCESFULLY ", MsgBoxStyle.Information, "DATABASE")
            CLEARSAVE()
            CALLUID()
        End If

        If RS.State = 1 Then RS.Close()
        If CON.State = 1 Then CON.Close()
    End Sub


    Private Sub CLEARSAVE()
        TXT_UID.Text = ""
        TXT_NAME.Text = ""
        TXT_PASS.Text = ""
        CMB_GENDER.Text = ""
        TXT_MAIL.Text = ""
        TXT_MOBILE.Text = ""
        TXT_ADDRESS.Text = ""
        TXT_NAME.Focus()
    End Sub


    Private Sub CALLUID()
        If RS.State = 1 Then RS.Close()
        If CON.State = 0 Then CON.Open()

        SQ = "SELECT ISNULL(MAX(USER_ID),0)+1 AS USERID FROM USER_PASS"
        RS = CON.Execute(SQ)
        If RS.EOF = False Then
            UID = RS.Fields("USERID").Value
            TXT_UID.Text = UID
        End If

        If RS.State = 1 Then RS.Close()
        If CON.State = 1 Then CON.Close()
    End Sub

    Private Sub CALLCHECKUSER()
        If RS.State = 1 Then RS.Close()
        If CON.State = 0 Then CON.Open()

        SQ = "SELECT USER_NAME FROM USER_PASS WHERE USER_NAME='" & TXT_NAME.Text & "'"
        RS = CON.Execute(SQ)
        If RS.EOF = False Then
            MsgBox("This username already exist ", MsgBoxStyle.Exclamation, "SIGN UP")
            TXT_NAME.Focus()
            Exit Sub
        End If

        If RS.State = 1 Then RS.Close()
        If CON.State = 1 Then CON.Close()
    End Sub

    Private Sub TXT_NAME_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_NAME.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_PASS.Focus()
        End If
    End Sub

    Private Sub TXT_PASS_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_PASS.KeyDown
        If e.KeyCode = Keys.Enter Then
            CMB_GENDER.Focus()
        End If
    End Sub

    Private Sub CMB_GENDER_KeyDown(sender As Object, e As KeyEventArgs) Handles CMB_GENDER.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_MAIL.Focus()
        End If
    End Sub

    Private Sub TXT_MAIL_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_MAIL.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_MOBILE.Focus()
        End If
    End Sub

    Private Sub TXT_MOBILE_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_MOBILE.KeyDown
        If e.KeyCode = Keys.Enter Then
            TXT_ADDRESS.Focus()
        End If
    End Sub

    Private Sub TXT_ADDRESS_KeyDown(sender As Object, e As KeyEventArgs) Handles TXT_ADDRESS.KeyDown
        If e.KeyCode = Keys.Enter Then
            BTN_SAVE.Focus()
        End If
    End Sub

    Private Sub TXT_MOBILE_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXT_MOBILE.KeyPress
        If Asc(e.KeyChar) <> 8 Then
            If (Asc(e.KeyChar) < 48 Or Asc(e.KeyChar) > 57) Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        End
    End Sub
End Class
