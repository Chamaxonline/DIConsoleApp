using Microsoft.Extensions.DependencyInjection;
using System;

namespace DIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var serviceCollection = new ServiceCollection();

            //serviceCollection.AddScoped<GuidGenerator>();

            // serviceCollection.AddSingleton<GuidGenerator>();

             serviceCollection.AddTransient<GuidGenerator>();

            var provider = serviceCollection.BuildServiceProvider();
            var obj1 = provider.GetService<GuidGenerator>();
            var obj2 = provider.GetService<GuidGenerator>();

            var obj3 = provider.GetService<GuidGenerator>();
            var obj4 = provider.GetService<GuidGenerator>();

            var obj5 = provider.GetService<GuidGenerator>();
            var obj6 = provider.GetService<GuidGenerator>();

            Console.WriteLine($"Randon 1 -{obj1.Generate}");
            Console.WriteLine($"Random2 -{obj2.Generate}");



        }
    }
}
