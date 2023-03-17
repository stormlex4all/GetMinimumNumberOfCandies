using DataStructureAlgorithms;
using System.Reflection;

namespace MinimumNumberOfCandiesTests
{
    public class Tests
    {
        [Test]
        public void SimpleTest1()
        {
            //arrange
            var codeBase = Directory.GetParent(Directory.GetCurrentDirectory());
            string test = codeBase.Parent.Parent.FullName + "\\ShortTest1.txt";
            List<int> inp = File.ReadAllLines(test).Select(x => int.Parse(x)).ToList();
            int n = inp.ElementAt(0);
            inp.RemoveAt(0);
            long expectedResult = 19;

            //Act
            long actualResult = Program.GetMinimumNumberOfCandies(n, inp);

            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void SimpleTest2()
        {
            //arrange
            var codeBase = Directory.GetParent(Directory.GetCurrentDirectory());
            List<int> inp = File.ReadAllLines(codeBase.Parent.Parent.FullName + "\\ShortTest2.txt").Select(x => int.Parse(x)).ToList();
            int n = inp.ElementAt(0);
            inp.RemoveAt(0);
            long expectedResult = 12;

            //Act
            long actualResult = Program.GetMinimumNumberOfCandies(n, inp);

            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }

        [Test]
        public void LongTest1()
        {
            //arrange
            var codeBase = Directory.GetParent(Directory.GetCurrentDirectory());
            List<int> inp = File.ReadAllLines(codeBase.Parent.Parent.FullName + "\\LongTest1.txt").Select(x => int.Parse(x)).ToList();
            int n = inp.ElementAt(0);
            inp.RemoveAt(0);
            long expectedResult = 5000050000;

            //Act
            long actualResult = Program.GetMinimumNumberOfCandies(n, inp);

            //Assert
            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
    }
}