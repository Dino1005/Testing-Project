using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Project.Pages
{
    internal class LoginPage : Driver
    {
        [FindsBy(How = How.ClassName, Using = "btn-type2")]
        private IWebElement registerButton;

        [FindsBy(How = How.Id, Using = "Input_Email")]
        private IWebElement emailInput;

        [FindsBy(How = How.Id, Using = "Input_Password")]
        private IWebElement passwordInput;

        [FindsBy(How = How.ClassName, Using = "loginbtn")]
        private IWebElement signInButton;

        public LoginPage()
        {
            PageFactory.InitElements(driver, this);
        }

        public void Login(string email, string password)
        {
            HomePage home = new HomePage();
            home.GetCloseButton().Click();
            home.GetSignInButton().Click();

            emailInput.SendKeys(email);
            passwordInput.SendKeys(password);
            signInButton.Click();
        }

        public IWebElement GetRegisterButton()
        {
            return this.registerButton;
        }
    }
}
