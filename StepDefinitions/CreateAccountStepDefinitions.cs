
namespace TestAutomationFrontend.StepDefinitions;

[Binding]
public class CreateAccountStepDefinitions : BaseStepDefinitions
{
    public CreateAccountStepDefinitions(ScenarioContext scenarioContext) : base(scenarioContext) { }

    [Given(@"estoy en la pagina para crear cuenta")]
    public void GivenEstoyEnLaPaginaParaCrearCuenta()
    {
        throw new PendingStepException();
    }

    [When(@"ingreso datos validos")]
    public void WhenIngresoDatosValidos()
    {
        throw new PendingStepException();
    }

    [When(@"presiono boton para crear cuenta")]
    public void WhenPresionoBotonParaCrearCuenta()
    {
        throw new PendingStepException();
    }

    [Then(@"se crea cuenta y se accede")]
    public void ThenSeCreaCuentaYSeAccede()
    {
        throw new PendingStepException();
    }
}
