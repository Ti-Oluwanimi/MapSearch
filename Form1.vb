Imports System.Text
Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim street As String = TextBox1.Text
        Dim city As String = TextBox2.Text
        Dim state As String = TextBox3.Text

        Try
            Dim queryaddress As New StringBuilder
            queryaddress.append("http://maps.google.com/maps?q=")
            If TextBox1.Text <> String.Empty Then
                queryaddress.append(street + "," & "+")
            End If
            If TextBox2.Text <> String.Empty Then
                queryaddress.append(city + "," & "+")
            End If
            If TextBox3.Text <> String.Empty Then
                queryaddress.append(state + "," & "+")
            End If
            WebBrowser1.Navigate(queryaddress.ToString)
        Catch ex As Exception
            MessageBox.Show("Unable to retrieve data")
        End Try
    End Sub
End Class
