using NUnit.Framework;
using System;

namespace Logger
{
    public class Logdesign
    {
        public void TestStart()
        {
            TestContext.WriteLine("[" + DateTime.Now + "]: " + "======= Test has Started =======");

        }


        public void TestFinnished()
        {
            TestContext.WriteLine("[" + DateTime.Now + "]: " + "======= Test has Started =======");

        }



        public void Info( string message)
        {
            TestContext.WriteLine("[" + DateTime.Now + "]: Info:  " + message);

        }

        public void Info()
        {
            TestContext.WriteLine("[" + DateTime.Now + "]: Result:   As Expected");

        }

        public void Error(string expectedvalue, string actualValue)
        {
            TestContext.Out.WriteLine("[" + DateTime.Now + "]: Error:  " + "Expected: same as "+ expectedvalue+ ", but Actual is: " + actualValue);

        }



        public void Error(string message)
        {
            TestContext.Out.WriteLine("[" + DateTime.Now + "]: Error:  " + message);

        }




        public void Warning(string message)
        {
            TestContext.WriteLine("[" + DateTime.Now + "]: Warning:  " + message);

        }

        public void Warning()
        {
            TestContext.WriteLine("[" + DateTime.Now + "]: Warning:   Something went wrong...");

        }

    }
}
