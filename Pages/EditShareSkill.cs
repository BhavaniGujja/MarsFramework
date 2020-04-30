using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using MarsFramework.Global;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System;
using AutoItX3Lib;
using NUnit.Framework;

namespace MarsFramework.Pages
{
    class EditShareSkill
    {
        public EditShareSkill()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Click on ShareSkill Button
        [FindsBy(How = How.XPath, Using = "//a[@class='ui basic green button'][contains(.,'Share Skill')]")]
        private IWebElement ShareSkillButton { get; set; }

        //Enter the Title in textbox
        [FindsBy(How = How.XPath, Using = "//input[@name='title']")]
        private IWebElement Title { get; set; }

        //Enter the Description in textbox
        [FindsBy(How = How.XPath, Using = "//textarea[@name='description']")]
        private IWebElement Description { get; set; }

        //Click on Category Dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='categoryId']")]
        private IWebElement CategoryDropDown { get; set; }

        //Click on SubCategory Dropdown
        [FindsBy(How = How.XPath, Using = "//select[@name='subcategoryId']")]
        private IWebElement SubCategoryDropDown { get; set; }

        //Enter Tag names in textbox
        [FindsBy(How = How.XPath, Using = "(//input[contains(@type,'text')])[3]")]
        private IWebElement Tags { get; set; }

        //Select the Service type
        [FindsBy(How = How.XPath, Using = "(//input[@name='serviceType'])[2]")]
        private IWebElement ServiceTypeOptions { get; set; }

        //Select the Location Type
        [FindsBy(How = How.XPath, Using = "(//input[@name='locationType'])[2]")]
        private IWebElement LocationTypeOption { get; set; }

        //Click on Start Date dropdown
        [FindsBy(How = How.XPath, Using = "//input[@name='startDate']")]
        private IWebElement StartDateDropDown { get; set; }

        //Click on End Date dropdown
        [FindsBy(How = How.XPath, Using = "//input[@name='endDate']")]
        private IWebElement EndDateDropDown { get; set; }

        //Click on Monday tick dropdown
        [FindsBy(How = How.XPath, Using = "(//input[@name='Available'])[2]")]
        private IWebElement Monday { get; set; }

        //Storing the starttime Monday
        [FindsBy(How = How.XPath, Using = "(//input[@name='StartTime'])[2]")]
        private IWebElement MonStartTime { get; set; }

        //Click on Monday end time
        [FindsBy(How = How.XPath, Using = "(//input[@name='EndTime'])[2]")]
        private IWebElement MonEndTime { get; set; }

        //Click on Tuesday tick dropdown
        [FindsBy(How = How.XPath, Using = "(//input[@name='Available'])[3]")]
        private IWebElement Tuesday { get; set; }

        //Storing the starttime Tuesday
        [FindsBy(How = How.XPath, Using = "(//input[@name='StartTime'])[3]")]
        private IWebElement TueStartTime { get; set; }

        //Click on end time Tuesday
        [FindsBy(How = How.XPath, Using = "(//input[@name='EndTime'])[3]")]
        private IWebElement TueEndTime { get; set; }

        //Click on Wednesday tick dropdown
        [FindsBy(How = How.XPath, Using = "(//input[@name='Available'])[4]")]
        private IWebElement Wednesday { get; set; }

        //Storing the starttime Wed
        [FindsBy(How = How.XPath, Using = "(//input[@name='StartTime'])[4]")]
        private IWebElement WedStartTime { get; set; }

        //Click on end time Wed
        [FindsBy(How = How.XPath, Using = "(//input[@name='EndTime'])[4]")]
        private IWebElement WedEndTime { get; set; }

        //Click on Thus tick dropdown
        [FindsBy(How = How.XPath, Using = "(//input[@name='Available'])[5]")]
        private IWebElement Thus { get; set; }

        //Storing the starttime thus
        [FindsBy(How = How.XPath, Using = "(//input[@name='StartTime'])[5]")]
        private IWebElement ThusStartTime { get; set; }

