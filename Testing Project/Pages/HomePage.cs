using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Testing_Project.Pages
{
    internal class HomePage : Driver
    {
        [FindsBy(How = How.Id, Using = "multiple")]
        private IWebElement searchBox;

        [FindsBy(How = How.ClassName, Using = "instar-search-ico")]
        private IWebElement searchButton;

        [FindsBy(How = How.ClassName, Using = "fa-user")] 
        private IWebElement signInButton;

        [FindsBy(How = How.ClassName, Using = "fa-times")]
        private IWebElement closeButton;

        [FindsBy(How = How.ClassName, Using = "product")]
        private IWebElement productButton;

        [FindsBy(How = How.ClassName, Using = "fa-shopping-cart")]
        private IWebElement cartButton;


        public HomePage()
        {
            PageFactory.InitElements(driver, this);
        }

        public void Search(string text)
        {
            closeButton.Click();
            searchBox.SendKeys(text);
            searchButton.Click();
        }

        public void OpenCart()
        {
            cartButton.Click();
        }


        public IWebElement GetSignInButton()
        {
            return this.signInButton;
        }

        public IWebElement GetCloseButton()
        {
            return this.closeButton;
        }
    }
}
