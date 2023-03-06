using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using SpecflowNetCoreTesteBuscaCEP.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowNetCoreTesteBuscaCEP.Fixtures
{
    public class TestFixture : IDisposable
    {
        public IWebDriver Driver { get; private set; }

        //Setup
        public TestFixture()
        {
            Driver = new ChromeDriver(TestHelpers.PastaDoExecutavel);
        }

        //TearDown
        public void Dispose()
        {
            Driver.Quit();
        }
    }
}
