using Logger;
using OpenQA.Selenium;
using PageObjects;
using TestInitalization;

namespace GapUITesting.GAPIdentity.Join
{
    public class JoinFieldsPresent
    {

        public static Logdesign log = new Logdesign();
        POJoin page = new POJoin();
        private readonly IWebDriver Driver;

        public JoinFieldsPresent()
        {
            Driver=Initialization.GetDriver;
        }

        public bool JEmail()
        {
            log.Info("Checking Email Field present");
            bool email = page.IsExists(page.JoinEmail);
            return email;
        }

        public bool JFirstName()
        {
            log.Info("Checking First Name Field present");
            bool firstName = page.IsExists(page.JoinFirstName);
            return firstName;

        }

        public bool JLastName()
        {
            log.Info("Checking Last Name Field present");
            bool lastName = page.IsExists(page.JoinLastName);
            return lastName;
        }


        public bool JPassword()
        {
            log.Info("Checking Password Field present");
            bool password = page.IsExists(page.JoinPassword);
            return password;
        }


        public bool JConfirmPassword()
        {
            log.Info("Checking Confirm Password Field present");
            bool confirmpassword = page.IsExists(page.JoinConfirmPassword);
            return confirmpassword;
        }

        public bool JTermOfUse()
        {
            log.Info("Checking Term Of Use checkbox present");
            bool term = page.IsExists(page.TermOfUse);
            return term;
        }

    }
}
