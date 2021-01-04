using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    class Sample1
    {
        [Test]
        public void launchBrowser()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https:www.target.com");
        }
    }
}
