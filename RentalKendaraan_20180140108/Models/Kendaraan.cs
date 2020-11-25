using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RentalKendaraan_20180140108.Models
{
    public partial class Kendaraan
    {
        public Kendaraan()
        {
            Peminjaman = new HashSet<Peminjaman>();
        }

        public int IdKendaraan { get; set; }
        [MinLength(0, ErrorMessage = "Nama Kendaraan minimal 0 huruf")]
        [MaxLength(25, ErrorMessage = "Nama Kendaraan maksimal 25 huruf")]
        public string NamaKendaraan { get; set; }
        [MinLength(0, ErrorMessage = "No Polisi minimal 0 angka dan huruf")]
        [MaxLength(15, ErrorMessage = "No Polisi maksimal 15 angka dan huruf")]
        public string NoPolisi { get; set; }
        [RegularExpression("^[0-8]*$", ErrorMessage = "Hanya boleh diisi oleh angka")]
        public string NoStnk { get; set; }
        public int? IdJenisKendaraan { get; set; }
        [MinLength(0, ErrorMessage = "Ketersediaan minimal 1 angka")]
        [MaxLength(15, ErrorMessage = "Ketersediaan maksimal 15 angka")]
        public string Ketersediaan { get; set; }

        public JenisKendaraan IdKendaraanNavigation { get; set; }
        public ICollection<Peminjaman> Peminjaman { get; set; }
        public object IdJenisKendaraanNavigation { get; internal set; }
    }
}
