using System;
using System.ComponentModel.DataAnnotations;

namespace Rental.Data.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? BirthDate { get; set; }

        [MaxLength(2)]
        public string CountryCode { get; set; }
        public bool IsMale { get; set; }
    }
}
