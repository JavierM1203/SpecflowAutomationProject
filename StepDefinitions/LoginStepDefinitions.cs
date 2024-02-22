using System;
using TechTalk.SpecFlow;
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
            await IntroPage().GotoIntroPage();
            await IntroPage().OmitirBtn().ClickAsync();
            await InicioPage().IniciarBtn().ClickAsync();
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
            await LoginPage().IniciarBtn().ClickAsync();
        }

        [Then(@"El usuario es dirigido a su pagina de perfil")]
        public async Task ThenElUsuarioEsDirigidoASuPaginaDePerfil()
        {
            await Expect(ForoPage().WelcomeMessage()).ToBeVisibleAsync();
            await ForoPage().Identificar().ClickAsync();
        }
    }
}
