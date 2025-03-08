using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;

namespace DotNetFrameworkApp.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestJsonSerialization()
        {
            var person = new { Name = "John Doe", Age = 30 };
            string json = JsonConvert.SerializeObject(person);
            Assert.IsTrue(json.Contains("John Doe"));
        }
    }
}