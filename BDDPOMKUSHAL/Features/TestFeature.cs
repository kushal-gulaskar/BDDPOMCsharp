using BDDPOMKUSHAL.Common;
using BDDPOMKUSHAL.PageUI;
using TechTalk.SpecFlow;

namespace BDDPOMKUSHAL.Features
{
    [Binding]
    public sealed class TestFeature
    {
        [Given(@"I have opened '(.*)' browser and hit the admin URL")]
        public void GivenIHaveOpenedBrowserAndHitTheAdminURL(string p0)
        {
            Login.Setbrowser("chrome");
            Login.SetURL(Hook.GetAdminURL());
        }

        [Given(@"I have Login with Valid Admin user credentials and login")]
        public void GivenIHaveLoginWithValidAdminUserCredentialsAndLogin()
        {
            Login.LoginAdmin();
        }

        [Then(@"I should get logged into Pressero Admin")]
        public void ThenIShouldGetLoggedIntoPresseroAdmin()
        {
            Login.AdminLoginVerification();
        }

        [When(@"I am on Admin home page")]
        public void WhenIAmOnAdminHomePage()
        {
        }

        [When(@"I click on support link")]
        public void WhenIClickOnSupportLink()
        {
            Login.ClickSupport();
        }
        [When(@"I click on support Mail")]
        public void WhenIClickOnSupportMail()
        {
            SupportUI.ClickSupportLink();
        }


    }
}
