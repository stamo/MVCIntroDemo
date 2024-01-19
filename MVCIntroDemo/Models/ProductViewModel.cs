namespace MVCIntroDemo.Models
{
    /// <summary>
    /// Product model
    /// </summary>
    public class ProductViewModel
    {
        /// <summary>
        /// Product Identifier
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Product Name
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Product Price with VAT
        /// </summary>
        public int Price { get; set; }
    }
}
