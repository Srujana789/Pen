using System.ComponentModel.DataAnnotations;
namespace Orion_Pens.Models
{
    public class Products
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? InkType { get; set; }
        [DataType(DataType.Date)]
        public DateTime Year { get; set; }
        public string? Color { get; set; }
        public string? Material { get; set; }
        public string? Retractable { get; set; }
        public decimal Price { get; set; }
    }
}
