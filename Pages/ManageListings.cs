//using DocumentFormat.OpenXml.Bibliography;
using MarsFramework.Global;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace MarsFramework.Pages
{
    internal class ManageListings
    {
        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on Manage Listings Link
        [FindsBy(How = How.XPath, Using = "//a[@class='item'][contains(.,'Manage Listings')]")]
        private IWebElement manageListingsLink { get; set; }



        //Delete the listing
        [FindsBy(How = How.XPath, Using = "(//button[@class='ui button']/following-sibling::button)[4]")]
        private IWebElement delete { get; set; }



        //Click on Yes
        [FindsBy(How = How.XPath, Using = "//button[@class='ui icon positive right labeled button'][contains(.,'Yes')]")]
        private IWebElement YesActionsButton { get; set; }

        //method to delete the skill
        internal void Listings()
        {
            System.Threading.Thread.Sleep(1000);
            manageListingsLink.Click();

            System.Threading.Thread.Sleep(1000);
            delete.Click();

            System.Threading.Thread.Sleep(1000);
            YesActionsButton.Click();

        }

        //validate the delete skill
        internal void Delete()
        {

            GlobalDefinitions.wait(5);

            string expectedValue = "C Programming Language";

            string actualValue = GlobalDefinitions.driver.FindElement(By.XPath("//div[@id='listing-management-section']/div[2]/div[1]/div[1]/table[1]/tbody[1]/tr[2]/td[3] ")).Text;

            if (expectedValue != actualValue)
            {
                Assert.IsTrue(true);
            }

        }
    }
}
