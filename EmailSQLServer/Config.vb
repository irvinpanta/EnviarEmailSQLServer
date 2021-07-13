Imports System.Data.SqlClient
Public Class Config

    Protected cnn As New SqlConnection

    Public Function conectado()

        Try
            Dim cadena As String
            cadena = "data source = localhost; initial catalog =dbenviaremail; integrated security=true"

            cnn = New SqlConnection(cadena)
            cnn.Open()

            Return True

        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function desconectado()
        Try
            If cnn.State = ConnectionState.Open Then
                cnn.Close()
            End If

            Return True
        Catch ex As Exception
            Return False
        End Try
    End Function

End Class
