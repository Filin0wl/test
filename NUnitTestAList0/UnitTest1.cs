using NUnit.Framework;

namespace AList0
{
    [TestFixture]
    public class Tests
    {
        AL0 arrayTest, arrayTestMM;

        [SetUp]
        public void Setup()
        {
           // arrayTest = new AL0(new int[] { 1, 2, 3, 4, 5 });
            arrayTestMM = new AL0(new int[] { 1, -7, 4, 0, 5, 1, 3, 3, 6, 2, -1, -3 });

        }


        //ƒл€ перегруженных методов использовать несколько рзных тестов, две перегрузки, два теста
        
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, ExpectedResult = new int[] { 1, 2,3, 4, 5, 3 })]
        [Test]
        public int[] TestAddElementInEnd(int[] arrayT, int addNumber)
        {
            arrayTest = new AL0(arrayT);
            int[] result = arrayTest.AddElement(addNumber);
            return result;
        }
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, 0 , ExpectedResult = new int[] { 3, 1, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, -4, 4, ExpectedResult = new int[] { 1, 2, 3, 4, -4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 0, 1, ExpectedResult = new int[] { 1, 0, 2, 3, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, -7, 5, ExpectedResult = new int[] { 1, 2, 3, 4, 5,-7 })]
        [Test]
        public int[] TestAddElementIndex(int[] arrayT, int addNumber, int addIndex)
        {
            arrayTest = new AL0(arrayT);
            int[] result = arrayTest.AddElement(addNumber, addIndex);
            return result;

        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 3, ExpectedResult = new int[] { 1, 2, 3, 5 } )]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 2, ExpectedResult = new int[] { 1, 2, 4, 5 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, 0, ExpectedResult = new int[] { 2, 3, 4, 5, 6 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5 }, 4, ExpectedResult = new int[] { 1, 2, 3, 4 })]
        [Test]
        public int[] TestDelElement(int[] arrayT, int delIndex )
        {
            //int delIndex = 3;
            this.arrayTest = new AL0(arrayT);
            return this.arrayTest.DelElement(delIndex);
        }


        [Test]

        public void TestMaxElement()
        {
            int max = 6;
            Assert.AreEqual(max, this.arrayTestMM.MaxElement());

        }

        [Test]
        public void TestMaxIndex()
        {
            int max_i = 8;
            Assert.AreEqual(max_i, this.arrayTestMM.MaxElementIndex());
        }

        [Test]
        public void TestMinElement()
        {
            int min = -7;
            Assert.AreEqual(min, this.arrayTestMM.MinElement());
        }

        [Test]
        public void TestMinIndex()
        {
            int min_i = 1;
            Assert.AreEqual(min_i, this.arrayTestMM.MinElementIndex());
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5 }, ExpectedResult =  15)]
        [Test]
        public int TestSum(int[] arraySum )
        {
            arrayTest = new AL0(arraySum);
            //int sum = 15;
            return arrayTest.SumElement();
        }

       // [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, ExpectedResult = new int[] { 7, 6, 5, 4, 3, 2, 1 })]
        [TestCase(new int[] { 1, 2, 3, 4, 5, 6 }, ExpectedResult = new int[] { 4, 5, 6, 1, 2, 3 })]
        [Test]
        public int[] TestHalf(int[] arrayHalf)
        {
            arrayTest = new AL0(arrayHalf);
            return arrayTest.Half_array();
        }

        [TestCase(new int[] { 1, 2, 3, 4, 5, 6, 7 }, ExpectedResult = new int[] { 7, 6, 5, 4, 3, 2, 1 })]
        [Test]
        public int[] TestRevers(int[] arrayRev)
        {
            arrayTest = new AL0(arrayRev);
            return arrayTest.Revers();
        }

        [TestCase(new int[] {  2, 1, 8, -4, 52, 0, 7 }, ExpectedResult = new int[] { -4, 0, 1, 2, 7, 8, 52 })]
        [TestCase(new int[] {  2 }, ExpectedResult = new int[] {  2})]
        [Test]
        public int[] TestSotrBubble(int[] arraySort)
        {
            arrayTest = new AL0(arraySort);
            return arrayTest.Sort_Bubble();
        }

        [TestCase(new int[] { 2, 1, 8, -4, 52, 0, 7 }, ExpectedResult = new int[] { -4, 0, 1, 2, 7, 8, 52 })]
        [TestCase(new int[] { 2 }, ExpectedResult = new int[] { 2 })]
        [Test]
        public int[] TestSortSelect(int[] arraySort)
        {
            arrayTest = new AL0(arraySort);
            return arrayTest.Sort_Select();
        }

        [TestCase(new int[] { 2, 1, 8, -4, 52, 0, 7 }, ExpectedResult = new int[] { -4, 0, 1, 2, 7, 8, 52 })]
        [TestCase(new int[] { 2 }, ExpectedResult = new int[] { 2 })]
        [Test]
        public int[] TestSortInsert(int[] arraySort)
        {
            arrayTest = new AL0(arraySort);
            return arrayTest.Sort_Insert();
        }

        [TestCase(new int[] {1,2,3 }, new int[] {4,5 },ExpectedResult = new int[] { 1, 2, 3, 4, 5 })]
        [Test]
        public int[] TestAddArray(int[] arrayFirst, int[] arraySecond)
        {
            arrayTest = new AL0(arrayFirst);
            return arrayTest.AddArray(arraySecond);
        }
    }
}