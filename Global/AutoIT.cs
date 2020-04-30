using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoItX3Lib;
using OpenQA.Selenium;

namespace MarsFramework.Global
{
    public class AutoIT
    {
        public void AutoItDetails()
        {
            GlobalDefinitions.driver.FindElement(By.XPath("//i[contains(@class,'huge plus circle icon padding-25')]")).Click();

            System.Threading.Thread.Sleep(3000);
            AutoItX3 autoit = new AutoItX3();
            autoit.WinActivate("File upload");
            autoit.Send(@"C:\Users\choll\OneDrive\Desktop\marsframework-master\marsframework-master\MarsFramework\TestData\AutoIT.txt");
            System.Threading.Thread.Sleep(3000);
            autoit.Send("{ENTER}");
        }
        public void AutoItUpdatedDetails()
        {
            GlobalDefinitions.driver.FindElement(By.XPath("//i[contains(@class,'huge plus circle icon padding-25')]")).Click();

            System.Threading.Thread.Sleep(3000);
            AutoItX3 autoit = new AutoItX3();
            autoit.WinActivate("File upload");
            autoit.Send(@"C:\Users\choll\OneDrive\Desktop\marsframework-master\marsframework-master\MarsFramework\TestData\AutoITedit.txt");
            System.Threading.Thread.Sleep(3000);
            autoit.Send("{ENTER}");
        }

    }
}

