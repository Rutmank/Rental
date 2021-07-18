using System.ComponentModel.DataAnnotations;

namespace Rental.Data.Models
{
    public class Vehicle
    {
        public int Id { get; set; }
        [Required]
        public string Brand { get; set; }
        [Required]
        public string Model { get; set; }
        public int HorsePower { get; set; }
        public Client Client { get; set; }
    }
}
