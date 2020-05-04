Imports System.Net.Http, Newtonsoft.Json, System.Text, System.Net.Http.Headers

Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles registrationButton.Click
        Dim Today
        Today = Now
        Dim data As New With {
            .ActivationKey = "1234567890",
            .Customer = "Challenger",
            .CreationDate = Today,
            .MachineName = "TSI-271",
            .Product = "Tranzactor Integration Suite",
            .SerialNumber = "1C92C284",
            .UserName = "TRANZTEC\Toby",
            .Version = "2020.0.450.0",
            .Comment = "I JUST SENT YOU THIS ONE"
        }
        Dim url As String = "https://register.tranzactor.com/registration"
        Dim content As HttpContent = New ByteArrayContent(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data)))
        content.Headers.ContentType = New MediaTypeWithQualityHeaderValue("application/json")
        Using client As New HttpClient
            Try
                client.DefaultRequestHeaders.Add("integrationCode", "Zc#yB3zwF&uV6&Y&x533@vqnvwyUP%Atk$Z4cqm#")
                Dim task As Task(Of HttpResponseMessage) = client.PostAsync(url, content)
                task.Wait()
                MessageBox.Show("Response status: " & task.Result.StatusCode & " :: " & task.Result.ReasonPhrase)
            Catch ex As Exception
                MessageBox.Show("Error updating registration DB: " & ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles installationButton.Click
        Dim Today
        Today = Now
        Dim data As New With {
            .ActivationKey = "1234567890",
            .InstallDate = Today,
            .SerialNumber = "1C92C284",
            .Product = "Tranzactor Integration Suite",
            .Version = "2020.0.450.0",
            .InstallUser = "TRANZTEC\Toby",
            .InstallMachineName = "TSI-270",
            .Status = "Install",
            .Type = "Tranzactor Integration Suite",
            .Comment = "Test commentTest commentTest commentTest commentTest"
        }
        Dim url As String = "https://register.tranzactor.com/installation"
        Dim content As HttpContent = New ByteArrayContent(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data)))
        content.Headers.ContentType = New MediaTypeWithQualityHeaderValue("application/json")
        Using client As New HttpClient
            Try
                client.DefaultRequestHeaders.Add("integrationCode", "kms8Y#45XkHujnEQ%@^vzXb2!u67m%D7Mv3QU7B@")
                Dim task As Task(Of HttpResponseMessage) = client.PostAsync(url, content)
                task.Wait()
                MessageBox.Show("Response status: " & task.Result.StatusCode & " :: " & task.Result.ReasonPhrase)
            Catch ex As Exception
                MessageBox.Show("Error updating registration DB: " & ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles executionButton.Click
        Dim Today
        Today = Now
        Dim data As New With {
            .RunAsUser = "Toby",
            .RunDate = Today,
            .Status = "Started",
            .Product = "Tranzactor Integration Suite",
            .TranzactorVersion = "2020.0.450.0",
            .ActivationKey = "1234567890",
            .SerialNumber = "1C92C284",
            .MachineName = "TSI-271",
            .OSLevel = "",
            .DriveSize = "",
            .DriveSpaceFree = "",
            .DBSize = "",
            .QueueDetail = "{
               ""MobileComTrip"" = 6,
                ""MobileComFormMessage"" = 14,
                ""MobileComMessage"" = 25,
                ""MobileComPositionReport"" = 15492
             }",
            .Schemas = "",
            .Config = "",
            .Type = "Tranzactor Integration Suite",
            .Comment = "Test commentTest commentTest commentTest commentTest commentTest commentTest commentTest commentTest commentTest commentTest commentTest comment"
        }
        Dim url As String = "https://register.tranzactor.com/execution"
        Dim content As HttpContent = New ByteArrayContent(Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(data)))
        content.Headers.ContentType = New MediaTypeWithQualityHeaderValue("application/json")
        Using client As New HttpClient
            Try
                client.DefaultRequestHeaders.Add("integrationCode", "mPnW$B28EM@v2f32R3rD5uG*XmME@YHeST9*n@QK")
                Dim task As Task(Of HttpResponseMessage) = client.PostAsync(url, content)
                task.Wait()
                MessageBox.Show("Response status: " & task.Result.StatusCode & " :: " & task.Result.ReasonPhrase)
            Catch ex As Exception
                MessageBox.Show("Error updating registration DB: " & ex.Message, Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Using
    End Sub
End Class
