Feature: UploadImage

@TestCase6
Scenario: Captura exitosa
	Given el usuario ya ingreso sus datos
	And el usuario presiono el boton indicando que se escaneara la foto
	And el usuario capturo una foto
	When el usuario presiona el boton escanear
	Then se reconoce un modelo del electrodomestico en la base de datos