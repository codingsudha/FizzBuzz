using FizzBuzzApi.Services;
using FakeItEasy;
using FizzBuzzApi.Model;

namespace FizzBuzzApiTest.Services
{
    public class ProcessFileServicesTest
    {

        [Fact]
        public void ProcessInput_ShouldReturn_Fizz_For_Multiple_Of_3()
        {
            // Arrange
            string[] inputValues = { "3", "18", "27" };

            // Act
            var testService = new FizzBuzzService();
            var actualOutput = testService.ProcessInput(inputValues);

            // Assert
            Assert.Equal(3, actualOutput.Count);

            List<OutputItem> expectedOutput = new List<OutputItem>()
                {
                    new OutputItem { Input = "3", Result = "Fizz" },
                    new OutputItem { Input = "18", Result = "Fizz" },
                    new OutputItem { Input = "27", Result = "Fizz" }
                };

            for (int i = 0; i < actualOutput.Count; i++)
            {
                Assert.Equal(expectedOutput[i].Input, actualOutput[i].Input);
                Assert.Equal(expectedOutput[i].Result, actualOutput[i].Result);
            }

        }

        public void ProcessInput_ShouldReturn_Buzz_For_Multiple_Of_5()
        {
            // Arrange
            string[] inputValues = { "5", "10", "20" };

            // Act
            var testService = new FizzBuzzService();
            var actualOutput = testService.ProcessInput(inputValues);

            // Assert
            Assert.Equal(3, actualOutput.Count);

            List<OutputItem> expectedOutput = new List<OutputItem>()
                {
                    new OutputItem { Input = "5", Result = "Buzz" },
                    new OutputItem { Input = "10", Result = "Buzz" },
                    new OutputItem { Input = "20", Result = "Buzz" },
                };

            for (int i = 0; i < actualOutput.Count; i++)
            {
                Assert.Equal(expectedOutput[i].Input, actualOutput[i].Input);
                Assert.Equal(expectedOutput[i].Result, actualOutput[i].Result);
            }

        }

        public void ProcessInput_ShouldReturn_FizzBuzz_For_Multiple_Of_15()
        {
            // Arrange
            string[] inputValues = { "15", "30" };

            // Act
            var testService = new FizzBuzzService();
            var actualOutput = testService.ProcessInput(inputValues);

            // Assert
            Assert.Equal(2, actualOutput.Count);

            List<OutputItem> expectedOutput = new List<OutputItem>()
                {
                    new OutputItem { Input = "15", Result = "FizzBuzz" },
                    new OutputItem { Input = "30", Result = "FizzBuzz" },
                };

            for (int i = 0; i < actualOutput.Count; i++)
            {
                Assert.Equal(expectedOutput[i].Input, actualOutput[i].Input);
                Assert.Equal(expectedOutput[i].Result, actualOutput[i].Result);
            }

        }

        public void ProcessInput_ShouldReturn_InvalidItem_For_Non_Numbers()
        {
            // Arrange
            string[] inputValues = { "1", "23","","A"};

            // Act
            var testService = new FizzBuzzService();
            var actualOutput = testService.ProcessInput(inputValues);

            // Assert
            Assert.Equal(4, actualOutput.Count);

            List<OutputItem> expectedOutput = new List<OutputItem>()
                {
                    new OutputItem { Input = "1", Result = "Invalid Item" },
                    new OutputItem { Input = "23", Result = "Invalid Item" },
                    new OutputItem { Input = "", Result = "Invalid Item" },
                    new OutputItem { Input = "A", Result = "Invalid Item" },
                };

            for (int i = 0; i < actualOutput.Count; i++)
            {
                Assert.Equal(expectedOutput[i].Input, actualOutput[i].Input);
                Assert.Equal(expectedOutput[i].Result, actualOutput[i].Result);
            }

        }

        public void ProcessInput_ShouldReturn_DividedBy_Message_For_Other_Numbers()
        {
            // Arrange
            string[] inputValues = { "1", "5" };

            // Act
            var testService = new FizzBuzzService();
            var actualOutput = testService.ProcessInput(inputValues);

            // Assert
            Assert.Equal(2, actualOutput.Count);

            List<OutputItem> expectedOutput = new List<OutputItem>()
                {
                    new OutputItem { Input = "1", Result = "Divided 1 by 3. \n Divided 1 by 5." },
                    new OutputItem { Input = "5", Result = "Divided 5 by 3. \n Divided 5 by 5." },
                };

            for (int i = 0; i < actualOutput.Count; i++)
            {
                Assert.Equal(expectedOutput[i].Input, actualOutput[i].Input);
                Assert.Equal(expectedOutput[i].Result, actualOutput[i].Result);
            }

        }
    }
}
