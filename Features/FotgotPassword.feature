Feature: Recuperacion de Contrasenia

@TestCase3
Scenario: Olvido de Contrasenia y Recuperacion
	Given estoy en la pagina de inicio de sesion
	When hago clic en "Olvidé mi contraseña"
	Then se me redirige a la página de recuperación de contraseña

	When ingreso mi dirección de correo electrónico registrada
	And hago clic en el botón de recuperación
	Then recibo un correo electrónico con instrucciones para restablecer mi contraseña

	When abro el correo electrónico de recuperación
	And hago clic en el enlace proporcionado
	Then se me redirige a la página de cambio de contraseña
	When ingreso una nueva contraseña
	And confirmo la nueva contraseña
	And hago clic en el botón de guardar cambios
	Then debería ver un mensaje de confirmación de que mi contraseña ha sido actualizada con éxito
	And debería ser redirigido a la página de inicio de sesión
	When ingreso mis nuevas credenciales
	And hago clic en el botón de inicio de sesión
	Then debería ser redirigido a mi página de perfil