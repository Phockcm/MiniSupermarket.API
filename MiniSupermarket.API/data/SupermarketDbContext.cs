using Microsoft.EntityFrameworkCore;
<<<<<<< HEAD
=======

>>>>>>> 274e3b180fd1c63428ba4b6b4eef694de56f4076
using MiniSupermarket.API.Models;

namespace MiniSupermarket.API.Data
{
<<<<<<< HEAD
=======
    // DbContext đại diện cho phiên làm việc với cơ sở dữ liệu SQL Server
>>>>>>> 274e3b180fd1c63428ba4b6b4eef694de56f4076
    public class SupermarketDbContext : DbContext
    {
        public SupermarketDbContext(DbContextOptions<SupermarketDbContext> options) : base(options) { }

<<<<<<< HEAD
        // Khai báo danh sách các DbSet
        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Supplier> Suppliers { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<RefreshToken> RefreshTokens { get; set; }

=======
        // Khai báo các bảng dữ liệu ánh xạ từ Model
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        // Cấu hình dữ liệu mồi ban đầu (Data Seeding)
>>>>>>> 274e3b180fd1c63428ba4b6b4eef694de56f4076
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

<<<<<<< HEAD
            // ==========================================
            // 1. SEED DATA FOR ROLES (3 Vai trò hệ thống POS)
            // ==========================================
            modelBuilder.Entity<Role>().HasData(
                new Role { RoleId = 1, RoleName = "Admin", Description = "Quản trị viên (Toàn quyền quản lý kho, nhập hàng, nhân sự và báo cáo doanh thu POS)" },
                new Role { RoleId = 2, RoleName = "Thu Ngân", Description = "Nhân viên bán hàng / POS (Quét mã vạch, lập hóa đơn, tích điểm khách hàng)" },
                new Role { RoleId = 3, RoleName = "Khách Hàng", Description = "Tài khoản khách hàng (Tra cứu điểm thưởng, hạng thành viên, lịch sử mua hàng)" }
            );

            // ==========================================
            // 2. SEED DATA FOR USERS (Tài khoản người dùng)
            // ==========================================
            modelBuilder.Entity<User>().HasData(
                new User { UserId = 1, Username = "admin", PasswordHash = "admin123", FullName = "Quản Lý Nutri Mart", RoleId = 1 },
                new User { UserId = 2, Username = "thungan01", PasswordHash = "123456", FullName = "Thu Ngân Ca Sáng (Nguyễn Thu Hà)", RoleId = 2 },
                new User { UserId = 3, Username = "thungan02", PasswordHash = "123456", FullName = "Thu Ngân Ca Chiều (Lê Hoàng Nam)", RoleId = 2 },
                new User { UserId = 4, Username = "khachhang01", PasswordHash = "123456", FullName = "Nguyễn Hoàng Nam", RoleId = 3 },
                new User { UserId = 5, Username = "khachhang02", PasswordHash = "123456", FullName = "Phạm Thị Mai", RoleId = 3 }
            );

            // ==========================================
            // 3. SEED DATA FOR SUPPLIERS (Nhà cung cấp thực phẩm)
            // ==========================================
            modelBuilder.Entity<Supplier>().HasData(
                new Supplier { SupplierId = 1, SupplierName = "Nông Trại Xanh Dalat Organic Farm", ContactName = "Nguyễn Văn An", PhoneNumber = "0901234567", Address = "Phường 11, TP. Đà Lạt, Lâm Đồng" },
                new Supplier { SupplierId = 2, SupplierName = "Công ty TNHH Thực Phẩm Sạch NutriLife", ContactName = "Trần Thị Bích", PhoneNumber = "0912345678", Address = "KCN Tân Bình, Tân Phú, TP.HCM" },
                new Supplier { SupplierId = 3, SupplierName = "Hợp Tác Xã Gia Vị & Nông Sản Việt", ContactName = "Lê Văn Cường", PhoneNumber = "0923456789", Address = "Huyện Củ Chi, TP.HCM" }
            );

            // ==========================================
            // 4. SEED DATA FOR BRANDS (Thương hiệu Thực Phẩm Xanh)
            // ==========================================
            modelBuilder.Entity<Brand>().HasData(
                new Brand { BrandId = 1, BrandName = "Nutri Mart Clean", Description = "Thương hiệu độc quyền chuẩn Eat Clean Nutri Mart" },
                new Brand { BrandId = 2, BrandName = "Dalat Eco Organic", Description = "Rau củ quả tươi sạch đạt chứng nhận VietGAP/GlobalGAP" },
                new Brand { BrandId = 3, BrandName = "VietOrganic Natural", Description = "Gia vị và dầu ăn thực vật hữu cơ tự nhiên" }
            );

            // ==========================================
            // 5. SEED DATA FOR CATEGORIES (15 Danh mục thực phẩm xanh)
            // ==========================================
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Rau củ quả hữu cơ", Description = "Rau xanh, củ quả tươi đạt chuẩn Organic, VietGAP" },
                new Category { CategoryId = 2, CategoryName = "Ngũ cốc & Hạt dinh dưỡng", Description = "Yến mạch, hạt chia, hạnh nhân, óc chó, mác ca" },
                new Category { CategoryId = 3, CategoryName = "Sữa hạt & Sữa chua hữu cơ", Description = "Sữa hạnh nhân, sữa đậu nành, sữa chua Hy Lạp" },
                new Category { CategoryId = 4, CategoryName = "Thực phẩm Eat Clean", Description = "Ức gà, cơm gạo lứt, salad đóng gói ăn liền" },
                new Category { CategoryId = 5, CategoryName = "Gia vị & Dầu thực vật tự nhiên", Description = "Dầu oliu, mật ong nguyên chất, muối hồng Himalaya" },
                new Category { CategoryId = 6, CategoryName = "Trái cây tươi xuất nhập khẩu", Description = "Táo Envy, dâu tây Đà Lạt, việt quất, cam vàng" },
                new Category { CategoryId = 7, CategoryName = "Trà & Thức uống thực dưỡng", Description = "Trà dưỡng nhan, kombucha, trà xanh matcha, nước ép tươi" },
                new Category { CategoryId = 8, CategoryName = "Đồ khô & Bánh ăn kiêng", Description = "Bánh biscotti, thanh hạt năng lượng, bún chùm ngây, mì gạo lứt" },
                new Category { CategoryId = 9, CategoryName = "Thịt & Hải sản tươi sạch", Description = "Thịt heo ăn chay, cá hồi măng tây, tôm sinh thái" },
                new Category { CategoryId = 10, CategoryName = "Thực phẩm đông lạnh hữu cơ", Description = "Rau củ hỗn hợp đông lạnh, chả chay organic, dumpling thực dưỡng" },
                new Category { CategoryId = 11, CategoryName = "Bánh kẹo & Snack Healthy", Description = "Snack chuối sấy lạnh, kẹo dẻo vitamin, rong biển sấy giòn" },
                new Category { CategoryId = 12, CategoryName = "Thực phẩm bổ sung & Detox", Description = "Bột cần tây sấy lạnh, bột chlorella, collagen thực vật" },
                new Category { CategoryId = 13, CategoryName = "Nước ép & Smoothie đóng chai", Description = "Nước ép cần tây củ dền, smoothie bơ chuối, nước dừa tươi" },
                new Category { CategoryId = 14, CategoryName = "Gạo & Các loại đậu hữu cơ", Description = "Gạo lứt đỏ, gạo st25 organic, đậu đen xanh lòng, đậu chickpea" },
                new Category { CategoryId = 15, CategoryName = "Sản phẩm thuần chay (Vegan)", Description = "Pate thuần chay, giò nấm, nước mắm chay cốt đậu nành" }
            );

