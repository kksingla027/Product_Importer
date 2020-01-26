namespace Gartner.Product_Importer.DAL.Bootstrap
{
    using Gartner.Product_Importer.DAL.Contracts;
    using Microsoft.Extensions.DependencyInjection;

    public static class DALInitializer
    {
        public static void Initialize(IServiceCollection services)
        {
            services.AddTransient<IProductDataProvider, ProductDataProvider>();
        }
    }
}
