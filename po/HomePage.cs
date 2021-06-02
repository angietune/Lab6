using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using PageFactoryCore;

namespace Lab6
{
    class HomePage : AbstractPage
    {
        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
            var loginPage = new LoginPage(driver);
            loginPage.LoginApp("user", "user");
        }

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'All Products')]")]
        public IWebElement product;

        public void AllProducts()
        {
            product.Click();
        }
    }
}