using Gartner.Product_Importer.Business.Contracts;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gartner.Product_Importer.Business.Bootstrap
{
    public static class BusinessInitializer
    {
        public static void Initialize(IServiceCollection services)
        {
            services.AddTransient<IProductService, ProductService>();
        }
    }
}
