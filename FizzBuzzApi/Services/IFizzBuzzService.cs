using FizzBuzzApi.Model;

namespace FizzBuzzApi.Services
{
    public interface IFizzBuzzService
    {
        public List<OutputItem> ProcessInput(string[] inputValue);
    }
}
