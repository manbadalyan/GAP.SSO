using Allure.Commons;
using GapUITesting.GAPIdentity;
using GapUITesting.GAPIdentity.Join;
using Logger;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;
using System;

namespace JoinForm
{

    // [TestFixture("IE")]
    // [TestFixture("Chrome")]
    [TestFixture("Firfox")]
    [Parallelizable(ParallelScope.Fixtures)]
    public class JoinTests: GapIdentityTestSetup
    {
        /**Params**/
        public static Logdesign log = new Logdesign();         //Log
        public JoinTests(string browser) : base(browser) { }    //browser



        /// <summary>
        /// Test is join button from main page cliclable or not
        /// </summary>
        [Test(Description = "Check Join  Tab")]
        [AllureTag("TBD")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureSubSuite("Join Software")] 
        [AllureFeature]
        [AllureTms("TestCase ID: 15496")]
        public void CheckJoinTab()
        {
            log.Info("Click 'Join' Tab");
            try
            {
                JoinTCURL jointab = new JoinTCURL();
                //open
                jointab.OpenJoinTab();
                log.Info();

            }
            catch (NoSuchElementException)
            {
                log.Error(" Unable to click Join Tab");
                Assert.Fail("[" + DateTime.Now + "]: Error" + " Unable to click Join Tab");

            }

        }


        /// <summary>
        /// Verify URL when clicking Join from the main page
        /// </summary>
        [Test(Description = "Check URL")]
        [AllureTag("TBD")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureSubSuite("Join Software")]
        [AllureFeature]
        [AllureTms("TestCase ID: 15497")]
        public void CheckURL()
        {
            JoinTCURL jointab = new JoinTCURL();
            log.Info("Check URL");
            string expectedurl = "https://live.gapinternational.com/"; // Expected URL
            string actualurl = jointab.CheckUrl();                     //Actual URL 
            if (expectedurl == actualurl)
            {
                log.Info();
                Assert.Pass();

            }
            else
            {
                log.Error(expectedurl, actualurl);
                Assert.Fail("URL not as expected");

            }

        }



        /// <summary>
        /// Verify that the Registration form contains Email, First Name, ..
        /// Last Name, Password, Confirm Password, Terms of use, Join
        /// </summary>
        [Test(Description = "Check Join Tab Forms")]
        [AllureTag("TBD")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureSubSuite("Join Software")]
        [AllureFeature]
        [AllureTms("TestCase ID: 15542")]
        public void CheckJoinForm()
        {
            JoinTCURL jointab = new JoinTCURL();
            JoinFieldsPresent jfields = new JoinFieldsPresent();
            jointab.OpenJoinTab();
            log.Info("Check all form are present or not");

            if (jfields.JEmail() & jfields.JFirstName() & jfields.JLastName() & jfields.JPassword() & jfields.JConfirmPassword() & jfields.JTermOfUse())
            {
                log.Info("All fields are present");
                Assert.Pass();

            }
            else
            {
                log.Error("Needed forms are not present.");
                Assert.Fail();
            }


        }

    }


}