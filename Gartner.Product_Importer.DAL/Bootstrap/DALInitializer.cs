namespace Gartner.Product_Importer.DAL.Bootstrap
{
    using Gartner.Product_Importer.DAL.Contracts;
    using Microsoft.Extensions.DependencyInjection;

    public static class DALInitializer
    {
        public static void Initialize(IServiceCollection services, string dbProviderType)
        {
            switch (dbProviderType)
            {
                case "1":
                    {
                        SQLProviderInitialize(services);
                        break;
                    }
                default:
                    {
                        MongoProviderInitialize(services);
                        break;
                    }
            }
            
        }

        private static void SQLProviderInitialize(IServiceCollection services)
        {
            services.AddTransient<IProductDataProvider, SqlProductDataProvider>();
        }

        private static void MongoProviderInitialize(IServiceCollection services)
        {
            services.AddTransient<IProductDataProvider, MongoProductDataProvider>();
        }
    }
}
