
using AutoMapper;
using Gartner.Product_Importer.Business;
using Gartner.Product_Importer.Business.Contracts;
using Gartner.Product_Importer.Common.DTO;
using Gartner.Product_Importer.DAL.Contracts;
using Gartner.Product_Importer.Entities;
using Moq;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class ProductServiceTest
    {
        private Mock<IProductDataProvider> moqProductDataProvider;
        private Mock<IMapper> moqMapper;
        private IProductService productService;

        [SetUp]
        public void Setup()
        {
            this.moqProductDataProvider = new Mock<IProductDataProvider>();
            this.moqMapper = new Mock<IMapper>();
            productService = new ProductService(moqProductDataProvider.Object, moqMapper.Object);
        }

        [Test]
        public void GetById_Success()
        {
            // Arrange
            var id = 10;
            moqProductDataProvider.Setup(x => x.GetById(It.IsAny<int>())).Returns(new Product() { id = id });
            moqMapper.Setup(x => x.Map<Product, ProductDTO>(It.IsAny<Product>())).Returns(new ProductDTO() { id = id });

            // Act
            var data = productService.GetById(id);

            //Assert
            Assert.AreEqual(data.id, id);
        }

        [Test]
        public void GetById_InvalidId_Throw()
        {
            var id = 0;
            Assert.Throws<Exception>(() => { productService.GetById(id); });
        }
    }
}