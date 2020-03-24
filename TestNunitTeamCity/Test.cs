using NUnit.Framework;
using NUnit.Framework.Interfaces;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;
using System.Threading;

namespace TestTeamCity
{
    [TestFixture]
    class Test
    {
        ThreadLocal<IWebDriver> driver= new ThreadLocal<IWebDriver>();


        [SetUp]
        public void startBrowser()
        {
            driver.Value = new ChromeDriver();
            driver.Value.Url = "https://www.google.co";

        }


        [Test]
        public void test()
        {
            Console.WriteLine("AJIACO1");
            Console.WriteLine(Environment.GetEnvironmentVariable("Ambiente"));
            Thread.Sleep(15000);
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
            if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
            {
                Directory.CreateDirectory(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)+"/screenshots");
                var screenshots = ((ITakesScreenshot)driver.Value).GetScreenshot();
                screenshots.SaveAsFile(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "/screenshots/" + TestContext.CurrentContext.Test.FullName + ".png");
            }
            Console.WriteLine(driver.ToString());
            driver.Value.Quit();
            
        }
    }
}
