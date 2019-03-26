using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace PageObjects
{
    public class POJoin : PageObject
    {
        //Join link  
        [FindsBy(How = How.XPath, Using = "//*[text()='Client Login']")]
        public IWebElement Joinlink { get; set; }

        //Email* 
        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement JoinEmail { get; set; }


        //First Name* 
        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement JoinFirstName { get; set; }

        //Last Name* 
        [FindsBy(How = How.Name, Using = "LastName")]
        public IWebElement JoinLastName { get; set; }

        //Password* 
        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement JoinPassword { get; set; }



        //Re-type Password*  
        [FindsBy(How = How.Name, Using = "ConfirmPwd")]
        public IWebElement JoinConfirmPassword { get; set; }



        // terms of use.*  
        [FindsBy(How = How.Name, Using = "IsAgreed")]
        public IWebElement TermOfUse { get; set; }


        //Join link  
        [FindsBy(How = How.XPath, Using = "//*[@id='register']/a[2]")]
        public IWebElement DLJoin { get; set; }

        //Join link  
        [FindsBy(How = How.Name, Using = "Gap SignIn")]
        public IWebElement Join { get; set; }


        //Join link  
        [FindsBy(How = How.XPath, Using = "//*[contains(text(), 'Check Your Email.')]")]
        public IWebElement EmailSent { get; set; }
    }
}
