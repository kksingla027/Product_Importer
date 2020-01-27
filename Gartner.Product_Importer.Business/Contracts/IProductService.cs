using Gartner.Product_Importer.Common.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace Gartner.Product_Importer.Business.Contracts
{
    /// <summary>
    /// IProductService Contract
    /// </summary>
    public interface IProductService
    {
        /// <summary>
        /// Insert a new Product.
        /// </summary>
        /// <param name="productDto"></param>
        void Insert(ProductDTO productDto);

        /// <summary>
        /// Bulk Insert new products.
        /// </summary>
        /// <param name="products"></param>
        void BulkInsert(List<ProductDTO> products);

        /// <summary>
        /// Update an existing Product.
        /// </summary>
        /// <param name="productDto"></param>
        void Update(ProductDTO productDto);

        /// <summary>
        /// Gets Product data by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        ProductDTO GetById(int id);
    }
}
