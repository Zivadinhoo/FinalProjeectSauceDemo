﻿using FinalProject.Driver;
using OpenQA.Selenium;

namespace FinalProject.Pages
{
    public class LoginPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public IWebElement Username => driver.FindElement(By.Id("user-name"));
        public IWebElement Password => driver.FindElement(By.Id("password"));
        public IWebElement ButtonLogin => driver.FindElement(By.Id("login-button"));
        public IWebElement UserNotLogin => driver.FindElement(By.CssSelector(".error-message-container"));
        public IWebElement AssertMessage => driver.FindElement(By.CssSelector(".error h3"));
        public void Login(string name, string pass)
        {

            Username.SendKeys(name);
            Password.SendKeys(pass);
            ButtonLogin.Click();
        }

    }
}
