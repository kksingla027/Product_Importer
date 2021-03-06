﻿namespace Gartner.Product_Importer.DAL.Contracts
{
    using Gartner.Product_Importer.Entities;
    using System.Collections.Generic;

    /// <summary>
    /// IProductDataProvider contract
    /// </summary>
    public interface IProductDataProvider
    {
        /// <summary>
        /// Insert a new product.
        /// </summary>
        /// <param name="product"></param>
        void Insert(Product product);

        /// <summary>
        /// Bulk Insert new products.
        /// </summary>
        /// <param name="products"></param>
        void BulkInsert(List<Product> products);

        /// <summary>
        /// Update an existing product.
        /// </summary>
        /// <param name="product"></param>
        void Update(Product product);

        /// <summary>
        /// Gets product data by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Product GetById(int id);
    }
}
