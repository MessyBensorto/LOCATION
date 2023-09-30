Imports MySql.Data.MySqlClient
Public Class LETTER_NI_KRASSIE
    Private Sub btnMysql_Click(sender As Object, e As EventArgs) Handles btnMysql.Click
        Myconnection = New MySqlConnection(MyconnectionString)
        Try
            MessageBox.Show("SANA MAY CHANCE KA SAKIN  HEHEHEHHE ILOVEYOU <3 ")

        Catch ex As Exception
            MessageBox.Show("Error:" & ex.Message)
        End Try
        Myconnection.Close()

    End Sub
End Class