using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140108.Models
{
    public partial class Gender
    {
        public Gender()
        {
            Customer = new HashSet<Customer>();
        }

        public int IdGender { get; set; }
        [MinLength(0, ErrorMessage = "Gender minimal 1 huruf")]
        [MaxLength(1, ErrorMessage = "Gender maksimal 1 huruf")]
        public string NamaGender { get; set; }

        public ICollection<Customer> Customer { get; set; }
    }
}
