using System.Diagnostics.CodeAnalysis;

namespace TestNUnit
{
    [ExcludeFromCodeCoverage]
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [Ignore("Em desenvolvimento")]

        public void Test1()
        {
            Assert.Pass();
        }
    }
}