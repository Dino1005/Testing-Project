using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_Project.Pages;

namespace Testing_Project.Tests
{
    internal class RegisterTests : Driver
    {
        [Test]
        public void SuccessfulRegister()
        {
            RegisterPage register = new RegisterPage();
            driver.Navigate().GoToUrl("https://www.instar-informatika.hr/");

            register.Register("testing1@test.com", "test123", "Johntra", "Volta");

            Assert.True(driver.Url == "https://www.instar-informatika.hr/Identity/Account/RegisterThanks/");
        }

        [Test]
        public void UnuccessfulRegister()
        {
            RegisterPage register = new RegisterPage();
            driver.Navigate().GoToUrl("https://www.instar-informatika.hr/");

            register.Register("testing@test.com", "test123", "Johntra", "Volta");

            Assert.True(driver.Url == "https://www.instar-informatika.hr/Identity/Account/Register/");
        }
    }
}
