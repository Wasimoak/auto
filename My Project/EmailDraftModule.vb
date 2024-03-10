Imports System.Collections.Generic
Imports System.IO
Imports Outlook = Microsoft.Office.Interop.Outlook
Imports System.Runtime.InteropServices

Public Class EmailData
    Public Property Subject As String
    Public Property Recipient As String
    Public Property Body As String
End Class

Public Module EmailGenerator
    Private ReadOnly TemplateFolderPath As String = "" ' Update this with the path to your template folder
    Private ReadOnly OutlookApplication As New Outlook.Application()

    Sub Main()
        Dim Emails As New List(Of EmailData)
        GenerateEmailDrafts(Emails)
    End Sub

    Private Sub GenerateEmailDrafts(ByRef Emails As List(Of EmailData))
        Dim currentDate As Date = Date.Today
        Dim endDate As Date = currentDate.AddDays(-1)
        Dim startDate As Date = currentDate.AddYears(-1) ' Start date is one year before the end date
        Dim dateRange As String = startDate.ToString("MMMM d, yyyy") & " - " & endDate.ToString("MMMM d, yyyy")
        Dim currentMonth As String = Date.Today.ToString("MMMM")

        MsgBox(currentMonth)

        Dim subjectTitles As String() = {
            "Security-Based Swap Dealer Deminimis Extract Request | {DATE_RANGE} - K2",
            "Security-Based Swap Dealer Deminimis Extract Request | {DATE_RANGE} - SwapOne",
            "SCOTS - Dodd-Frank DeMinimis Extract Request | {DATE_RANGE}",
            "Murex - Dodd-Frank DeMinimis Extract Request | {DATE_RANGE}",
            "Mexico - Dodd-Frank DeMinimis Extract Request | {DATE_RANGE}",
            "OPICS - Dodd-Frank DeMinimis Extract Request | {DATE_RANGE}",
            "Peru - Dodd-Frank DeMinimis Extract Request | {DATE_RANGE}",
            "Colombia - Dodd-Frank DeMinimis Extract Request | {DATE_RANGE}",
            "Uruguay - Dodd-Frank DeMinimis Extract Request | {DATE_RANGE}",
            "Chile - Dodd-Frank DeMinimis Extract Request | {DATE_RANGE}"
        }

        Dim successCount As Integer = 0
        Dim tempaltes = LoadEmailTemplates()

        For i As Integer = 0 To subjectTitles.Length - 1
            Dim subject As String = subjectTitles(i)
            Dim emailData As New EmailData()
            emailData.Subject = subject.Replace("{DATE_RANGE}", dateRange)
            emailData.Recipient = "recipient@example.com" ' Update with actual recipient
            emailData.Body = ReadTemplateBody(tempaltes("Subject" & i + 1), startDate, endDate, currentMonth)
            If Not String.IsNullOrEmpty(emailData.Body) Then
                Emails.Add(emailData)
                successCount += 1
            End If
        Next

        CreateEmailDrafts(Emails, successCount)
    End Sub

    Private Function ReadTemplateBody(template As String, ByVal startDate As Date, ByVal endDate As Date, currentMonth As String) As String
        'Dim templateFilePath As String = Path.Combine(TemplateFolderPath, templateFileName & ".html")
        'Dim templateBody As String = File.ReadAllText(template)
        Dim dateRange As String = startDate.ToString("MMMM d, yyyy") & " - " & endDate.ToString("MMMM d, yyyy")

        ' Replace placeholders with dynamic values
        Dim templateBody = template.Replace("{DATE_RANGE}", dateRange).Replace("{MONTH}", currentMonth)

        Return templateBody
        'If File.Exists(templateFilePath) Then
        'Else
        '    MsgBox($"Template file '{templateFileName}' not found.", MsgBoxStyle.Exclamation)
        '    Return String.Empty
        'End If
    End Function

    Private Sub CreateEmailDrafts(ByRef Emails As List(Of EmailData), ByVal successCount As Integer)
        For Each emailData In Emails
            Dim outlookMail As Outlook.MailItem = CType(OutlookApplication.CreateItem(Outlook.OlItemType.olMailItem), Outlook.MailItem)
            Try
                With outlookMail
                    .Subject = emailData.Subject
                    .To = emailData.Recipient
                    .BodyFormat = Outlook.OlBodyFormat.olFormatHTML
                    .HTMLBody = emailData.Body
                    .Save()
                End With
            Catch ex As Exception
                MsgBox($"Error creating email draft: {ex.Message}", MsgBoxStyle.Critical)
            Finally
                Marshal.ReleaseComObject(outlookMail)
            End Try
        Next

        If successCount > 0 Then
            MsgBox($"{successCount} email drafts generated successfully.", MsgBoxStyle.Information)
        Else
            MsgBox("No email drafts were generated.", MsgBoxStyle.Information)
        End If
    End Sub
End Module
