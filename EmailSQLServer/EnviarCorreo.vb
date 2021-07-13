Imports System.Data.SqlClient
Public Class EnviarCorreo
    Inherits Config

    Private cmd As New SqlCommand

    Public Function enviarCorreo(xCorreoDestino As String,
                                 xAsunto As String,
                                 xCuerpo As String) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("pa_EnviarEmail")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn

            With cmd
                .Parameters.AddWithValue("@CorreoDestino", xCorreoDestino)
                .Parameters.AddWithValue("@Asunto", xAsunto)
                .Parameters.AddWithValue("@Cuerpo", xCuerpo)
            End With

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False
            End If

        Catch ex As Exception
            Return False
        Finally
            desconectado()
        End Try
    End Function

End Class
