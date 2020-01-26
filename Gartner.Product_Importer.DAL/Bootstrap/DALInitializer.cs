using Gartner.Product_Importer.DAL.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gartner.Product_Importer.DAL.Bootstrap
{
    public static class DALInitializer
    {
        public static void Initialize(IServiceCollection services)
        {
            services.AddTransient<IProductDataProvider, ProductDataProvider>();
        }
    }
}
