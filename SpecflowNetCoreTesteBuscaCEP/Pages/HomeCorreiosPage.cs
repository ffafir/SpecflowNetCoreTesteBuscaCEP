using OpenQA.Selenium;


namespace SpecflowNetCoreTesteBuscaCEP.Pages
{
    public class HomeCorreiosPage
    {
        public IWebDriver webDriver { get; }
        public HomeCorreiosPage(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        //Elemnentos de UI

        public IWebElement campoDigiteCEP => webDriver.FindElement(By.Id("relaxation"));

        public IWebElement iconeBuscarCEP => webDriver.FindElement(By.XPath("//*[@id=\"content\"]/div[3]/div/div[2]/div[2]/form/div[2]/button/i"));

        public IWebElement mensagemResultadoBusca => webDriver.FindElement(By.XPath("/html/body/main/form/div[@id=\"painel_form_consulta\"]/div[2]/div[1]/div[@id=\"mensagem-resultado\"]"));

        public void ClickIconeBuscarCEP() => iconeBuscarCEP.Click();

        public void ClickCampoDigitarCEP() => campoDigiteCEP.Click();

        public void PreencherCep(string cep)
        {
            campoDigiteCEP.SendKeys(cep);
        }
    }
}
