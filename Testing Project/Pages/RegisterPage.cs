using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing_Project.Pages
{
    internal class RegisterPage : Driver
    {
        [FindsBy(How = How.Id, Using = "Input_Email")]
        private IWebElement emailInput;

        [FindsBy(How = How.Id, Using = "Input_Password")]
        private IWebElement passwordInput;

        [FindsBy(How = How.Id, Using = "Input_ConfirmPassword")]
        private IWebElement passwordConfirmInput;

        [FindsBy(How = How.Id, Using = "Input_Ime")]
        private IWebElement nameInput;

        [FindsBy(How = How.Id, Using = "Input_Prezime")]
        private IWebElement surnameInput;

        [FindsBy(How = How.XPath, Using = "//*[@id=\"vsc-order\"]/div[1]/main/div[1]/div/div[1]/form/div[4]/div[4]/div/label")]
        private IWebElement agreeButton;

        [FindsBy(How = How.ClassName, Using = "btnorderend")]
        private IWebElement registerButton;

        public RegisterPage()
        {
            PageFactory.InitElements(driver, this);
        }

        public void Register(string email, string password, string name, string surname)
        {
            HomePage home = new HomePage();
            home.GetCloseButton().Click();
            home.GetSignInButton().Click();

            LoginPage login = new LoginPage();
            login.GetRegisterButton().Click();

            emailInput.SendKeys(email);
            passwordInput.SendKeys(password);
            passwordConfirmInput.SendKeys(password);
            nameInput.SendKeys(name);
            surnameInput.SendKeys(surname);
            agreeButton.Submit();
        }
    }
}