            // ==========================================
            // 6. SEED DATA FOR PRODUCTS (15 Sản phẩm kho + Barcode quét máy POS)
            // ==========================================
            modelBuilder.Entity<Product>().HasData(
                // Category 1: Rau củ quả hữu cơ
                new Product { ProductId = 1, Barcode = "8938501234561", ProductName = "Rau cải bó xôi hữu cơ 300g", Price = 25000, StockQuantity = 30, CategoryId = 1, BrandId = 2, SupplierId = 1 },
                new Product { ProductId = 2, Barcode = "8938501234562", ProductName = "Cà chua bí đỏ hữu cơ 500g", Price = 32000, StockQuantity = 40, CategoryId = 1, BrandId = 2, SupplierId = 1 },
                new Product { ProductId = 3, Barcode = "8938501234563", ProductName = "Bông cải xanh Đà Lạt Organic 500g", Price = 45000, StockQuantity = 25, CategoryId = 1, BrandId = 2, SupplierId = 1 },

                // Category 2: Ngũ cốc & Hạt dinh dưỡng
                new Product { ProductId = 4, Barcode = "8938501234564", ProductName = "Yến mạch nguyên hạt Quaker 500g", Price = 65000, StockQuantity = 30, CategoryId = 2, BrandId = 1, SupplierId = 2 },
                new Product { ProductId = 5, Barcode = "8938501234565", ProductName = "Hạt hạnh nhân rang Mỹ 250g", Price = 95000, StockQuantity = 25, CategoryId = 2, BrandId = 1, SupplierId = 2 },
                new Product { ProductId = 6, Barcode = "8938501234566", ProductName = "Hạt chia hữu cơ Úc 200g", Price = 75000, StockQuantity = 35, CategoryId = 2, BrandId = 1, SupplierId = 2 },

                // Category 3: Sữa hạt & Sữa chua hữu cơ
                new Product { ProductId = 7, Barcode = "8938501234567", ProductName = "Sữa hạnh nhân Nutri 1L", Price = 78000, StockQuantity = 15, CategoryId = 3, BrandId = 1, SupplierId = 2 },
                new Product { ProductId = 8, Barcode = "8938501234568", ProductName = "Sữa chua Hy Lạp không đường 500g", Price = 55000, StockQuantity = 20, CategoryId = 3, BrandId = 1, SupplierId = 2 },
                new Product { ProductId = 9, Barcode = "8938501234569", ProductName = "Sữa đậu nành hữu cơ 1L", Price = 42000, StockQuantity = 30, CategoryId = 3, BrandId = 1, SupplierId = 2 },

                // Category 4: Thực phẩm Eat Clean
                new Product { ProductId = 10, Barcode = "8938501234570", ProductName = "Ức gà tươi đông lạnh 1kg", Price = 89000, StockQuantity = 50, CategoryId = 4, BrandId = 1, SupplierId = 2 },
                new Product { ProductId = 11, Barcode = "8938501234571", ProductName = "Cơm gạo lứt đóng hộp ăn liền 250g", Price = 42000, StockQuantity = 45, CategoryId = 4, BrandId = 1, SupplierId = 2 },
                new Product { ProductId = 12, Barcode = "8938501234572", ProductName = "Salad ức gà xốt chanh dây đóng gói 200g", Price = 48000, StockQuantity = 18, CategoryId = 4, BrandId = 1, SupplierId = 2 },

                // Category 5: Gia vị & Dầu thực vật tự nhiên
                new Product { ProductId = 13, Barcode = "8938501234573", ProductName = "Dầu oliu nguyên chất Extra Virgin 500ml", Price = 145000, StockQuantity = 20, CategoryId = 5, BrandId = 3, SupplierId = 3 },
                new Product { ProductId = 14, Barcode = "8938501234574", ProductName = "Mật ong hoa rừng nguyên chất 350ml", Price = 120000, StockQuantity = 18, CategoryId = 5, BrandId = 3, SupplierId = 3 },
                new Product { ProductId = 15, Barcode = "8938501234575", ProductName = "Muối hồng Himalaya nguyên chất 500g", Price = 38000, StockQuantity = 40, CategoryId = 5, BrandId = 3, SupplierId = 3 }
            );