        //Click on end time Wed
        [FindsBy(How = How.XPath, Using = "(//input[@name='EndTime'])[5]")]
        private IWebElement ThusEndTime { get; set; }

        //Click on Friday tick dropdown
        [FindsBy(How = How.XPath, Using = "(//input[@name='Available'])[6]")]
        private IWebElement Friday { get; set; }

        //Storing the starttime Wed
        [FindsBy(How = How.XPath, Using = "(//input[@name='StartTime'])[6]")]
        private IWebElement FriStartTime { get; set; }

        //Click on end time Wed
        [FindsBy(How = How.XPath, Using = "(//input[@name='EndTime'])[6]")]
        private IWebElement FriEndTime { get; set; }

        //Click on Skill Trade option
        [FindsBy(How = How.XPath, Using = "(//input[@name='skillTrades'])[2]")]
        private IWebElement SkillTradeOption { get; set; }


        //Enter the amount for Credit
        [FindsBy(How = How.XPath, Using = "//input[@name='charge']")]
        private IWebElement CreditAmount { get; set; }

        //Click on Active option
        [FindsBy(How = How.XPath, Using = "(//input[@name='isActive'])[2]")]
        private IWebElement ActiveOption { get; set; }

        //Click on Hidden option
        [FindsBy(How = How.XPath, Using = "(//input[contains(@name,'isActive')])[2]")]
        private IWebElement HiddenOption { get; set; }

        //Click on Save button
        [FindsBy(How = How.XPath, Using = "//input[@class='ui teal button']")]
        private IWebElement Save { get; set; }

        //Click on ManageListing button
        [FindsBy(How = How.XPath, Using = "//a[contains(.,'Manage Listings')]")]
        private IWebElement ManageListing { get; set; }

        //Click on Edit button
        [FindsBy(How = How.XPath, Using = "(//button[contains(@class,'ui button')])[2]")]
        private IWebElement Edit { get; set; }

        //Click on Manage Listings Link
        [FindsBy(How = How.XPath, Using = "//a[@class='item'][contains(.,'Manage Listings')]")]
        private IWebElement manageListingsLink { get; set; }

        //method to edit the skill in managelisting
        internal void EditSkill()
        {
            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "EditSkill");
            GlobalDefinitions.wait(5);

            System.Threading.Thread.Sleep(1000);
            ManageListing.Click();
            System.Threading.Thread.Sleep(3000);
            Edit.Click();
            System.Threading.Thread.Sleep(3000);

            GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "EditSkill");
            GlobalDefinitions.wait(5);

            //Edited Title
            Title.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Title"));
            System.Threading.Thread.Sleep(3000);

            //Edited Description
            Description.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Description"));

            //Category
            SelectElement select = new SelectElement(CategoryDropDown);
            select.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Category"));

            //Sub-Category
            SelectElement select1 = new SelectElement(SubCategoryDropDown);
            select1.SelectByText(GlobalDefinitions.ExcelLib.ReadData(2, "Sub-Category"));

            //Edited the Tags data
            System.Threading.Thread.Sleep(3000);
            Tags.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Tags"));

            Actions act = new Actions(GlobalDefinitions.driver);
            act.SendKeys(Keys.Enter).Perform();

            ServiceTypeOptions.Click();
            LocationTypeOption.Click();

            //Start date
            System.Threading.Thread.Sleep(3000);
            IWebElement startdate = StartDateDropDown;
            string dateformat = "ddMMyyyy";
            string sdate = GlobalDefinitions.ExcelLib.ReadData(2, "Startdate");
            string newstartdate = DateTime.Parse(sdate).ToString(dateformat);
            startdate.SendKeys(newstartdate);

            //Enddate
            IWebElement enddate = EndDateDropDown;
            string dateformat1 = "ddMMyyyy";
            string edate = GlobalDefinitions.ExcelLib.ReadData(2, "Enddate");
            string newenddate = DateTime.Parse(edate).ToString(dateformat1);
            enddate.SendKeys(newenddate.Substring(0, 2));
            enddate.SendKeys(newenddate.Substring(2, 2));
            act.SendKeys(Keys.ArrowRight).Perform();
            enddate.SendKeys(newenddate.Substring(4));

