using FizzBuzzApi.Model;

namespace FizzBuzzApi.Services
{
    public class FizzBuzzService : IFizzBuzzService
    {
        public List<OutputItem> ProcessInput(string[] inputValue)
        {
            OutputItem outputItem;
            List<OutputItem> outputItems = new();
            foreach (var item in inputValue)
            {
                string result = "";
                int number;
                var isNumber = int.TryParse(item, out number);
                if (isNumber)
                {
                    if (number % 3 == 0)
                    {
                        result = "Fizz";
                    }
                    if (number % 5 == 0)
                    {
                        result += "Buzz";
                    }
                    if (number % 3 != 0 && number % 5 != 0)
                    {
                        result = $"Divided {item} by 3. {"\n"} Divided {item} by 5.";
                    }
                }
                else
                {
                    result = "Invalid Item";
                }

                outputItem = new OutputItem
                {
                    Input = item,
                    Result = result
                };

                outputItems.Add(outputItem);

            }
            return outputItems;
        }
    }
}
