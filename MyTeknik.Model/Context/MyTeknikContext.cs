using Microsoft.EntityFrameworkCore;
using MyTeknik.Model.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyTeknik.Model.Context
{
    public class MyTeknikContext : DbContext
    {
        public MyTeknikContext(DbContextOptions<MyTeknikContext> options) : base(options)
        {

        }

        public DbSet<About> Abouts { get; set; }

        public DbSet<Admin> Admins { get; set; }

        public DbSet<Banner> Banners { get; set; }

        public DbSet<BannerPlus> BannerPlusies{ get; set; }

        public DbSet<Bestseller> Bestsellers { get; set; }

        public DbSet<Brand> Brands { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<NewArrivals> NewArrivalies { get; set; }

        public DbSet<Product> Products { get; set; }

        public DbSet<ProductDetail> ProductDetails { get; set; }

        public DbSet<ProductImage> ProductImages { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Vision> Visions { get; set; }

    }
}
