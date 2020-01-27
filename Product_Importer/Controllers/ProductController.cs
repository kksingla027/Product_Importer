using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Gartner.Product_Importer.Business.Contracts;
using Gartner.Product_Importer.Common.DTO;
using Gartner.Product_Importer.Common.FileUtility;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Gartner.Product_Importer.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        private readonly IProductService _productService;
        private readonly IFileProvider _fileProvider;

        public ProductController(IProductService productService, IFileProvider fileProvider)
        {
            _productService = productService;
            _fileProvider = fileProvider;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "Api started..";
        }

        [HttpGet("{id}")]
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

        [HttpGet("Import")]
        public IActionResult Import(string filePath)
        {
            
            var jsonData = this._fileProvider.ReadFileContent(filePath);
            var products = Newtonsoft.Json.JsonConvert.DeserializeObject<ProductDTO[]>(jsonData);
            if (products != null && products.Length > 0)
            {
                this._productService.BulkInsert(products.ToList());
            }
            return Ok();
        }
    }
}