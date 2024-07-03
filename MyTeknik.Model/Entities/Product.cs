using MyTeknik.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeknik.Model.Entities
{
    public class Product : CoreEntity
    {
        [Required(ErrorMessage ="Ürün Adını Giriniz")]
        public string ProductName { get; set; }

        [Required(ErrorMessage = "Ürün Kodunu Girriniz")]
        [Display(Name ="Ürün Kodu")]
        public string Code { get; set; }

        public string ProductDetailDescription { get; set; }

        [Required(ErrorMessage = "Ürün Fiyatını Giriniz")]
        public double Price { get; set; }

        //[Required(ErrorMessage = "Ürün Fotoğrafını Yükleyiniz")]
        public string ProductImage { get; set; }

        public DateTime Date { get; set; }

        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }

        public virtual Brand Brand { get; set; }    

        
    }
}
