using System;
using System.Xml;
using TechTalk.SpecFlow;

namespace BDDPOMKUSHAL.Common
{
    [Binding]
    public sealed class Hook
    {
        public static string startupPath = AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.IndexOf("bin"));
        public static string configfilePath;
        public static string browser;
        public static string url;
        public static string username;
        public static string password;
        public static string attributevalue;
        public static string driverstring;

        [BeforeTestRun(Order = 1)]
        [Given(@"I have config file")]
        public static void GivenIHaveConfigFile()
        {
            startupPath = AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.IndexOf("bin"));
            configfilePath = startupPath + "Common" + "\\config.xml";
        }

        [BeforeTestRun(Order = 2)]
        [Given(@"I read url,username and password")]
        public static Tuple<string, string, string, string> GivenIReadUrlUsernameAndPassword()
        {
            browser = xmlRead(configfilePath, "browser");
            url = xmlRead(configfilePath, "url");
            username = xmlRead(configfilePath, "username");
            password = xmlRead(configfilePath, "password");
            return new Tuple<string, string, string, string>(browser, url, username, password);
        }

        public static string xmlRead(string configpath, string attributename)
        {
            var doc = new XmlDocument();
            doc.Load(@configfilePath);
            var nodes = doc.GetElementsByTagName(attributename);
            if (nodes.Count < 3)
            {
                attributevalue = (nodes[0].InnerText);
            }
            return attributevalue;
        }

        public static string GetBrowserName()
        {
            string BrowserName = browser;
            return BrowserName;
        }
        public static string GetAdminURL()
        {
            string AdminURL = url;
            return AdminURL;
        }
        public static string GetAdminUName()
        {
            string AdminUname = username;
            return AdminUname;
        }
        public static string GetAdminPass()
        {
            string AdminPass = password;
            return AdminPass;
        }

        [AfterFeature]
        public static void AfterFeature()
        {
            Browsers.Quit();
        }
    }
}
