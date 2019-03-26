using Logger;
using OpenQA.Selenium;
using PageObjects;
using TestInitalization;

namespace GapUITesting.GAPIdentity.Join
{
    public class JoinEnterFieldsValues
    {
        private readonly IWebDriver Driver;
        public static Logdesign log = new Logdesign();
        POJoin page = new POJoin();

        public JoinEnterFieldsValues() => Driver = Initialization.GetDriver;


        #region User registartion (Normal Flow)
        /// <summary>
        /// User registartion (Normal Flow)
        /// </summary>
        /// <param name="email"></param>
        /// <param name="firstname"></param>
        /// <param name="lasttname"></param>
        /// <param name="password"></param>
        public void UserRegistration(string email, string firstname, string lasttname, string password)
        {
            page.JoinEmail.SendKeys(email);
            log.Info("Enter email= " + email);

            page.JoinFirstName.SendKeys(firstname);
            log.Info("Enter First Name= " + firstname);


            page.JoinLastName.SendKeys(lasttname);
            log.Info("Enter Last Name= " + lasttname);


            page.JoinPassword.SendKeys(password);
            log.Info("Enter Password Name= " + password);

            page.JoinConfirmPassword.SendKeys(password);
            log.Info("Re-Enter Password Name= " + password);


            page.TermOfUse.Click();
            log.Info("Click Term of use");

            page.Join.Click();
            log.Info("Join Button");

            page.IsExists(page.EmailSent);
            log.Info("Page has been redirected to the Email varification page. ");

        }

        #endregion


        #region User registartion when re-enter password is empty
        /// <summary>
        /// User registartion when re-enter password is empty
        /// </summary>
        /// <param name="email"></param>
        /// <param name="firstname"></param>
        /// <param name="lasttname"></param>
        /// <param name="password"></param>
        public void UserRegistrationMissedPws(string email, string firstname, string lasttname, string password)
        {
            page.JoinEmail.SendKeys(email);
            log.Info("Enter email= " + email);

            page.JoinFirstName.SendKeys(firstname);
            log.Info("Enter First Name= " + firstname);


            page.JoinLastName.SendKeys(lasttname);
            log.Info("Enter Last Name= " + lasttname);


            page.JoinPassword.SendKeys(password);
            log.Info("Enter Password Name= " + password);

            page.TermOfUse.Click();
            log.Info("Click Term of use");

            page.Join.Click();
            log.Info("Join Button");


        }
        #endregion



        #region User registartion when Term of used is not checked
        /// <summary>
        /// User registartion when Term of used is not checked
        /// </summary>
        /// <param name="email"></param>
        /// <param name="firstname"></param>
        /// <param name="lasttname"></param>
        /// <param name="password"></param>
        public void UserRegistrationErrorTerm(string email, string firstname, string lasttname, string password)
        {
            page.JoinEmail.SendKeys(email);
            log.Info("Enter email= " + email);

            page.JoinFirstName.SendKeys(firstname);
            log.Info("Enter First Name= " + firstname);


            page.JoinLastName.SendKeys(lasttname);
            log.Info("Enter Last Name= " + lasttname);


            page.JoinPassword.SendKeys(password);
            log.Info("Enter Password Name= " + password);

            page.JoinConfirmPassword.SendKeys(password);
            log.Info("Re-Enter Password Name= " + password);

            page.Join.Click();
            log.Info("Join Button");
        }
        #endregion



        #region User registartion when Term of used is not checked
        /// <summary>
        /// User registartion when All fields are empty
        /// </summary>
        public void UserRegistrationEmptyFields()
        {
            page.Join.Click();
            log.Info("Join Button");
        }
        #endregion

    }
}
