using NUnit.Framework;
using System.Linq;
using System.Xml.Linq;

namespace XMLDocument
{
    public class XMLDocumentRW
    {
        public static readonly string xmlpath = TestContext.Parameters["XMLDoc"];
        public static readonly UserGenerator.GenerateUsers users = new UserGenerator.GenerateUsers();

        public int XCount()
        {

            XDocument doc = XDocument.Load(xmlpath);
            int count = doc.Root.Descendants("Parameter").Count();
            return  count ;
        }


        public void XMLDocAddLine()
        {
            var data = users.CreateUser();
            XDocument  doc = XDocument.Load(xmlpath);
            XElement root = new XElement("Parameter",
           new XAttribute("name", ("Email_" + XCount())),
            new XAttribute("value", data.Email));
            doc.Root.Element("TestRunParameters").Add(root);
            doc.Save(xmlpath);

        }
    }
}
