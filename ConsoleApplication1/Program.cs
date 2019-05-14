using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        [Test]
        static void Main(string[] args)
        {
           
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.youtube.com");
            IWebElement element = driver.FindElements()
        }
    }
}
