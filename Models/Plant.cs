using System.ComponentModel.DataAnnotations;

namespace Assignment2.Models
{
    public class Plant
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name is required.")]
        public required string Name { get; set; }

        [Required(ErrorMessage = "The Description is required.")]
        public required string Description { get; set; }

        [Required(ErrorMessage = "The Species is required.")]
        public required string Species { get; set; }

        [Required(ErrorMessage = "The Price is required.")]
        [Range(0, double.MaxValue, ErrorMessage = "Please enter a valid price.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "The Stock Quantity is required.")]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a valid stock quantity.")]
        public int StockQuantity { get; set; }
    }
}