            System.Threading.Thread.Sleep(3000);
            string timeformat = "hh:mmtt";


            System.Threading.Thread.Sleep(1000);
            Tuesday.Click();

            //edited days and timings
            System.Threading.Thread.Sleep(3000);
            IWebElement tuestart = TueStartTime;
            string tstart = GlobalDefinitions.ExcelLib.ReadData(2, "Starttime");
            string newtuestarttime = DateTime.Parse(tstart).ToString(timeformat);
            tuestart.SendKeys(newtuestarttime);

            System.Threading.Thread.Sleep(3000);
            IWebElement tueend = TueEndTime;
            string tend = GlobalDefinitions.ExcelLib.ReadData(2, "Endtime");
            string newtueendtime = DateTime.Parse(tend).ToString(timeformat);
            tueend.SendKeys(newtueendtime);

            System.Threading.Thread.Sleep(1000);
            Wednesday.Click();

            System.Threading.Thread.Sleep(3000);
            IWebElement wedstart = WedStartTime;
            string wstart = GlobalDefinitions.ExcelLib.ReadData(3, "Starttime");
            string newwedstarttime = DateTime.Parse(wstart).ToString(timeformat);
            wedstart.SendKeys(newwedstarttime);

            System.Threading.Thread.Sleep(3000);
            IWebElement wedend = WedEndTime;
            string wend = GlobalDefinitions.ExcelLib.ReadData(3, "Endtime");
            string newwedendtime = DateTime.Parse(wend).ToString(timeformat);
            wedend.SendKeys(newwedendtime);

            System.Threading.Thread.Sleep(1000);
            Thus.Click();

            System.Threading.Thread.Sleep(3000);
            IWebElement thurstart = ThusStartTime;
            string thustart = GlobalDefinitions.ExcelLib.ReadData(4, "Starttime");
            string newthurstarttime = DateTime.Parse(thustart).ToString(timeformat);
            thurstart.SendKeys(newthurstarttime);

            System.Threading.Thread.Sleep(3000);
            IWebElement thurend = ThusEndTime;
            string thuend = GlobalDefinitions.ExcelLib.ReadData(4, "Endtime");
            string newthurendtime = DateTime.Parse(thuend).ToString(timeformat);
            thurend.SendKeys(newthurendtime);

            System.Threading.Thread.Sleep(1000);
            Friday.Click();

            System.Threading.Thread.Sleep(3000);
            IWebElement fristart = FriStartTime;
            string fstart = GlobalDefinitions.ExcelLib.ReadData(5, "Starttime");
            string newfristarttime = DateTime.Parse(fstart).ToString(timeformat);
            fristart.SendKeys(newfristarttime);

            System.Threading.Thread.Sleep(3000);
            IWebElement friend = FriEndTime;
            string fend = GlobalDefinitions.ExcelLib.ReadData(5, "Endtime");
            string newfriendtime = DateTime.Parse(fend).ToString(timeformat);
            friend.SendKeys(newfriendtime);

            SkillTradeOption.Click();
            System.Threading.Thread.Sleep(1000);
            CreditAmount.SendKeys(GlobalDefinitions.ExcelLib.ReadData(2, "Credit"));

            // using AutoIT helper class uploading a file in worksamples
            AutoIT auto = new AutoIT();
            auto.AutoItUpdatedDetails();

            HiddenOption.Click();
            Save.Click();

        }

        //Method to validate the skill edited 
        internal void ValidateEdit()
        {

            System.Threading.Thread.Sleep(1000);
            manageListingsLink.Click();
            IWebElement title = GlobalDefinitions.driver.FindElement(By.XPath("(//table[contains(@class,'ui striped')]//td)[3]"));
            Assert.AreEqual(GlobalDefinitions.ExcelLib.ReadData(2, "Title"), title.Text);
        }


    }
}
