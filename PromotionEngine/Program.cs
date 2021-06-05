using Microsoft.Extensions.DependencyInjection;
using System;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
           .AddScoped<IPromotionManager, PromotionManager>()
           .AddScoped<IProductManager, ProductManager>()
           .AddScoped<ICheckOut, Checkout>()

           .BuildServiceProvider();
            Console.WriteLine("Hello World!");
        }
    }
}
