using BDDPOMKUSHAL.PageUI;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Threading;

namespace BDDPOMKUSHAL.Common
{
    class Login
    {
        static IWebDriver driver = null;
        public static By userName = By.Id("username");
        public static By Password = By.Id("password");
        public static By LogIn = By.Id("btnLogin");
        public static By _adminLogout = By.LinkText("Logout");


        public static By _support = By.LinkText("Support");
        public static By _news = By.LinkText("News");


        public Login(IWebDriver driverr)
        {
            driver = driverr;
        }

        public static IWebDriver Setbrowser(String BrowserName)
        {
            driver = Browsers.SetBrowserName(BrowserName);
            return driver;
        }

        public static void SetURL(string url)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
        }

        public static void Authentication()
        {
            string adminUsername = Hook.GetAdminUName();
            string adminPasswords = Hook.GetAdminPass();
            driver.FindElement(userName).SendKeys(adminUsername);
            Thread.Sleep(2000);
            driver.FindElement(Password).SendKeys(adminPasswords);
            Thread.Sleep(2000);
            driver.FindElement(LogIn).Click();
            Thread.Sleep(2000);
        }

        public static void LoginAdmin()
        {
            Authentication();
        }

        public static void AdminLoginVerification()
        {
            string expScreen = "Logout";
            string actScreen = driver.FindElement(_adminLogout).Text;
            Assert.AreEqual(expScreen, actScreen);
        }

        public static SupportUI ClickSupport()
        {
            driver.FindElement(_support).Click();
            Thread.Sleep(2000);
            return new SupportUI(driver);
        }

        public static NewsUI ClickNews()
        {
            driver.FindElement(_news).Click();
            return new NewsUI(driver);
        }

        public static LogoutUI ClickLogout()
        {
            driver.FindElement(_adminLogout).Click();
            return new LogoutUI(driver);
        }
    }
}
