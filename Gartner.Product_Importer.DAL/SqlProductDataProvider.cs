namespace Gartner.Product_Importer.DAL
{
    using Gartner.Product_Importer.DAL.Contracts;
    using Gartner.Product_Importer.Entities;
    using System;
    using System.Collections.Generic;

    /// <summary>
    /// SqlProductDataProvider Implementation class
    /// </summary>
    public class SqlProductDataProvider : IProductDataProvider
    {
        public void BulkInsert(List<Product> products)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets product data by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetById(int id)
        {
            return new Product() { id = 1, title = "Product from Sql DB" };
        }

        // <summary>
        /// Insert a new product.
        /// </summary>
        /// <param name="product"></param>
        public void Insert(Product product)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Update an existing product.
        /// </summary>
        /// <param name="product"></param>
        public void Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
