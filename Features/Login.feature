Feature: Login

Scenario: Login exitoso
	Given estoy en la p�gina de inicio de sesi�n
	When ingreso mis credenciales correctas
	And presiono el bot�n �Ingresar�
	Then El usuario es dirigido a su p�gina de perfil