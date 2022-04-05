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
            MoodAnalyzer mood = new MoodAnalyzer(null);

            // Act
            string mood1 = mood.AnalyzeMood();

            //Assert
            Assert.AreEqual(expected, mood1);

        }
    }
}
