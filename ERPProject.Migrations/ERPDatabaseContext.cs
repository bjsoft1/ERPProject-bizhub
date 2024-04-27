using ERPProject.Model;
using Microsoft.EntityFrameworkCore;

namespace ERPProject.Migrations
{
    public class ERPDatabaseContext : DbContext
    {
        private readonly DateTime CREATION_TIME = new DateTime(ticks: 638498152360853682);
        private const string ANOTATION = "SqlServer:Identity";
        public ERPDatabaseContext(DbContextOptions<ERPDatabaseContext> options) : base(options)
        {

        }
        public DbSet<UserModel> Users { get; set; }
        public DbSet<ProductModel> Products { get; set; }
        public DbSet<OrderModel> Orders { get; set; }
        public DbSet<OrderDetailsModel> OrderDetails { get; set; }
        public DbSet<CustomerModel> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<UserModel>(e =>
            {
                e.ToTable(nameof(Users), "Person");
                e.HasKey(x => x.Id).HasAnnotation(ANOTATION, "0,1");
                e.Property(x => x.CreationTime).IsRequired(true);
                e.HasOne(F => F.CreatorUser).WithMany().HasForeignKey(F => F.CreatorUserId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);

                e.Property(x => x.LastModifiedTime).IsRequired(false);
                e.HasOne(F => F.LastModifiedUser).WithMany().HasForeignKey(F => F.LastModifiedUserId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);

                e.Property(x => x.FullName).IsRequired(true).HasMaxLength(60);
                e.Property(x => x.UserAddress).IsRequired(true).HasMaxLength(50);

                e.Property(x => x.UserEmail).IsRequired(true).HasMaxLength(100);
                e.HasIndex(i => i.UserEmail).IsUnique(true);

                e.Property(x => x.UserMobile).IsRequired(true).HasMaxLength(10);
                e.HasIndex(i => i.UserMobile).IsUnique(true);
            });

            modelBuilder.Entity<CustomerModel>(e =>
            {
                e.ToTable(nameof(Customers), "Person");
                e.HasKey(x => x.Id).HasAnnotation(ANOTATION, "0,1");
                e.Property(x => x.CreationTime).IsRequired(true);
                e.HasOne(F => F.CreatorUser).WithMany().HasForeignKey(F => F.CreatorUserId).IsRequired(true).OnDelete(DeleteBehavior.Restrict);

                e.Property(x => x.LastModifiedTime).IsRequired(false);
                e.HasOne(F => F.LastModifiedUser).WithMany().HasForeignKey(F => F.LastModifiedUserId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);

                e.Property(x => x.CustomerName).IsRequired(true).HasMaxLength(60);
                e.Property(x => x.CustomerAddress).IsRequired(true).HasMaxLength(50);

                e.Property(x => x.CustomerEmail).IsRequired(true).HasMaxLength(100);
                e.HasIndex(i => i.CustomerEmail).IsUnique(true);

                e.Property(x => x.CustomerMobile).IsRequired(true).HasMaxLength(10);
                e.HasIndex(i => i.CustomerMobile).IsUnique(true);
            });

            modelBuilder.Entity<ProductModel>(e =>
            {
                e.ToTable(nameof(Products), "Store");
                e.HasKey(x => x.Id).HasAnnotation(ANOTATION, "0,1");
                e.Property(x => x.CreationTime).IsRequired(true);
                e.HasOne(F => F.CreatorUser).WithMany().HasForeignKey(F => F.CreatorUserId).IsRequired(true).OnDelete(DeleteBehavior.Restrict);

                e.Property(x => x.LastModifiedTime).IsRequired(false);
                e.HasOne(F => F.LastModifiedUser).WithMany().HasForeignKey(F => F.LastModifiedUserId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);

                e.Property(x => x.ProductName).IsRequired(true).HasMaxLength(100);
                e.HasIndex(i => i.ProductName).IsUnique(true);

                e.Property(x => x.ProductDescription).IsRequired(false).HasMaxLength(1000);

                e.Property(x => x.ProductSellingPrice).IsRequired(true);
                e.Property(x => x.ProductPurchasePrice).IsRequired(true);
            });


            modelBuilder.Entity<OrderModel>(e =>
            {
                e.ToTable(nameof(Orders), "Order");
                e.HasKey(x => x.Id).HasAnnotation(ANOTATION, "0,1");
                e.Property(x => x.CreationTime).IsRequired(true);
                e.HasOne(F => F.CreatorUser).WithMany().HasForeignKey(F => F.CreatorUserId).IsRequired(true).OnDelete(DeleteBehavior.Restrict);

                e.Property(x => x.LastModifiedTime).IsRequired(false);
                e.HasOne(F => F.LastModifiedUser).WithMany().HasForeignKey(F => F.LastModifiedUserId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);

                e.Property(x => x.TotalAmount).IsRequired(true);
                e.Property(x => x.OrderStatus).IsRequired(true).HasDefaultValue(ESaleOrderStatus.Pending);

                e.HasOne(F => F.Customer).WithMany().HasForeignKey(F => F.CustomerId).IsRequired(true).OnDelete(DeleteBehavior.Restrict);
            });

            modelBuilder.Entity<OrderDetailsModel>(e =>
            {
                e.ToTable(nameof(OrderDetails), "Order");
                e.HasKey(x => x.Id).HasAnnotation(ANOTATION, "0,1");
                e.Property(x => x.CreationTime).IsRequired(true);
                e.HasOne(F => F.CreatorUser).WithMany().HasForeignKey(F => F.CreatorUserId).IsRequired(true).OnDelete(DeleteBehavior.Restrict);

                e.Property(x => x.LastModifiedTime).IsRequired(false);
                e.HasOne(F => F.LastModifiedUser).WithMany().HasForeignKey(F => F.LastModifiedUserId).IsRequired(false).OnDelete(DeleteBehavior.Restrict);

                e.Property(x => x.Amount).IsRequired(true);
                e.Property(x => x.Quantity).IsRequired(true);

                e.HasOne(F => F.Order).WithMany().HasForeignKey(F => F.OrderId).IsRequired(true).OnDelete(DeleteBehavior.Restrict);
                e.HasOne(F => F.Product).WithMany().HasForeignKey(F => F.ProductId).IsRequired(true).OnDelete(DeleteBehavior.Restrict);
            });

            this.DataSeeding(modelBuilder);
        }

        private void DataSeeding(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserModel>().HasData(Private_GetUsers());
        }

        private List<UserModel> Private_GetUsers()
        {
            return new List<UserModel>()
            {
                new UserModel
                {
                    Id = 1, 
                    UserAddress = "Thaiba, Lalitpur", 
                    UserEmail = "bijay.adhikari.27648@gmail.com",
                    FullName = "Bijay Adhikari",
                    CreationTime = CREATION_TIME,
                    UserMobile = "9800000000",
                }
            };
            ;
        }
    }
}
