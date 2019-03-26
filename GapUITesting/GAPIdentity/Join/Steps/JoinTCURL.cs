using Logger;
using OpenQA.Selenium;
using PageObjects;
using TestInitalization;


namespace GapUITesting.GAPIdentity.Join
{
    public class JoinTCURL
    {
        private readonly IWebDriver Driver;
        POJoin page = new POJoin();
        //Log
        public static Logdesign log = new Logdesign();

        public JoinTCURL() => Driver = Initialization.GetDriver;


        public void OpenJoinTab()
        {
            page.Joinlink.Click();
            log.Info("Clicking 'Join' Tab");
            Initialization.ChangeBrowserTab();

        }



        public string CheckUrl()
        {
            page.Joinlink.Click();
            //Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            string url = page.Join.GetAttribute("href");
            log.Info("Current URL is: " + url);
            return url;
        }



    }
}
