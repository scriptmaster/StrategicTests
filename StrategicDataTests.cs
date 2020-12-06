using NUnit.Framework;
using StrategicData;
using Microsoft.Extensions.Configuration;

namespace StrategicTests
{
    public class StrategicDataTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestConfiguration()
        {
            // Assert.Pass();

            var stratConf= new StrategicConfiguration();
            var conf = stratConf.Configuration;

            var cn = conf.GetConnectionString("sqlserver");
            Assert.That(!string.IsNullOrEmpty(cn));
        }
    }
}
