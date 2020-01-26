using System;
using System.Collections.Generic;
using System.Text;

namespace Gartner.Product_Importer.Common.DTO
{
    public class ProductDTO
    {
        public int id { get; set; }

        public string twitter { get; set; }

        public string title { get; set; }

        public string[] categories { get; set; }
    }
}
