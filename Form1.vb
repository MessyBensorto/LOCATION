Imports MySql.Data.MySqlClient
Public Class Form1
    Private Sub btnclick_Click(sender As Object, e As EventArgs) Handles btnclick.Click
        Myconnection = New MySqlConnection(MyconnectionString)
        Try
            Myconnection = New MySqlConnection(MyconnectionString)
            Myconnection.Open()
            If Myconnection.State = ConnectionState.Open Then
                MessageBox.Show("HII CLINK ME PLSSS AGAINN !!!!!!")
            Else
                MessageBox.Show("Connection Falied")
            End If
        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        Finally
            If Myconnection IsNot Nothing Then
                Myconnection.Close()
            End If
            LETTER_NI_KRASSIE.Show()
            Me.Hide()
        End Try
    End Sub
End Class
