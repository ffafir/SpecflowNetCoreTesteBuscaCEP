using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowNetCoreTesteBuscaCEP.Pages
{
    public class ResultadoBuscaCepPage
    {
        public IWebDriver WebDriver { get; }
        public ResultadoBuscaCepPage(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public IWebElement mensagemResultadoBusca => WebDriver.FindElement(By.Id("mensagem-resultado-alerta"));

    }
}
