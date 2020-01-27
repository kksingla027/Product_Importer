using Gartner.Product_Importer.DAL.Contracts;
using Gartner.Product_Importer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gartner.Product_Importer.DAL
{
    /// <summary>
    /// MongoProductDataProvider implementation class.
    /// </summary>
    public class MongoProductDataProvider : IProductDataProvider
    {
        public void BulkInsert(List<Product> products)
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            return new Product() { id = 1, title = "Product from Mongo DB" };
        }

        public void Insert(Product product)
        {
            throw new NotImplementedException();
        }

        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
