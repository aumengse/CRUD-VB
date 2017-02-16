Imports MySql.Data.MySqlClient
Module GetDBConnection
    Public conn As New MySqlConnection

    Public Sub ConnectDatabase()
        Try
            Console.WriteLine("Connecting...")
            If conn.State = ConnectionState.Closed Then
                conn.ConnectionString = "server=localhost;userid=root;password=berth482;database=test"
                conn.Open()
                Console.WriteLine("Connection Succesful!")
            End If
        Catch myerror As Exception
            MsgBox("Connection Error")
            End
        End Try
    End Sub
    Public Sub DisconnectDatabase()
        Try
            conn.Close()
        Catch myerror As MySql.Data.MySqlClient.MySqlException
        End Try
    End Sub
End Module