            // ==========================================
            // 7. SEED DATA FOR CUSTOMERS (15 Thành viên tích điểm POS)
            // ==========================================
            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, FullName = "Nguyễn Hoàng Nam", PhoneNumber = "0987654321", Email = "nam.nguyen@gmail.com", Address = "123 Lê Lợi, Q.1, TP.HCM", RewardPoints = 150, MembershipRank = "Bạc", CreatedAt = new DateTime(2026, 1, 15) },
                new Customer { CustomerId = 2, FullName = "Phạm Thị Mai", PhoneNumber = "0978123456", Email = "mai.pham@gmail.com", Address = "456 Nguyễn Thị Minh Khai, Q.3, TP.HCM", RewardPoints = 520, MembershipRank = "Vàng", CreatedAt = new DateTime(2026, 2, 10) },
                new Customer { CustomerId = 3, FullName = "Trần Văn Minh", PhoneNumber = "0912345678", Email = "minh.tran@gmail.com", Address = "789 Điện Biên Phủ, Q.Bình Thạnh, TP.HCM", RewardPoints = 1200, MembershipRank = "Kim Cương", CreatedAt = new DateTime(2026, 2, 18) },
                new Customer { CustomerId = 4, FullName = "Lê Thị Thanh", PhoneNumber = "0903112233", Email = "thanh.le@gmail.com", Address = "12 Trần Hưng Đạo, Q.5, TP.HCM", RewardPoints = 45, MembershipRank = "Đồng", CreatedAt = new DateTime(2026, 3, 01) },
                new Customer { CustomerId = 5, FullName = "Hoàng Anh Tuấn", PhoneNumber = "0934556677", Email = "tuan.hoang@gmail.com", Address = "88 Nguyễn Trãi, Q.5, TP.HCM", RewardPoints = 230, MembershipRank = "Bạc", CreatedAt = new DateTime(2026, 3, 05) },
                new Customer { CustomerId = 6, FullName = "Đặng Thu Thảo", PhoneNumber = "0967889900", Email = "thao.dang@gmail.com", Address = "15 Nguyễn Đình Chiểu, Q.3, TP.HCM", RewardPoints = 680, MembershipRank = "Vàng", CreatedAt = new DateTime(2026, 3, 12) },
                new Customer { CustomerId = 7, FullName = "Vũ Quốc Bảo", PhoneNumber = "0981122334", Email = "bao.vu@gmail.com", Address = "102 Cách Mạng Tháng 8, Q.10, TP.HCM", RewardPoints = 80, MembershipRank = "Đồng", CreatedAt = new DateTime(2026, 3, 20) },
                new Customer { CustomerId = 8, FullName = "Bùi Thị Ngọc", PhoneNumber = "0945667788", Email = "ngoc.bui@gmail.com", Address = "234 Phan Xích Long, Q.Phú Nhuận, TP.HCM", RewardPoints = 310, MembershipRank = "Bạc", CreatedAt = new DateTime(2026, 4, 02) },
                new Customer { CustomerId = 9, FullName = "Đỗ Duy Khoa", PhoneNumber = "0922334455", Email = "khoa.do@gmail.com", Address = "56 Võ Văn Tần, Q.3, TP.HCM", RewardPoints = 15, MembershipRank = "Đồng", CreatedAt = new DateTime(2026, 4, 15) },
                new Customer { CustomerId = 10, FullName = "Ngô Bích Phương", PhoneNumber = "0918776655", Email = "phuong.ngo@gmail.com", Address = "77 Hoàng Văn Thụ, Q.Phú Nhuận, TP.HCM", RewardPoints = 950, MembershipRank = "Vàng", CreatedAt = new DateTime(2026, 5, 01) },
                new Customer { CustomerId = 11, FullName = "Dương Khánh Linh", PhoneNumber = "0938990011", Email = "linh.duong@gmail.com", Address = "301 Lý Thường Kiệt, Q.11, TP.HCM", RewardPoints = 110, MembershipRank = "Bạc", CreatedAt = new DateTime(2026, 5, 10) },
                new Customer { CustomerId = 12, FullName = "Lý Minh Triết", PhoneNumber = "0971223344", Email = "triet.ly@gmail.com", Address = "45 Lê Văn Sỹ, Q.3, TP.HCM", RewardPoints = 1500, MembershipRank = "Kim Cương", CreatedAt = new DateTime(2026, 5, 22) },
                new Customer { CustomerId = 13, FullName = "Phan Hoài Thương", PhoneNumber = "0908771122", Email = "thuong.phan@gmail.com", Address = "89 Nam Kỳ Khởi Nghĩa, Q.1, TP.HCM", RewardPoints = 60, MembershipRank = "Đồng", CreatedAt = new DateTime(2026, 6, 05) },
                new Customer { CustomerId = 14, FullName = "Trịnh Xuân Trường", PhoneNumber = "0961445566", Email = "truong.trinh@gmail.com", Address = "142 Phạm Văn Đồng, Q.Thủ Đức, TP.HCM", RewardPoints = 420, MembershipRank = "Bạc", CreatedAt = new DateTime(2026, 6, 18) },
                new Customer { CustomerId = 15, FullName = "Võ Tuyết Nhi", PhoneNumber = "0949887766", Email = "nhi.vo@gmail.com", Address = "67 Cộng Hòa, Q.Tân Bình, TP.HCM", RewardPoints = 880, MembershipRank = "Vàng", CreatedAt = new DateTime(2026, 7, 01) }
            );

            // ==========================================
            // 8. SEED DATA FOR ORDERS (Đơn hàng thanh toán tại máy POS)
            // ==========================================
            modelBuilder.Entity<Order>().HasData(
                new Order { OrderId = 1, OrderDate = new DateTime(2026, 3, 1, 10, 30, 0), TotalAmount = 143000, Status = "Completed", CustomerId = 1, UserId = 2 },
                new Order { OrderId = 2, OrderDate = new DateTime(2026, 3, 2, 14, 15, 0), TotalAmount = 120000, Status = "Completed", CustomerId = 2, UserId = 2 }
            );

            // ==========================================
            // 9. SEED DATA FOR ORDERITEMS (Chi tiết hóa đơn POS)
            // ==========================================
            modelBuilder.Entity<OrderItem>().HasData(
                new OrderItem { OrderItemId = 1, OrderId = 1, ProductId = 3, Quantity = 1, UnitPrice = 65000 },
                new OrderItem { OrderItemId = 2, OrderId = 1, ProductId = 5, Quantity = 1, UnitPrice = 78000 },
                new OrderItem { OrderItemId = 3, OrderId = 2, ProductId = 10, Quantity = 1, UnitPrice = 120000 }
            );
        }
    }
}
=======
      


            // Nạp sẵn danh mục theo chủ đề Healthy Mart - Cửa hàng thực phẩm sạch & hữu cơ
            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryId = 1, CategoryName = "Rau củ quả hữu cơ", Description = "Rau xanh, củ quả tươi đạt chuẩn organic" },
                new Category { CategoryId = 2, CategoryName = "Ngũ cốc & Hạt dinh dưỡng", Description = "Yến mạch, hạt chia, hạnh nhân, óc chó" },
                new Category { CategoryId = 3, CategoryName = "Sữa hạt & Sữa chua hữu cơ", Description = "Sữa hạnh nhân, sữa đậu nành, sữa chua Hy Lạp" },
                new Category { CategoryId = 4, CategoryName = "Thực phẩm Eat Clean", Description = "Ức gà, cơm gạo lứt, salad đóng gói ăn kiêng" },
                new Category { CategoryId = 5, CategoryName = "Gia vị & Dầu thực vật tự nhiên", Description = "Dầu oliu, mật ong nguyên chất, muối hồng Himalaya" }
            );

            // Nạp sẵn sản phẩm mẫu
            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Barcode = "8938501234561", ProductName = "Rau cải bó xôi hữu cơ 300g", Price = 25000, StockQuantity = 50, CategoryId = 1 },
                new Product { ProductId = 2, Barcode = "8938501234562", ProductName = "Cà chua bi hữu cơ 500g", Price = 32000, StockQuantity = 40, CategoryId = 1 },
                new Product { ProductId = 3, Barcode = "8938501234563", ProductName = "Yến mạch nguyên hạt Quaker 500g", Price = 65000, StockQuantity = 30, CategoryId = 2 },
                new Product { ProductId = 4, Barcode = "8938501234564", ProductName = "Hạt hạnh nhân rang Mỹ 250g", Price = 95000, StockQuantity = 25, CategoryId = 2 },
                new Product { ProductId = 5, Barcode = "8938501234565", ProductName = "Sữa hạnh nhân Alsafi 946ml", Price = 78000, StockQuantity = 35, CategoryId = 3 },
                new Product { ProductId = 6, Barcode = "8938501234566", ProductName = "Sữa chua Hy Lạp không đường 500g", Price = 55000, StockQuantity = 20, CategoryId = 3 },
                new Product { ProductId = 7, Barcode = "8938501234567", ProductName = "Ức gà tươi đông lạnh 1kg", Price = 89000, StockQuantity = 60, CategoryId = 4 },
                new Product { ProductId = 8, Barcode = "8938501234568", ProductName = "Cơm gạo lứt đóng hộp ăn liền 250g", Price = 42000, StockQuantity = 45, CategoryId = 4 },
                new Product { ProductId = 9, Barcode = "8938501234569", ProductName = "Dầu oliu nguyên chất Extra Virgin 500ml", Price = 145000, StockQuantity = 20, CategoryId = 5 },
                new Product { ProductId = 10, Barcode = "8938501234570", ProductName = "Mật ong nguyên chất U Minh 500ml", Price = 120000, StockQuantity = 15, CategoryId = 5 }
            );

            // Nạp sẵn khách hàng mẫu
            modelBuilder.Entity<Customer>().HasData(
            new Customer { CustomerId = 1, CustomerName = "Nguyễn Văn A", PhoneNumber = "0901122334", Address = null, MembershipRank = "Vàng", RewardPoints = 150 },
            new Customer { CustomerId = 2, CustomerName = "Trần Thị B", PhoneNumber = "0918877665", Address = null, MembershipRank = "Bạc", RewardPoints = 50 },
            new Customer { CustomerId = 3, CustomerName = "Lê Văn C", PhoneNumber = "0983344556", Address = null, MembershipRank = "Chuẩn", RewardPoints = 10 }
);
        }
    }
}
>>>>>>> 274e3b180fd1c63428ba4b6b4eef694de56f4076
