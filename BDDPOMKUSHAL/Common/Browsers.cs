using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace BDDPOMKUSHAL.Common
{
    class Browsers
    {
        static IWebDriver driver = null;

        public static string BrowserName = null;

        public static IWebDriver SetBrowserName(String BName)
        {
            switch (BName)
            {
                case "chrome":
                    {
                        driver = new ChromeDriver();
                        break;
                    }
                default:
                    {
                        driver = null;
                        break;
                    }
            }
            return driver;
        }

        public static void Close()
        {
            driver.Close();
        }

        public static void Quit()
        {
            driver.Quit();
        }
    }
}
