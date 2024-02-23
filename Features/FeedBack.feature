Feature: Give Feedback

@TestCaseX
Scenario: Reconocimiento exitoso
	Given el usuario ya ingreso sus datos
	And el usuario presiono el boton indicando que se escaneara la foto
	And el usuario capturo una foto
	And el usuario presiona el boton escanear
	And se reconoce un modelo del electrodomestico en la base de datos
	When el usuario indica que el reconocimiento es exitoso
	Then se guarda la imagen

@TestCaseY
Scenario: Reconocimiento no exitoso
	Given el usuario ya ingreso sus datos
	And el usuario presiono el boton indicando que se escaneara la foto
	And el usuario capturo una foto
	And el usuario presiona el boton escanear
	And se reconoce un modelo del electrodomestico en la base de datos
	When el usuario indica que el reconocimiento no es exitoso
	Then se le muestra la opcion al usuario de indicar el dispositivo correcto