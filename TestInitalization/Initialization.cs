using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Diagnostics;
using System.Linq;
using OpenQA.Selenium.Edge;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using Allure.Commons;
using NUnit.Allure.Core;
using System.Xml;
using Logger;
using System.Collections.ObjectModel;

namespace TestInitalization
{
    public class Initialization
    {

        public static IWebDriver WebDriver { get; set; }
        private WebDriverWait Wait { get; set; }
        public static Stopwatch _stopWatch = new Stopwatch();
        public static Logdesign log = new Logdesign(); 


        public static void Init(string baseURL, string browser, int sec, string xmlpath, string stand)
        {

            _stopWatch = Stopwatch.StartNew();
            log.TestStart();

            switch (browser)
            {
                case "IE":
                    WebDriver = new InternetExplorerDriver();
                    break;
                case "Firefox":
                    WebDriver = new FirefoxDriver(@"D:\Driver");                    
                    break;
                case "Edge":
                    WebDriver = new EdgeDriver();
                    break;
                default:  
                    WebDriver = new ChromeDriver(@"D:\Driver");                    
                    break;
            }
            WebDriver.Manage().Window.Maximize();
            ChangeBrowserTab();
            Goto(baseURL, sec);
            UpdateXMLFile(xmlpath, browser, stand, baseURL);
        }

        public static string Title
        {
            get { return WebDriver.Title; }
        }
        public static IWebDriver GetDriver
        {
            get { return WebDriver; }
        }

        public static void ChangeBrowserTab()
        {
            try
            {
                GetDriver.SwitchTo().Window(GetDriver.WindowHandles.Last());
                string t = Title;
            }
            catch (Exception e)
            {
                Assert.Fail("Cannot Navigate to new window... " + e);
            }
        }


        public static void Goto(string url, int sec)
        {
            try
            {
                WebDriver.Navigate().GoToUrl(url);
                //WebDriver.Url = url;
                WebDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(sec);
            }
            catch (Exception e)
            {
                
                Assert.Fail("Cannot open URL" + e);
            }
        }


        public static void Close(string scrshot_path)
        {
            try
            {
                if (TestContext.CurrentContext.Result.Outcome != ResultState.Success)
                {
                    AllureExtensions.WrapSetUpTearDownParams(() =>
                    {
                        var screenshot = ((ITakesScreenshot)GetDriver).GetScreenshot();
                        screenshot.SaveAsFile(scrshot_path, ScreenshotImageFormat.Png);
                        AllureLifecycle.Instance.AddAttachment(scrshot_path);
                    }, "After Test");

                }
                WebDriver.Close();
                WebDriver.Quit();
                log.TestFinnished();
            }
            catch (Exception e)
            {
                //StackTrace e = new StackTrace();
                Assert.Fail("Cannot close driver... " + e);
            }
            _stopWatch.Stop();
        }

        public static void ScreenShot(string scrshot_path)
        {
            var screenshot = ((ITakesScreenshot)GetDriver).GetScreenshot();
            screenshot.SaveAsFile(scrshot_path, ScreenshotImageFormat.Png);
        }



        public static void UpdateXMLFile(string xmlpath, string browsername, string stand, string baseURL)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(xmlpath);
            xmlDoc.InnerXml =
                @"<environment>
  <parameter>
    <key>Browser</key>
    <value>" + browsername + @"</value>
  </parameter>

  <parameter>
    <key>Stand</key>
    <value>" + stand + @"</value>
  </parameter>

    <parameter>
    <key>URL</key>
    <value>" + baseURL + @"</value>
  </parameter>
</environment> ";
            xmlDoc.Save(xmlpath);
        }


    }
}
