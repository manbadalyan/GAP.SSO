using GapUITesting.GAPIdentity.Join.Steps;
using Logger;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Collections.Generic;

namespace GapUITesting.GAPIdentity.Join.Tests
{
    [TestFixture("IE")]
    [Parallelizable(ParallelScope.Fixtures)]
    public class Test : GapIdentityTestSetup
    {
        /**params**/
        public static Logdesign log = new Logdesign();                 //log
        public Test(string browser) : base(browser) { }   //browser
        public static XMLDocument.XMLDocumentRW xml = new XMLDocument.XMLDocumentRW();
        public static readonly UserGenerator.GenerateUsers users = new UserGenerator.GenerateUsers();


        [Test(Description = "test")]
        [TestCaseSource(typeof(TestCaseValidData), nameof(TestCaseValidData.TestCaseUserValidData))]
        public void NewGenerate(string email, string firstname, string lastname, string password)
        {
                      

            try
            {
                xml.XMLDocAddLine();
                log.Error("Unable to register a user");


            }
            catch (NoSuchElementException)
            {
                log.Error("Unable to register a user");
                Assert.Fail();
            }

        }


        public static IEnumerable<TestCaseData> TestCaseUserValidData()
        {
            var data = users.CreateUser();
            yield return new TestCaseData(data.Email, data.FirstName, data.LastName, data.Password);
            //var testCases = new List<TestCaseData>();
            //var data = users.CreateUser();
            //var testCase = new TestCaseData(data.Email, data.FirstName, data.LastName, data.Password);
            //testCases.Add(testCase);
            //log.Info("User Data: Email: " + data.Email + ", First Name: " + data.FirstName + ", Last Name: " + data.LastName + ", Password" + data.Password);
            //return testCases;


        }
    }
}
