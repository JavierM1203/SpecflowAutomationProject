Feature: Login

Scenario: Login exitoso
	Given estoy en la página de inicio de sesión
	When ingreso mis credenciales correctas
	And presiono el botón “Ingresar”
	Then El usuario es dirigido a su página de perfil