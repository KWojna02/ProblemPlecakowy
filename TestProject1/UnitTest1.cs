using ProblemPlecakowy;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {



        [TestMethod]
        public void Test1()
        {
            Problem problem = new Problem(3, 1);
            int capacity = 10;

            Result result = problem.Solve(capacity);

            Assert.IsTrue(result.selectedItems.Count > 0);
        }

        [TestMethod]
        public void Test2()
        {
            Problem problem = new Problem(3, 1);
            int capacity = 1;

            Result result = problem.Solve(capacity);

            Assert.AreEqual(0, result.selectedItems.Count);
        }

        [TestMethod]
        public void Test3()
        {
            Problem problem1 = new Problem(10, 1);
            Problem problem2 = new Problem(10, 1);
            int capacity = 10;

            problem2.items.Reverse();

            Result result1 = problem1.Solve(capacity);
            Result result2 = problem2.Solve(capacity);

            Assert.AreEqual(result1.selectedItems.Count, result2.selectedItems.Count);
            Assert.AreEqual(result1.total_value, result2.total_value);
            Assert.AreEqual(result1.total_weight, result2.total_weight);
        }


        [TestMethod]
        public void Test4()
        {

            Problem problem = new Problem(5, 1);
            problem.items.Clear();


            problem.items.Add(new Item(0, 2, 10));
            problem.items.Add(new Item(1, 3, 15));
            problem.items.Add(new Item(2, 5, 7));
            problem.items.Add(new Item(3, 7, 8));
            problem.items.Add(new Item(4, 1, 2));

            int capacity = 10;

            // expected result
            int expected_total_value = 27;
            int expected_total_weight = 6;
            int[] expected_selectedItems = { 0, 1, 4 };


            Result result = problem.Solve(capacity);

            Assert.AreEqual(expected_total_value, result.total_value);
            Assert.AreEqual(expected_total_weight, result.total_weight);
            CollectionAssert.AreEqual(expected_selectedItems, result.selectedItems);
        }

        [TestMethod]
        public void Test5() //reversed items
        {
            Problem problem1 = new Problem(5, 1);
            Problem problem2 = new Problem(5, 1);
            problem1.items.Clear();
            problem2.items.Clear();

            for (int i = 0; i < 10; i++)
            {
                problem1.items.Add(new Item(i, 2, 2));
                problem2.items.Add(new Item(i, 2, 2));
            }
            problem2.items.Reverse();

            int capacity = 6;

            Result result1 = problem1.Solve(capacity);
            Result result2 = problem2.Solve(capacity);

            Assert.AreNotSame(result1.selectedItems, result2.selectedItems);
            Assert.AreEqual(result1.total_value, result2.total_value);
            Assert.AreEqual(result1.total_weight, result2.total_weight);

        }

        [TestMethod]
        public void Test6() //equal ratio
        {
            Problem problem = new Problem(3, 1);
            problem.items.Clear();

            problem.items.Add(new Item(0, 20, 5));
            problem.items.Add(new Item(1, 40, 10));
            problem.items.Add(new Item(2, 24, 6));




            Result result = problem.Solve(50);
            int expectedTotalValue = 11;
            
            Assert.AreEqual(expectedTotalValue, result.total_value);
        }
        
        /*
        [TestMethod]
        public void Test7()
        {

        }




        [TestMethod]
        public void Test8()
        {

        }


        */



        


         
         

    }

}