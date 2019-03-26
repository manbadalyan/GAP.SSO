using TestInitalization;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using NUnit.Framework;
using System;
using System.Globalization;

namespace GapUITesting.GAPIdentity
{
    [TestFixture]
    [Author("Manushak Badalyan")]
    [AllureNUnit]
    [AllureOwner("Manushak Badalyan")]
    [AllureSuite("SSO")]
    public class GapIdentityTestSetup
    {
        #region Set Values

        //Timeout
        readonly int sec = 1;
        #endregion

        #region Get Params

        //Get Environment 
        enum Stand { Local, Prep, Live, Deloitte }
        private static readonly string standname =Stand.Deloitte.ToString();
        public static readonly string baseURL = TestContext.Parameters[standname];

        //Get Screenshot directory
        private static readonly string screenshot_path = TestContext.Parameters["AllureScreenshotPath"]
            + DateTime.Now.ToString("yyyy_MM_dd_HHmm", CultureInfo.InvariantCulture) + ".png"; //D

        //Get browser: default is chrome
        enum Br { IE, Firefox, Edge }
        protected string browser="IE";
        #endregion

        public GapIdentityTestSetup(string browser)
        {
            this.browser = browser;
        }
        

        #region TestSetup
        /// <summary>
        /// Before Test Setup WebDriver-Browsername, get URL
        /// </summary>
        [SetUp]
        public void Setup()
        {
            
            Initialization.Init(
                baseURL,
                browser,
                sec,
                TestContext.Parameters["Environment"],
                standname
                );

        }

        /// <summary>
        /// After test driver close browser 
        /// </summary>
        [TearDown]
        public void AfterTest()
        {
            Initialization.Close(screenshot_path);

        }

        #endregion


    }
}
