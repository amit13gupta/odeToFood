namespace OdeToFood
{
    public interface IGreeting
    {
        string GreetingOfTheDay();
    }

    public class Greeting : IGreeting
    {
        public string GreetingOfTheDay()
        {
            return "greeting of the day";
        }
    }
}