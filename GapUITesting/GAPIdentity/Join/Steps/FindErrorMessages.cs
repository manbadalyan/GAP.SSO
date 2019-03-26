using Allure.Commons;
using Logger;
using NUnit.Allure.Attributes;
using NUnit.Framework;
using OpenQA.Selenium;
using PageObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace GapUITesting.GAPIdentity.Join.Steps
{
    
    public class FindErrorMessages 
    {
        public static Logdesign log = new Logdesign();                 //log
        POErrorMessages page = new POErrorMessages();                  //pageobject

        /// <summary>
        /// Check if Email Empty Error Message show 
        /// </summary>
        /// <returns></returns>
        public bool EmailEmptyErrorMessage()
        {
            log.Info("Checking Empty Error Message when EMAIL has not been entered");
            bool emailEmptyErrorMessage = page.IsExists(page.EmailEmptyMessage);
            return emailEmptyErrorMessage;
        }


        /// <summary>
        /// Check if First Name Empty Error Message show 
        /// </summary>
        /// <returns></returns>
        public bool FNEmptyErrorMessage()
        {
            log.Info("Checking Empty Error Message when FIRST NAME has not been entered");
            bool fnEmptyErrorMessage = page.IsExists(page.EmailEmptyMessage);
            return fnEmptyErrorMessage;
        }


        /// <summary>
        /// Check if Last Name Empty Error Message show 
        /// </summary>
        /// <returns></returns>
        public bool LNEmptyErrorMessage()
        {
            log.Info("Checking Empty Error Message when LAST NAME has not been entered");
            bool lnEmptyErrorMessage = page.IsExists(page.EmailEmptyMessage);
            return lnEmptyErrorMessage;
        }


        /// <summary>
        /// Check if Password Empty Error Message show 
        /// </summary>
        /// <returns></returns>
        public bool PasswordEmptyErrorMessage()
        {
            log.Info("Checking Empty Error Message when PASSWORD has not been entered");
            bool pswEmptyErrorMessage = page.IsExists(page.EmailEmptyMessage);
            return pswEmptyErrorMessage;
        }


        /// <summary>
        /// Check if Confirm Password Empty Error Message show 
        /// </summary>
        /// <returns></returns>
        public bool ConfirmPswEmptyErrorMessage()
        {
            log.Info("Checking Empty Error Message when PASSWORD has not been re-entered");
            bool cnfpswEmptyErrorMessage = page.IsExists(page.EmailEmptyMessage);
            return cnfpswEmptyErrorMessage;
        }


        /// <summary>
        /// Check if Term of use Empty Error Message show 
        /// </summary>
        /// <returns></returns>
        public bool TermEmptyErrorMessage()
        {
            log.Info("Checking Empty Error Message when Term of used is not checked");
            bool termEmptyErrorMessage = page.IsExists(page.TermEmptyMessage);
            return termEmptyErrorMessage;
        }

    }
}
