Feature: Login

@TestCase1
Scenario: Login exitoso
	Given estoy en la pagina de inicio de sesion
	When ingreso mis credenciales correctas
	And presiono el boton Ingresar
	Then El usuario es dirigido a su pagina de perfil

@TestCase2
Scenario: Login con credenciales incorrectas
	Given estoy en la pagina de inicio de sesion
	When ingreso credenciales incorrectas
	And presiono el boton Ingresar
	Then Se muestra un mensaje de error al usuario
