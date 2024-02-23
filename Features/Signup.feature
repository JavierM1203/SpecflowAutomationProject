Feature: Create Account

@TestCase4
Scenario: Crear cuenta con datos validos
	Given estoy en la pagina para crear cuenta
	When ingreso datos validos
	And presiono boton para crear cuenta
	Then se crea cuenta y se accede

@TestCase5
Scenario: Crear cuenta con datos invalidos
	Given estoy en la pagina para crear cuenta
	When ingreso datos validos
	And presiono boton para crear cuenta
	Then se crea cuenta y se accede