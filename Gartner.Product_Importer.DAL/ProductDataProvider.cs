namespace Gartner.Product_Importer.DAL
{
    using Gartner.Product_Importer.DAL.Contracts;
    using Gartner.Product_Importer.Entities;
    using System;

    /// <summary>
    /// ProductDataProvider Implementation class
    /// </summary>
    public class ProductDataProvider : IProductDataProvider
    {
        /// <summary>
        /// Gets product data by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public Product GetById(int id)
        {
            throw new NotImplementedException();
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
