using TestAutomationFrontend.PageObjects;

namespace TestAutomationFrontend.StepDefinitions;


[Binding]
public class UploadImageStepDefinitions : BaseStepDefinitions
{
    public UploadImageStepDefinitions(ScenarioContext scenarioContext) : base(scenarioContext) { }
        
    [Given(@"el usuario ya ingreso sus datos")]
    public async Task GivenElUsuarioYaIngresoSusDatos()
    {
        await GotoLoginPage();
        await LoginPage().EnterLoginCredentials("username", "password");
        await LoginPage().ClickOnIniciarBtn();
        await ForoPage().AssertWelcomeMessageIsVisible();
    }

    [Given(@"el usuario presiono el boton indicando que se escaneara la foto")]
    public async Task GivenElUsuarioPresionoElBotonIndicandoQueSeEscanearaLaFoto()
    {
        await NavBar().IdentificarBtn().ClickAsync();
    }

    [Given(@"el usuario capturo una foto")]
    public async Task GivenElUsuarioCapturoUnaFoto()
    {
        await IdentificarPage().ClickOnTakePictureBtn();
        await IdentificarPage().AssertSubirBtnIsVisible();
    }

    [When(@"el usuario presiona el boton escanear")]
    public void WhenElUsuarioPresionaElBotonEscanear()
    {
        //throw new PendingStepException();
    }

    [Then(@"se reconoce un modelo del electrodomestico en la base de datos")]
    public void ThenSeReconoceUnModeloDelElectrodomesticoEnLaBaseDeDatos()
    {
        //throw new PendingStepException();
    }
}
