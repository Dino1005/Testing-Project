using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace Testing_Project.Pages
{
    internal class ProductPage : Driver
    {
        [FindsBy(How = How.ClassName, Using = "productEntityAddToCart")]
        private IWebElement cartButton;

        public ProductPage()
        {
            PageFactory.InitElements(driver, this);
        }

        public void AddToCart()
        {
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 10));
            wait.Until(ExpectedConditions.ElementToBeClickable(cartButton));
            cartButton.SendKeys("\n");
            Task.Delay(1000).Wait();
        }
    }
}
