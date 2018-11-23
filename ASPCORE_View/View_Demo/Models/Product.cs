using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace View_Demo.Models
{
    public class Product
    {
        [Display(Name="Mã Hàng Hóa")]
        public int MaHH { get; set; }
        [Display(Name = "Tên Hàng Hóa")]
        public string TenHH { get; set; }
        [Display(Name = "Đơn giá")]
        public double DonGia { get; set; }

    }
}
