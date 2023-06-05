using Microsoft.Extensions.DependencyInjection;
namespace UIL
{
    public class Program
    {
        static void Main(string[] args)
        {
            IServiceCollection serviceDescriptors = new ServiceCollection();
            serviceDescriptors.AddServices();
            IServiceProvider serviceProvider = serviceDescriptors.BuildServiceProvider();
            serviceProvider.GetService<IRunner>().Run();
        }
    }
}