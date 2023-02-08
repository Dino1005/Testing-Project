using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_Project.Pages;

namespace Testing_Project.Tests
{
    internal class LoginTests : Driver
    {
        [Test]
        public void SuccessfulLogin()
        {
            LoginPage login = new LoginPage();
            driver.Navigate().GoToUrl("https://www.instar-informatika.hr/");

            login.Login("test@testing.com", "ilovetesting123");
            Assert.True(driver.Url == "https://www.instar-informatika.hr/");
        }

        [Test]
        public void UnsuccessfulLogin()
        {
            LoginPage login = new LoginPage();
            driver.Navigate().GoToUrl("https://www.instar-informatika.hr/");

            login.Login("testing@test.com", "password");
            Assert.True(driver.Url == "https://www.instar-informatika.hr/Identity/Account/Login/?error=1");
        }

    }
}
