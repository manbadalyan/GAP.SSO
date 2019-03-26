using OpenQA.Selenium;
using SeleniumExtras.PageObjects;


namespace PageObjects
{
    public class POErrorMessages : PageObject
    {

        //Email Empty Message* 
        [FindsBy(How = How.XPath, Using = "//*[text()='Please enter your email address']")]
        public IWebElement EmailEmptyMessage { get; set; }


        //Email Exists Message* 
        [FindsBy(How = How.XPath, Using = "//*[text()='The email address exists in the system, please check your email']")]
        public IWebElement EmailExistsMessage { get; set; }


        //Email Validation Message* 
        [FindsBy(How = How.XPath, Using = "//*[text()='Your email address is not valid email format']")]
        public IWebElement EmailInValidMessage { get; set; }

        //firstname  Empty Message* 
        [FindsBy(How = How.XPath, Using = "//*[text()='Please enter your first name']")]
        public IWebElement FNameEmptyMessage { get; set; }

        //firstname  Validation Message*  
        [FindsBy(How = How.XPath, Using = "//*[text()='Please enter your first name']")]
        public IWebElement FNameInValidMessage { get; set; }

        //Last name  Empty Message* 
        [FindsBy(How = How.XPath, Using = "//*[text()='Please enter your first name']")]
        public IWebElement LNameEmptyMessage { get; set; }

        //Last name  Validation Message*  
        [FindsBy(How = How.XPath, Using = "//*[text()='Please enter your first name']")]
        public IWebElement LNameInValidMessage { get; set; }

        //Password  Empty Message*  
        [FindsBy(How = How.XPath, Using = "//*[text()='Please enter your password']")]
        public IWebElement PasswordEmptyMessage { get; set; }

        //Password  Validation Message*  
        [FindsBy(How = How.XPath, Using = "//*[text()='Your password should be entered in a valid format']")]
        public IWebElement PasswordInValidMessage { get; set; }

        //Confirm Password  Empty Message*  
        [FindsBy(How = How.XPath, Using = "//*[text()='Please Re-enter your password']")]
        public IWebElement ConfirmPwdEmptyMessage { get; set; }


        //Terms Empty Message* 
        [FindsBy(How = How.XPath, Using = "//*[contains(text(), 'You must agree to the Terms of Use ')]")]
        public IWebElement TermEmptyMessage { get; set; }
    }
}
