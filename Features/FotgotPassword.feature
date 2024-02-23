Feature: Recuperacion de Contrasenia

@TestCase3
Scenario: Olvido de Contrasenia y Recuperacion
	Given estoy en la pagina de inicio de sesion
	When hago clic en "Olvid� mi contrase�a"
	Then se me redirige a la p�gina de recuperaci�n de contrase�a

	When ingreso mi direcci�n de correo electr�nico registrada
	And hago clic en el bot�n de recuperaci�n
	Then recibo un correo electr�nico con instrucciones para restablecer mi contrase�a

	When abro el correo electr�nico de recuperaci�n
	And hago clic en el enlace proporcionado
	Then se me redirige a la p�gina de cambio de contrase�a
	When ingreso una nueva contrase�a
	And confirmo la nueva contrase�a
	And hago clic en el bot�n de guardar cambios
	Then deber�a ver un mensaje de confirmaci�n de que mi contrase�a ha sido actualizada con �xito
	And deber�a ser redirigido a la p�gina de inicio de sesi�n
	When ingreso mis nuevas credenciales
	And hago clic en el bot�n de inicio de sesi�n
	Then deber�a ser redirigido a mi p�gina de perfil