using TestAutomationFrontend.PageObjects;

namespace TestAutomationFrontend.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions : BaseStepDefinitions
    {
        public LoginStepDefinitions(ScenarioContext scenarioContext) : base(scenarioContext) { }

        [Given(@"estoy en la pagina de inicio de sesion")]
        public async Task GivenEstoyEnLaPaginaDeInicioDeSesion()
        {
            await GotoLoginPage();
            await Expect(LoginPage().UsernameField()).ToBeVisibleAsync();
        }

        [When(@"ingreso mis credenciales correctas")]
        public async Task WhenIngresoMisCredencialesCorrectas()
        {
            await LoginPage().EnterLoginCredentials("username", "password");
        }

        [When(@"presiono el boton Ingresar")]
        public async Task WhenPresionoElBotonIngresar()
        {
            await LoginPage().ClickOnIniciarBtn();
        }

        [Then(@"El usuario es dirigido a su pagina de perfil")]
        public async Task ThenElUsuarioEsDirigidoASuPaginaDePerfil()
        {
            await ForoPage().AssertWelcomeMessageIsVisible();
        }

        [When(@"ingreso credenciales incorrectas")]
        public async Task WhenIngresoCredencialesIncorrectas()
        {
            await LoginPage().EnterLoginCredentials("invalid", "invalid");
        }

        [Then(@"Se muestra un mensaje de error al usuario")]
        public void ThenSeMuestraUnMensajeDeErrorAlUsuario()
        {
            throw new PendingStepException("Step is no defined");
        }

    }
}
