namespace Gartner.Product_Importer.Business.Bootstrap
{
    using Gartner.Product_Importer.Business.Contracts;
    using Microsoft.Extensions.DependencyInjection;

    public static class BusinessInitializer
    {
        public static void Initialize(IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
        }
    }
}
