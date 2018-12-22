using OpenQA.Selenium;

namespace BDDPOMKUSHAL.PageUI
{
    class NewsUI
    {
        static IWebDriver Adriver = null;

        public NewsUI(IWebDriver driverr)
        {
            Adriver = driverr;
        }
    }
}
