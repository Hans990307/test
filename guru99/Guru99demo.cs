using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guru99Demo
{
    class Guru99Demo
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver("C:\\Users\\user\\Desktop\\chrome");
        }

        [Test]
        public void test()
        {
            driver.Url = "https://www.google.com/?hl=ms";
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }

    }
}