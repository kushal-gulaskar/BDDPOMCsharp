using OpenQA.Selenium;

namespace BDDPOMKUSHAL.PageUI
{
    class LogoutUI
    {
        static IWebDriver Adriver = null;

        public LogoutUI(IWebDriver driverr)
        {
            Adriver = driverr;
        }
    }
}
