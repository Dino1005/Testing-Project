using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Testing_Project.Pages;
using static System.Net.WebRequestMethods;

namespace Testing_Project.Tests
{
    internal class HomeTests : Driver
    {
        [Test]
        public void SearchProduct()
        {
            HomePage home = new HomePage();
            driver.Navigate().GoToUrl("https://www.instar-informatika.hr/");
            home.Search("iphone 14");
            
            Assert.True(driver.Url == "https://www.instar-informatika.hr/Search/?fs=1&term=iphone+14");
        }

        [Test]
        public void AddProductToCart()
        {
            HomePage home = new HomePage();
            driver.Navigate().GoToUrl("https://www.instar-informatika.hr/");
            home.Search("xiaomi dual mode");

            driver.FindElement(By.Id("item_114780")).Click();

            ProductPage product = new ProductPage();
            product.AddToCart();

            Assert.True(driver.FindElement(By.ClassName("count")).Text != "0");
        }

        [Test]
        public void ShowEmptyCart()
        {
            HomePage home = new HomePage();
            driver.Navigate().GoToUrl("https://www.instar-informatika.hr/");
            home.OpenCart();

            Assert.True(driver.Url == "https://www.instar-informatika.hr/#");
        }

    }
}
