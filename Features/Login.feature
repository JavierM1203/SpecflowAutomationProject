Feature: Login

@only
Scenario: Login exitoso
	Given estoy en la pagina de inicio de sesion
	When ingreso mis credenciales correctas
	And presiono el boton Ingresar
	Then El usuario es dirigido a su pagina de perfil