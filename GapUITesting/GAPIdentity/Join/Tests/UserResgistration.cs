using Allure.Commons;
using GapUITesting.GAPIdentity.Join.Steps;
using Logger;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;

namespace GapUITesting.GAPIdentity.Join.Tests
{


    // [TestFixture("IE")]
    // [TestFixture("Chrome")]
    [TestFixture("Firfox")]
    [Parallelizable(ParallelScope.Fixtures)]
    public class UserResgistration : GapIdentityTestSetup
    {
        /**params**/
        public static Logdesign log = new Logdesign();                 //log
        public UserResgistration(string browser) : base(browser) { }   //browser
        public static readonly UserGenerator.GenerateUsers user = new UserGenerator.GenerateUsers();
        /// <summary>
        /// Test user registration normal flow
        /// </summary>

        [Test(Description = "Check  when user enter valid values  ")]
        [TestCaseSource(typeof(TestCaseValidData), nameof(TestCaseValidData.TestCaseUserValidData))]
        [AllureTag("TBD")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureSubSuite("Join Software")]
        [AllureFeature]
        [AllureTms("TestCase ID: 15434")]

        public void CheckValidValues(string email, string firstname, string lastname, string password)
        {
            JoinTCURL jointab = new JoinTCURL();
            JoinEnterFieldsValues userreg = new JoinEnterFieldsValues();
            XMLDocument.XMLDocumentRW xml = new XMLDocument.XMLDocumentRW();

            //OPen URL
            jointab.OpenJoinTab();
            log.Info("Starting user registation");

            try
            {
                //Enter values 
                userreg.UserRegistration(email, firstname, lastname, password);

                log.Info("User has been registered successfully");
                Assert.Pass();

                //Add new email to .runsettings  XML file
                xml.XMLDocAddLine();
            }
            catch (NoSuchElementException)
            {
                log.Error("Unable to register a user");
                Assert.Fail();
            }


        }




    }
}
