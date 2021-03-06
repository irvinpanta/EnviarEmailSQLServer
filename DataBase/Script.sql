CREATE DATABASE [dbenviaremail]
go
USE [dbenviaremail]

GO
CREATE PROCEDURE [dbo].[pa_EnviarEmail]
(
	@CorreoDestino VARCHAR(20),
	@Asunto VARCHAR(50),
	@Cuerpo VARCHAR(200)
)
AS
BEGIN
	BEGIN TRY
		EXEC msdb.dbo.sp_send_dbmail
		   @profile_name = 'Irvin Panta',
		   @recipients = @CorreoDestino,
		   @body = @Cuerpo,
		   @subject = @Asunto;
	END TRY
	BEGIN CATCH
		SELECT ERROR_MESSAGE()
	END CATCH
END

