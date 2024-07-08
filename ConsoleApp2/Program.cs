using SimpleTrader.Domain.Models;
using SimpleTrader.Domain.Services;
using SimpleTrader.EntityFramework.Services;
using SimpleTrader.EntityFramework;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IDataService<User> userService = new GenericDataService<User>(new SimpleTraderDbContextFactory());
            
            Console.WriteLine(userService.Delete(1).Result);
            
            Console.ReadLine();
        }
    }
}
