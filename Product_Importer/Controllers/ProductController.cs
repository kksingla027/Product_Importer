using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gartner.Product_Importer.Business.Contracts;
using Gartner.Product_Importer.Common.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gartner.Product_Importer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public ProductDTO Get(int id)
        {
            return _productService.GetById(id);
        }

        [HttpPost]
        public void Post([FromBody]ProductDTO product)
        {
            _productService.Insert(product);
        }

        [HttpPut]
        public void Put(ProductDTO product)
        {
            _productService.Update(product);
        }
    }
}