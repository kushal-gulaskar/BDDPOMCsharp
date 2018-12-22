using NUnit.Framework;
using OpenQA.Selenium;

namespace BDDPOMKUSHAL.PageUI
{
    class SupportUI
    {
        static IWebDriver Adriver = null;

        static By suppoertlink = By.LinkText("support.aleyant.com");

        public SupportUI(IWebDriver driverr)
        {
            Adriver = driverr;
        }

        public static void ClickSupportLink()
        {
            Assert.AreEqual("support.aleyant.com",Adriver.FindElement(suppoertlink).Text);
        }
    }
}
