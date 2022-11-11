using StudentServiceLib;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {

        private Student s;

        [TestInitialize]
        public void init()
        {
            s = new Student();
        }

        //Test case 1 
        [TestMethod]
        public void eightScore_returnA()
        {
            Student s = new Student();
            s.Name = "Hai";
            s.Score = 8;
            s.Age = 20;
            char letter = s.getLetterScore();

            Assert.AreEqual('A', letter);

        }

        //Test case 2
        [TestMethod]
        public void sevenScore_returnB()
        {
            Student s = new Student();
            s.Name = "Dien";
            s.Score = 7;
            s.Age = 20;
            char letter = s.getLetterScore();

            Assert.AreEqual('B', letter);

        }

        //Test case 3
        [TestMethod]
        public void fiveScore_returnC()
        {
            Student s = new Student();
            s.Name = "Son";
            s.Score = 5;
            s.Age = 20;
            char letter = s.getLetterScore();

            Assert.AreEqual('C', letter);

        }

        //Test case 4
        [TestMethod]
        public void threeScore_returnE()
        {
            Student s = new Student();
            s.Name = "Vuong";
            s.Score = 3;
            s.Age = 20;
            char letter = s.getLetterScore();

            Assert.AreEqual('E', letter);

        }
        [TestMethod]
        [DataRow(8, 'A')]

        public void testMulti(int score, char expect)
        {   
            Student student = new Student();
            student.Score = score;
            char letter = s.getLetterScore();
            Assert.AreEqual(expect, letter);
        }
    }
}