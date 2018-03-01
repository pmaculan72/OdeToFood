using Microsoft.Extensions.Configuration;

namespace OdeToFood.Services
{
    public interface IGreeter
    {
        string GetMessageOfTheDay();
    }

    public class Gretter : IGreeter
    {
        private IConfiguration _configuration;

        public Gretter(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string GetMessageOfTheDay()
        {
            return _configuration["Greeting"];
        }
    }
}