using NUnit.Framework;
using MarsFramework.Pages;
using RelevantCodes.ExtentReports;
namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class User : Global.Base
        {
            //To SignIn 
            [Test]
            public void SignInPage()
            {
                SignIn sign = new SignIn();

                sign.LoginSteps();
                MarsFramework.Global.Base.test.Log(LogStatus.Pass, "Successfully SignIn");

                sign.validate();

            }


            //To Enter the details in ShareSkill Page
            [Test, Order(1)]
            public void ShareSkillPage()
            {
                ShareSkill skill = new ShareSkill();

                skill.EnterShareSkill();
                MarsFramework.Global.Base.test.Log(LogStatus.Pass, "Successfully Entered the details");

                //validate skill saved
                skill.ValidateEnter();


            }


            //To Edit the skill in ManageListing
            [Test, Order(2)]
            public void EditShareSkillPage()
            {
                EditShareSkill edit = new EditShareSkill();
                edit.EditSkill();

                MarsFramework.Global.Base.test.Log(LogStatus.Pass, "Successfully Edited the details");

                //validate the edit 
                edit.ValidateEdit();
            }

            //To Delete the skill in ManageListing
            [Test, Order(3)]
            public void ManageListingsPage()
            {
                ManageListings listings = new ManageListings();

                listings.Listings();
                MarsFramework.Global.Base.test.Log(LogStatus.Pass, "Delete Successfully");

                //validate the delete 
                listings.Delete();

            }

        }
    }
}