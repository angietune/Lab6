using Lab6;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace SpecFlowProject2.Steps
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I open ""(.*)"" url")]
        public void GivenIOpenUrl(string p0)
        {
            driver.Navigate().GoToUrl("http://localhost:5000/");
        }

        [When(@"I fill the following form")]
        public void WhenIFillTheFollowingForm(string name, string password)
        {
            new LoginPage(driver).SendKeys(name).password.SendKeys(password);
        }

        [When(@"click the login button")]
        public void WhenClickTheLoginButton()
        {
            new LoginPage.Click(submitBtn);
        }

        [Then(@"I should be at the home page")]
        public void ThenIShouldBeAtTheHomePage()
        {
            Assert.AreEqual(new LoginTest(driver).logout.Text, "Logout");
        }

        [AfterScenario]
        public void CloseDriver()
        {
            driver.Close();
            driver.Quit();
        }
    }
}

