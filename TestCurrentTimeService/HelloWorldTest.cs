using NUnit.Framework;
using Microsoft.AspNetCore.Mvc.Testing;
using System.Threading.Tasks;

namespace TestCurrentTimeService
{
    [TestFixture]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task TestRootEndpoint()
        {
            await using var application = new WebApplicationFactory<Program>();
            using var client = application.CreateClient();

            var response = await client.GetStringAsync( "/hello_world" );

            Assert.AreEqual( "Hello World!", response );
        }
    }
}