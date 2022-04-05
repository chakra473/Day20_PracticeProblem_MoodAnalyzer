using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day20_MoodAnalyzer;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Arrange
            string expected = "HAPPY";
            string message = "I am in any Mood";
            MoodAnalyzer mood = new MoodAnalyzer();

            // Act
            string mood1 = mood.AnalyzeMood(message);

            //Assert
            Assert.AreEqual(expected, mood1);

        }
    }
}
