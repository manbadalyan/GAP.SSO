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
    public class JoinWithEmptyFields : GapIdentityTestSetup
    {
        /**params**/
        public static Logdesign log = new Logdesign();                 //log
        public JoinWithEmptyFields(string browser) : base(browser) { }   //browser
        public static JoinTCURL jointab = new JoinTCURL();


        #region EMAIL address field is empty
        /// <summary>
        /// Check when  EMAIL address field is empty
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="password"></param>
        [Test(Description = "Check when  EMAIL address field is empty")]
        [TestCaseSource(typeof(TestCaseValidData), nameof(TestCaseValidData.TestCaseUserEmail))]

        [AllureTag("TBD")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureSubSuite("Join Software")]
        [AllureFeature]
        [AllureTms("TestCase ID: 15464")]
        public void EmptyEmail(string firstname, string lastname, string password)
        {

            JoinTCURL jointab = new JoinTCURL();
            JoinEnterFieldsValues userreg = new JoinEnterFieldsValues();
            FindErrorMessages err = new FindErrorMessages();
            //OPen URL
            jointab.OpenJoinTab();
            log.Info("Starting user registation");

            try
            {
                // EMAIL address field is empty 
                userreg.UserRegistration("", firstname, lastname, password);

                if (err.EmailEmptyErrorMessage())
                {
                    log.Info("EMAIL empty error massage is correct");
                    Assert.Pass();
                }
                else
                {
                    log.Error("Unable find EMAIL empty error massage");
                    Assert.Fail();

                }
            }
            catch (NoSuchElementException)
            {
                log.Error("Unable to register a user");
                Assert.Fail();
            }

        }

#endregion





        #region First Name field is empty
        /// <summary>
        /// Check when First Name field is empty
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="password"></param>
        [Test(Description = "Check when First Name field is empty")]
        [TestCaseSource(typeof(TestCaseValidData), nameof(TestCaseValidData.TestCaseUserName))]

        [AllureTag("TBD")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureSubSuite("Join Software")]
        [AllureFeature]
        [AllureTms("TestCase ID: 15465")]
        public void EmptyFist(string email, string lastname, string password)
        {

            JoinTCURL jointab = new JoinTCURL();
            JoinEnterFieldsValues userreg = new JoinEnterFieldsValues();
            FindErrorMessages err = new FindErrorMessages();
            //OPen URL
            jointab.OpenJoinTab();
            log.Info("Starting user registation");

            try
            {
                // EMAIL address field is empty 
                userreg.UserRegistration(email, "" ,lastname, password);

                if (err.FNEmptyErrorMessage())
                {
                    log.Info("First Name empty error massage is correct");
                    Assert.Pass();
                }
                else
                {
                    log.Error("Unable find First Name empty error massage");
                    Assert.Fail();

                }
            }
            catch (NoSuchElementException)
            {
                log.Error("Unable to register a user");
                Assert.Fail();
            }

        }

#endregion




        #region Last Name field is empty
        /// <summary>
        /// Check when Last Name field is empty
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="password"></param>
        [Test(Description = "Check when Last Name field is empty")]
        [TestCaseSource(typeof(TestCaseValidData), nameof(TestCaseValidData.TestCaseUserName))]

        [AllureTag("TBD")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureSubSuite("Join Software")]
        [AllureFeature]
        [AllureTms("TestCase ID: 15466")]
        public void EmptyLast(string email, string firstname, string password)
        {

            JoinTCURL jointab = new JoinTCURL();
            JoinEnterFieldsValues userreg = new JoinEnterFieldsValues();
            FindErrorMessages err = new FindErrorMessages();
            //OPen URL
            jointab.OpenJoinTab();
            log.Info("Starting user registation");

            try
            {
                // EMAIL address field is empty 
                userreg.UserRegistration(email, firstname, "", password);

                if (err.LNEmptyErrorMessage())
                {
                    log.Info("Last Name empty error massage is correct");
                    Assert.Pass();
                }
                else
                {
                    log.Error("Unable find Last Name empty error massage");
                    Assert.Fail();

                }
            }
            catch (NoSuchElementException)
            {
                log.Error("Unable to register a user");
                Assert.Fail();
            }

        }

        #endregion




        #region Password field is empty
        /// <summary>
        /// Check when Password Name field is empty
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="password"></param>
        [Test(Description = "Check when Password field is empty")]
        [TestCaseSource(typeof(TestCaseValidData), nameof(TestCaseValidData.TestCaseUserPsw))]

        [AllureTag("TBD")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureSubSuite("Join Software")]
        [AllureFeature]
        [AllureTms("TestCase ID: 15468")]
        public void EmptyPassword(string email, string firstname,  string lastname)
        {

            JoinTCURL jointab = new JoinTCURL();
            JoinEnterFieldsValues userreg = new JoinEnterFieldsValues();
            FindErrorMessages err = new FindErrorMessages();
            //OPen URL
            jointab.OpenJoinTab();
            log.Info("Starting user registation");

            try
            {
                // EMAIL address field is empty 
                userreg.UserRegistration(email, firstname, lastname, "");

                if (err.PasswordEmptyErrorMessage())
                {
                    log.Info("Password empty error massage is correct");
                    Assert.Pass();
                }
                else
                {
                    log.Error("Unable find Password empty error massage");
                    Assert.Fail();

                }
            }
            catch (NoSuchElementException)
            {
                log.Error("Unable to register a user");
                Assert.Fail();
            }

        }
        #endregion




        #region Confirm Password field is empty
        /// <summary>
        /// Check when Confirm Password Name field is empty
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="password"></param>
        [Test(Description = "Check when Confirm Password field is empty")]
        [TestCaseSource(typeof(TestCaseValidData), nameof(TestCaseValidData.TestCaseUserValidData))]

        [AllureTag("TBD")]
        [AllureSeverity(SeverityLevel.critical)]
        [AllureSubSuite("Join Software")]
        [AllureFeature]
        [AllureTms("TestCase ID: 15469")]
        public void EmptyConfirmpws(string email, string firstname, string lastname, string password)
        {

            JoinTCURL jointab = new JoinTCURL();
            JoinEnterFieldsValues userreg = new JoinEnterFieldsValues();
            FindErrorMessages err = new FindErrorMessages();
            //OPen URL
            jointab.OpenJoinTab();
            log.Info("Starting user registation");

            try
            {
                // EMAIL address field is empty 
                userreg.UserRegistrationMissedPws(email, firstname, lastname, password);

                if (err.ConfirmPswEmptyErrorMessage())
                {
                    log.Info("Re-Enter Password empty error massage is correct");
                    Assert.Pass();
                }
                else
                {
                    log.Error("Unable find Re-Enter Password empty error massage");
                    Assert.Fail();

                }
            }
            catch (NoSuchElementException)
            {
                log.Error("Unable to register a user");
                Assert.Fail();
            }

        }
        #endregion




        #region Term of used checkbox is not checked
        /// <summary>
        /// Check when erm of used checkbox is not checked
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="password"></param>
        [Test(Description = "Check when erm of used checkbox is not checked")]
        [TestCaseSource(typeof(TestCaseValidData), nameof(TestCaseValidData.TestCaseUserValidData))]
        [AllureTag("TBD")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureSubSuite("Join Software")]
        [AllureFeature]
        [AllureTms("TestCase ID: 15471")]
        public void EmptyTerm(string email, string firstname, string lastname, string password)
        {

            JoinTCURL jointab = new JoinTCURL();
            JoinEnterFieldsValues userreg = new JoinEnterFieldsValues();
            FindErrorMessages err = new FindErrorMessages();
            //OPen URL
            jointab.OpenJoinTab();
            log.Info("Starting user registation");

            try
            {
                // EMAIL address field is empty 
                userreg.UserRegistrationErrorTerm(email, firstname, lastname, password);

                if (err.TermEmptyErrorMessage())
                {
                    log.Info("Term of use error massage is correct");
                    Assert.Pass();
                }
                else
                {
                    log.Error("Unable find Term of use empty error massage");
                    Assert.Fail();

                }
            }
            catch (NoSuchElementException)
            {
                log.Error("Unable to register a user");
                Assert.Fail();
            }

        }
        #endregion




        #region All fields are empty
        /// <summary>
        /// Check when erm of used checkbox is not checked
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="password"></param>
        [Test(Description = "Check when erm of used checkbox is not checked")]
        [AllureTag("TBD")]
        [AllureSeverity(SeverityLevel.normal)]
        [AllureSubSuite("Join Software")]
        [AllureFeature]
        [AllureTms("TestCase ID: 15471")]
        public void EmptyALLFields()
        {

            JoinTCURL jointab = new JoinTCURL();
            JoinEnterFieldsValues userreg = new JoinEnterFieldsValues();
            FindErrorMessages err = new FindErrorMessages();
            //OPen URL
            jointab.OpenJoinTab();
            log.Info("Starting user registation");

            try
            {
                // EMAIL address field is empty 
                userreg.UserRegistrationEmptyFields();

                if (err.EmailEmptyErrorMessage() 
                    && err.FNEmptyErrorMessage() 
                    && err.LNEmptyErrorMessage() 
                    && err.PasswordEmptyErrorMessage() 
                    && err.ConfirmPswEmptyErrorMessage()
                    && err.TermEmptyErrorMessage())
                {
                    log.Info("All empty error massages are correct");
                    Assert.Pass();
                }
                else
                {
                    log.Error("Unable find empty fields error massages");
                    Assert.Fail();

                }
            }
            catch (NoSuchElementException)
            {
                log.Error("Unable to register a user");
                Assert.Fail();
            }

        }
        #endregion


    }
}
