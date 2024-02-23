using Microsoft.Playwright;
using System;
using TechTalk.SpecFlow;

namespace TestAutomationFrontend.StepDefinitions
{
    [Binding]
    public class GiveFeedbackStepDefinitions : BaseStepDefinitions
    {
        public GiveFeedbackStepDefinitions(ScenarioContext scenarioContext) : base(scenarioContext) { }

        [When(@"el usuario indica que el reconocimiento es exitoso")]
        public async Task WhenElUsuairoIndicaQueElReconocimientoEsExitoso()
        {
            await IdentificarPage().ConfirmarBtn().ClickAsync();
        }

        [Then(@"se guarda la imagen")]
        public async Task ThenSeGuardaLaImagen()
        {
            await Expect(IdentificarPage().RecognizedDeviceMessage()).Not.ToBeVisibleAsync();
        }

        [When(@"el usuario indica que el reconocimiento no es exitoso")]
        public async Task WhenElUsuarioIndicaQueElReconocimientoNoEsExitoso()
        {
            await IdentificarPage().ModificarBtn().ClickAsync();
        }

        [Then(@"se le muestra la opcion al usuario de indicar el dispositivo correcto")]
        public async Task ThenSeLeMuestraLaOpcionAlUsuarioDeIndicarElDispositivoCorrecto()
        {
            await IdentificarPage().AssertModifyResultIsVisible();
        }


    }
}
