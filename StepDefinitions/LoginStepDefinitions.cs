using System;
using TechTalk.SpecFlow;

namespace TestAutomationFrontend.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions : BaseStepDefinitions
    {
        public LoginStepDefinitions(ScenarioContext scenarioContext) : base(scenarioContext) { }

        [Given(@"estoy en la página de inicio de sesión")]
        public async Task GivenEstoyEnLaPaginaDeInicioDeSesion()
        {
            await LoginPage().GotoLoginPage();
        }

        [When(@"ingreso mis credenciales correctas")]
        public async Task WhenIngresoMisCredencialesCorrectas()
        {
            await LoginPage().EnterLoginCredentials("username", "password");
        }

        [When(@"presiono el botón “Ingresar”")]
        public async Task WhenPresionoElBotonIngresar()
        {
            await LoginPage().IniciarBtn().ClickAsync();
        }

        [Then(@"El usuario es dirigido a su página de perfil")]
        public async Task ThenElUsuarioEsDirigidoASuPaginaDePerfil()
        {
            await Expect(LoginPage().WelcomeMessage()).ToBeVisibleAsync();
        }
    }
}
