using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecflowNetCoreTesteBuscaCEP.Pages;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace SpecflowNetCoreTesteBuscaCEP.Steps
{
    [Binding]
    public class InformarCEPSteps
    {
        //Steps Definitions

        IWebDriver webDriver = new ChromeDriver();
        string mensagemValidacao = "Não há dados a serem exibidos";

        HomeCorreiosPage homeCorreiosPage = null;
        //ResultadoBuscaCepPage resultadoBuscaCepPage = null;

        [Given(@"eu tenha acessado o site dos correios")]
        public void GivenEuTenhaAcessadoOSiteDosCorreios()
        {
            webDriver.Navigate().GoToUrl("https://www.correios.com.br/");
            webDriver.Manage().Window.Maximize();
            homeCorreiosPage = new HomeCorreiosPage(webDriver);
        }

        [Given(@"Clicado no campo de preenchimento do CEP")]
        public void GivenClicadoNoCampoDePreenchimentoDoCEP()
        {
            homeCorreiosPage.ClickCampoDigitarCEP();
        }

        [Given(@"tenha preenchido o campo com o valor")]
        public void GivenTenhaPreenchidoOCampoComOValor(Table table)
        {
            dynamic data = table.CreateDynamicInstance();

            homeCorreiosPage.PreencherCep((string)data.CEP);
        }

        [When(@"o ícone de buscar for selecionado")]
        public void WhenOIconeDeBuscarForSelecionado()
        {
            homeCorreiosPage.ClickIconeBuscarCEP();
        }

        [Then(@"deverá ser exibido uma mensagem informado que o CEP não existe")]
        public void ThenDeveraSerExibidoUmaMensagemInformadoQueOCEPNaoExiste()
        {
            webDriver.SwitchTo().Window(webDriver.WindowHandles[1]);

            string mensagemResultadoBuscaCep = homeCorreiosPage.mensagemResultadoBusca.Text;
            Assert.That(mensagemResultadoBuscaCep, Is.EqualTo(mensagemValidacao));
        }
    }

}
