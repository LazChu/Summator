namespace Summator.Tests
{
    public class Summator_test
    {

        [Test]
        public void Test_Sum_Two_positive_numbers()
        {
            int result = Summator.Sum(new int[] { 5, 7 });

            Assert.That(result == 12);

        }

        [Test]

        public void Test_Sum_one_positive_number()
        {
            int result = Summator.Sum(new int[] { 5 });

            Assert.That(result == 5);
        }
        [Test]

        public void Test_sum_two_negative_numbers()
        {
            int result = Summator.Sum(new int[] { -5, -10 });

            Assert.That(result == -15);

        }
        [Test]
        public void Test_Sum_empty()
        {
            int result = Summator.Sum(new int[] { });

            Assert.That(result == 0);
        }   
            [Test]
            public void Test_average_number()
            {
                float result = Summator.Average(new int[] {5,6 });

                Assert.That(result == 5.5);

            }
        }
    }

    
