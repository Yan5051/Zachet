using NUnit.Framework;
using ConsoleApp1;

namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.IsTrue(Program.EmptyFile("file1.txt"));
        }
        [Test]
        public void Test2()
        {
            Assert.IsTrue(Program.EmptyFile("file2.txt"));
        }
    }
}