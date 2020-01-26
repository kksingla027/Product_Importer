namespace Gartner.Product_Importer.Entities
{
    /// <summary>
    /// Product Entity Class
    /// </summary>
    public class Product
    {
        /// <summary>
        /// Gets or sets id
        /// </summary>
        public int id { get; set; }

        /// <summary>
        /// Gets or sets twitter
        /// </summary>
        public string twitter { get; set; }

        /// <summary>
        /// Gets or sets title
        /// </summary>
        public string title { get; set; }

        /// <summary>
        /// Gets or sets categories
        /// </summary>
        public string[] categories { get; set; }
    }
}
