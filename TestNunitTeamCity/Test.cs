using NUnit.Allure.Core;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.IO;
using System.Reflection;
using System.Threading;

namespace TestTeamCity
{
    [TestFixture]
    [AllureNUnit]

    class Test
    {
        ThreadLocal<IWebDriver> driver = new ThreadLocal<IWebDriver>();
        [OneTimeSetUp]
        public void beforeall()
        {
            Environment.CurrentDirectory = Path.GetDirectoryName(GetType().Assembly.Location);
        }

        [SetUp]
        public void startBrowser()
        {
            ChromeOptions chromeOption = new ChromeOptions();

            chromeOption.AddArgument("headless");


            //driver.Value = new ChromeDriver(chromeOption);
            //driver.Value.Url = "https://www.google.co";
            //driver.Navigate().GoToUrl($"https://www.google.co");

            //ChromeOption.AddUserProfilePreference("network.proxy.autoconfig_url", "http://pac.zscloud.net/beazley.com/pac01.pac");
            Thread.Sleep(5000);
        }


        [Test]
        public void test()
        {

            //chromeOption.Proxy = proxy;


            //Console.WriteLine(driver.Value.Url);


        }

        [Test]
        public void test2()
        {
            Console.WriteLine("AJIACO2");
            Console.WriteLine(Environment.GetEnvironmentVariable("Ambiente"));
            Thread.Sleep(15000);
            Assert.IsTrue(false);

        }
        [Test]
        public void test3()
        {
            Console.WriteLine("AJIACO3");
            Console.WriteLine(Environment.GetEnvironmentVariable("Ambiente"));
            Thread.Sleep(15000);
            Assert.IsTrue(false);

        }

        [Test]
        public void test4()
        {
            Console.WriteLine("AJIACO4");
            Console.WriteLine(Environment.GetEnvironmentVariable("Ambiente"));
            Thread.Sleep(15000);

        }

        [TearDown]
        public void closeBrowser()
        {
            Directory.CreateDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/screenshots");
            //var screenshots = ((ITakesScreenshot)driver.Value).GetScreenshot();

            //screenshots.SaveAsFile(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/screenshots/" + TestContext.CurrentContext.Test.FullName + ".png");

            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
            }
            //Console.WriteLine(driver.ToString());
            //driver.Value.Quit();

        }
    }
}
