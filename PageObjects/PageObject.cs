using System;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using TestInitalization;

namespace PageObjects
{
    public class PageObject
    {
        private readonly IWebDriver Driver;

        public PageObject()
        {
            Driver = Initialization.GetDriver;
            PageFactory.InitElements(Driver, this);
        }

        /// <summary>
        /// Is current element exists 
        /// </summary>
        /// <param name="element"></param>
        /// <returns>true if exists, false if doesn't exist </returns>
        public bool IsExists(IWebElement element)
        {
            try
            {
                return element.Displayed;

            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        /// <summary>
        /// Is page completly loaded
        /// </summary>
        /// <returns></returns>
        public bool IsPageLoaded()
        {
            try
            {
                //Wait.Until(d => ((IJavaScriptExecutor)d).ExecuteScript("return document.readyState").Equals("complete"));
                Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(1000);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

        /// <summary>
        /// Wait some sec Is current element exists 
        /// </summary>
        /// <param name="element"></param>
        /// <param name="timeout"></param>
        /// <returns>true if exists, false if doesn't exist</returns>
        public bool WaitUntilElementIsPresent(IWebElement element, int timeout)
        {
            for (var i = 0; i < timeout; i++)
            {
                if (IsExists(element))
                    return true;
            }
            return false;
        }


    }
}
