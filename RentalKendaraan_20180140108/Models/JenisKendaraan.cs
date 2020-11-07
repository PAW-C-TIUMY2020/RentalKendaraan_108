using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140108.Models
{
    public partial class JenisKendaraan
    {
        public int IdJenisKendaraan { get; set; }
        [MinLength(0, ErrorMessage = "Jenis Kendaraan minimal 0 huruf")]
        [MaxLength(30, ErrorMessage = "Jenis Kendaraan maksimal 30 huruf")]
        public string NamaJenisKendaraan { get; set; }

        public Kendaraan Kendaraan { get; set; }
    }
}
