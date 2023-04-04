using NUnit.Framework;

namespace C_pohja.Tests
{
    public class HelloWorldTests
    {
        [Test]
        public void TestHelloWorld()
        {
            // Arrange
            var expected = "Hello, World!";

            // Act
            var actual = Program.GetHelloWorld();

            // Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
