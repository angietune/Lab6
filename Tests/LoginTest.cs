using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Lab6
{
    public class Tests
    {
        private IWebDriver driver;

        [OneTimeSetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://localhost:5000/");
            var loginPage = new LoginPage(driver);
            loginPage.LoginApp("user", "user");
        }

        [Test]
        public void Test1()
        {
            IWebElement logout = driver.FindElement(By.XPath("//a[contains(.,'Logout')]"));
            Assert.AreEqual(logout.Text, "Logout");
        }

        [OneTimeTearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}