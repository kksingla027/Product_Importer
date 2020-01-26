namespace Gartner.Product_Importer.Business
{
    using AutoMapper;
    using Gartner.Product_Importer.Business.Contracts;
    using Gartner.Product_Importer.Common.DTO;
    using Gartner.Product_Importer.DAL.Contracts;
    using Gartner.Product_Importer.Entities;
    using System;

    /// <summary>
    /// ProductService Implementation class
    /// </summary>
    public class ProductService : IProductService
    {
        private readonly IProductDataProvider _productDataProvider;
        private readonly IMapper _mapper;

        public ProductService(IProductDataProvider productDataProvider, IMapper mapper)
        {
            _productDataProvider = productDataProvider;
            _mapper = mapper;
        }

        /// <summary>
        /// Gets Product data by id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ProductDTO GetById(int id)
        {
           
            var product = _productDataProvider.GetById(id);
            return _mapper.Map<Product, ProductDTO>(product);
        }

        /// <summary>
        /// Insert a new Product.
        /// </summary>
        /// <param name="productDto"></param>
        public void Insert(ProductDTO productDto)
        {
            var product = _mapper.Map<ProductDTO, Product>(productDto);
            _productDataProvider.Insert(product);
        }

        /// <summary>
        /// Update an existing Product.
        /// </summary>
        /// <param name="productDto"></param>
        public void Update(ProductDTO productDto)
        {
            var product = _mapper.Map<ProductDTO, Product>(productDto);
            _productDataProvider.Update(product);
        }
    }
}
