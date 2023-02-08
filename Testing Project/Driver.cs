using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Firefox;

namespace Testing_Project
{
    internal class Driver
    {
        public static IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            dynamic config = JsonConvert.DeserializeObject(File.ReadAllText(@"../../../config.json"));

            if (config["browser"] == "chrome")
            {
                new DriverManager().SetUpDriver(new ChromeConfig());
                driver = new ChromeDriver();
            }
            else if (config["browser"] == "firefox")
            {
                new DriverManager().SetUpDriver(new FirefoxConfig());
                driver = new FirefoxDriver();
            }
            else if (config["browser"] == "ie")
            {
                new DriverManager().SetUpDriver(new InternetExplorerConfig());
                driver = new InternetExplorerDriver();
            }

            driver.Manage().Window.Maximize();
        }


        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
