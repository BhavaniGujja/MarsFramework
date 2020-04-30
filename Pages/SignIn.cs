using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using MarsFramework.Global;
using NUnit.Framework;


namespace MarsFramework.Pages
{
    public class SignIn
    {
        public SignIn()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        #region  Initialize Web Elements 
        //Finding the Sign Link
        [FindsBy(How = How.XPath, Using = "//a[text()=\"Sign In\"]")]
        private IWebElement SignIntab { get; set; }

        // Finding the Email Field
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Email address']")]
        private IWebElement Email { get; set; }

        //Finding the Password Field
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Password']")]
        private IWebElement Password { get; set; }

        //Finding the Login Button
        [FindsBy(How = How.XPath, Using = "//button[@class='fluid ui teal button']")]
        private IWebElement LoginBtn { get; set; }



        #endregion

        internal void LoginSteps()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "SignIn");
            GlobalDefinitions.wait(5);

            GlobalDefinitions.driver.Navigate().GoToUrl("http://192.168.99.100:5000/");

            GlobalDefinitions.driver.Manage().Window.Maximize();

            System.Threading.Thread.Sleep(3000);

            SignIntab.Click();

            Email.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Username"));

            Password.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Password"));

            LoginBtn.Click();

        }

        //validating siginin page 
        public void validate()
        {
            System.Threading.Thread.Sleep(3000);
            IWebElement signin = GlobalDefinitions.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/div[1]/div[2]/div/span"));
            Assert.AreEqual(signin.Text, "Hi Durga Bhavani");

        }

    }
}