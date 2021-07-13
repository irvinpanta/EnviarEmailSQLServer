Imports System.Text.RegularExpressions

Public Class FrmEmail

    Private dta As New EnviarCorreo

    Public Function validarEmail(ByVal email As String) As Boolean

        If email = String.Empty Then Return False

        ' Compruebo si el formato de la dirección es correcto.
        Dim re As Regex = New Regex("^[\w._%-]+@[\w.-]+\.[a-zA-Z]{2,4}$")
        Dim m As Match = re.Match(email)
        Return (m.Captures.Count <> 0)

    End Function

    Private Sub enviarCorreo()
        Try
            If validarEmail(txtDestinatario.Text) = False Then
                MsgBox("Verifique Formato de Email", MsgBoxStyle.Critical, "")
            Else
                If dta.enviarCorreo(txtDestinatario.Text, txtAsunto.Text, txtCuerpo.Text) Then
                    MsgBox("Correo enviado con exito", MsgBoxStyle.Information, "Envio de Correo")
                Else
                    MsgBox("Upps, Ocurrio un error al enviar correo", MsgBoxStyle.Critical, "Envio de Correo")
                End If
            End If
            
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btnEnviar_Click(sender As Object, e As EventArgs) Handles btnEnviar.Click
        enviarCorreo()
    End Sub
End Class
