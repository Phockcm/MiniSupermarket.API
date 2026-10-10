using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniSupermarket.API.Migrations
{
    /// <inheritdoc />
    public partial class sa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Brands",
                columns: table => new
                {
                    BrandId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrandName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Brands", x => x.BrandId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    RewardPoints = table.Column<int>(type: "int", nullable: false),
                    MembershipRank = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupplierName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Email = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_Users_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Barcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CostPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderCode = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Subtotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Discount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Status = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    CashierId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Users_CashierId",
                        column: x => x.CashierId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    RefreshTokenId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Revoked = table.Column<bool>(type: "bit", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.RefreshTokenId);
                    table.ForeignKey(
                        name: "FK_RefreshTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LineTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderItemId);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "BrandName", "Country", "Description", "IsActive" },
                values: new object[,]
                {
                    { 1, "Nutri Mart Clean", "Việt Nam", "Thương hiệu độc quyền chuẩn Eat Clean Nutri Mart.", true },
                    { 2, "Quaker", "Mỹ", "Thương hiệu yến mạch và ngũ cốc dinh dưỡng.", true },
                    { 3, "TH true MILK", "Việt Nam", "Thương hiệu sữa tươi và các sản phẩm từ sữa.", true },
                    { 4, "Blue Diamond", "Mỹ", "Thương hiệu hạnh nhân và các sản phẩm từ hạt.", true },
                    { 5, "Alsafi", "Campuchia", "Thương hiệu sữa hạt dinh dưỡng có nguồn gốc thực vật.", true },
                    { 6, "Bertolli", "Ý", "Thương hiệu dầu oliu và gia vị cao cấp.", true },
                    { 7, "Dalat Eco Organic", "Việt Nam", "Nông sản, rau củ quả tươi sạch đạt chuẩn VietGAP Đà Lạt.", true },
                    { 8, "Eat Clean VN", "Việt Nam", "Sản phẩm đóng gói chuyên chế độ ăn Eat Clean.", true },
                    { 9, "Dalat Green", "Việt Nam", "Trà thảo mộc và thức uống dinh dưỡng.", true },
                    { 10, "Bee Gold", "Việt Nam", "Mật ong rừng nguyên chất và chế phẩm từ mật ong.", true },
                    { 11, "Nutri Seed", "Việt Nam", "Superfood, hạt dinh dưỡng và bột sấy lạnh.", true },
                    { 12, "Green Life Vegan", "Việt Nam", "Thực phẩm thuần chay và các chế phẩm thực vật.", true },
                    { 13, "VietOrganic Natural", "Việt Nam", "Gia vị, gạo lứt và nông sản hữu cơ tự nhiên.", true },
                    { 14, "Fresh Choice Seafood", "Việt Nam", "Cá hồi Na Uy và hải sản tươi sạch nhập khẩu.", true },
                    { 15, "Nutri Snack Healthy", "Việt Nam", "Bánh ăn kiêng và snack lành mạnh Nutri Mart.", true }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Đặc sản miền Bắc", "Đặc sản Hà Nội, Hải Phòng, Quảng Ninh, Tây Bắc và các tỉnh phía Bắc." },
                    { 2, "Đặc sản miền Trung", "Đặc sản Huế, Đà Nẵng, Quảng Nam, Bình Định và các tỉnh miền Trung." },
                    { 3, "Đặc sản miền Nam", "Đặc sản miền Tây Nam Bộ, TP. Hồ Chí Minh và Đông Nam Bộ." },
                    { 4, "Bánh kẹo truyền thống", "Bánh đậu xanh, bánh pía, kẹo dừa, bánh cốm và các loại bánh kẹo truyền thống." },
                    { 5, "Đồ ăn vặt đóng gói", "Snack, bánh tráng, rong biển, đậu phộng và các món ăn vặt đóng gói." },
                    { 6, "Khô bò, khô gà và thịt khô", "Khô bò, khô gà lá chanh, thịt trâu gác bếp và các loại thịt khô." },
                    { 7, "Hải sản khô", "Mực khô, cá khô, tôm khô và các loại hải sản chế biến, bảo quản khô." },
                    { 8, "Trái cây sấy", "Xoài sấy, mít sấy, chuối sấy, khoai lang sấy và trái cây sấy dẻo." },
                    { 9, "Hạt và đậu ăn vặt", "Hạt điều, đậu phộng, hạt bí, hạt hướng dương và các loại hạt rang." },
                    { 10, "Mứt và ô mai", "Ô mai Hà Nội, mứt gừng, mứt dừa, mứt trái cây và đặc sản ngày Tết." },
                    { 11, "Nước chấm và gia vị vùng miền", "Nước mắm, mắm đặc sản, muối chấm, sa tế và các loại gia vị địa phương." },
                    { 12, "Trà, cà phê và đồ uống", "Trà Thái Nguyên, cà phê Tây Nguyên, nước trái cây và đồ uống đặc sản." },
                    { 13, "Mì, bún và thực phẩm khô", "Mì Quảng khô, bún khô, miến dong, bánh đa và các loại thực phẩm khô." },
                    { 14, "Quà biếu đặc sản", "Hộp quà đặc sản vùng miền, giỏ quà bánh kẹo và sản phẩm cao cấp." },
                    { 15, "Đặc sản đông lạnh", "Chả ram, nem chua, chả mực và các đặc sản cần bảo quản đông lạnh." }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "CustomerName", "MembershipRank", "PhoneNumber", "RewardPoints" },
                values: new object[,]
                {
                    { 1, "59 Nguyễn Thị Minh Khai, Phường Võ Thị Sáu, Quận 3, TP. Hồ Chí Minh", "Nguyễn Văn A", "Vàng", "0901122334", 150 },
                    { 2, "120 Võ Văn Tần, Phường Võ Thị Sáu, Quận 3, TP. Hồ Chí Minh", "Trần Thị B", "Bạc", "0918877665", 50 },
                    { 3, "15 Lý Thường Kiệt, Phường 14, Quận 10, TP. Hồ Chí Minh", "Lê Văn C", "Chuẩn", "0983344556", 10 },
                    { 4, "12 Nguyễn Huệ, Phường Bến Nghé, Quận 1, TP. Hồ Chí Minh", "Phạm Minh Tuấn", "Vàng", "0905123456", 180 },
                    { 5, "45 Lê Lợi, Phường Bến Thành, Quận 1, TP. Hồ Chí Minh", "Hoàng Thị Lan", "Bạc", "0912345678", 75 },
                    { 6, "8 Trần Hưng Đạo, Phường 6, Quận 5, TP. Hồ Chí Minh", "Võ Quốc Bảo", "Chuẩn", "0937654321", 20 },
                    { 7, "102 Điện Biên Phủ, Phường 17, Quận Bình Thạnh, TP. Hồ Chí Minh", "Đặng Thu Hà", "Kim cương", "0944556677", 520 },
                    { 8, "36 Nguyễn Thị Thập, Phường Tân Quy, Quận 7, TP. Hồ Chí Minh", "Bùi Anh Khoa", "Chuẩn", "0966778899", 5 },
                    { 9, "27 Phan Văn Trị, Phường 10, Quận Gò Vấp, TP. Hồ Chí Minh", "Ngô Thanh Mai", "Bạc", "0977889900", 90 },
                    { 10, "63 Cách Mạng Tháng 8, Phường 12, Quận 10, TP. Hồ Chí Minh", "Đỗ Hoài Nam", "Vàng", "0988990011", 210 },
                    { 11, "210 Quang Trung, Phường 10, Quận Gò Vấp, TP. Hồ Chí Minh", "Lý Gia Hân", "Chuẩn", "0399123456", 0 },
                    { 12, "5 Võ Văn Ngân, Phường Linh Chiểu, TP. Thủ Đức, TP. Hồ Chí Minh", "Trương Quốc Việt", "Bạc", "0868234567", 60 },
                    { 13, "88 Nguyễn Oanh, Phường 17, Quận Gò Vấp, TP. Hồ Chí Minh", "Nguyễn Minh Khôi", "Vàng", "0908765432", 230 },
                    { 14, "156 Hoàng Diệu, Phường 6, Quận 4, TP. Hồ Chí Minh", "Phan Ngọc Anh", "Bạc", "0938123456", 85 },
                    { 15, "72 Kha Vạn Cân, Phường Hiệp Bình Chánh, TP. Thủ Đức, TP. Hồ Chí Minh", "Đinh Thanh Tùng", "Chuẩn", "0976234518", 15 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "RoleName" },
                values: new object[,]
                {
                    { 1, "ADMIN" },
                    { 2, "WAREHOUSE" },
                    { 3, "CASHIER" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierId", "Address", "Email", "PhoneNumber", "SupplierName" },
                values: new object[,]
                {
                    { 1, "TP. Sơn La, tỉnh Sơn La", "lienhe.dacsantaybac@gmail.com", "02123812345", "Công ty Đặc sản Tây Bắc Việt" },
                    { 2, "TP. Hải Dương, tỉnh Hải Dương", "banhang.banhdauxanh@gmail.com", "02203812345", "Cơ sở Bánh đậu xanh Hải Dương" },
                    { 3, "Quận Hoàn Kiếm, Hà Nội", "kinhdoanh.omaihanoi@gmail.com", "02433812345", "Cơ sở Ô mai Hà Nội" },
                    { 4, "TP. Huế, thành phố Huế", "sales.dacsanhue@gmail.com", "02343812345", "Công ty Đặc sản Huế" },
                    { 5, "TP. Hội An, thành phố Đà Nẵng", "lienhe.dacsanquangnam@gmail.com", "02353812345", "Công ty Đặc sản Quảng Nam" },
                    { 6, "TP. Tây Ninh, tỉnh Tây Ninh", "banhang.banhtrangtn@gmail.com", "02763812345", "Cơ sở Bánh tráng Tây Ninh" },
                    { 7, "TP. Quy Nhơn, tỉnh Gia Lai", "sales.haisanmientrung@gmail.com", "02563812345", "Công ty Hải sản khô miền Trung" },
                    { 8, "TP. Rạch Giá, tỉnh An Giang", "lienhe.khocamientay@gmail.com", "02973812345", "Cơ sở Khô cá miền Tây" },
                    { 9, "TP. Bến Cát, TP. Hồ Chí Minh", "sales.traicaysay@gmail.com", "02743812345", "Công ty Trái cây sấy Việt" },
                    { 10, "Đồng Xoài, tỉnh Đồng Nai", "order.hatdieubp@gmail.com", "02713812345", "Cơ sở Hạt điều Bình Phước" },
                    { 11, "Đà Lạt, tỉnh Lâm Đồng", "sales.dacsandalat@gmail.com", "02633812345", "Công ty Đặc sản Đà Lạt" },
                    { 12, "TP. Buôn Ma Thuột, tỉnh Đắk Lắk", "kinhdoanh.caphetaynguyen@gmail.com", "02623812345", "Công ty Cà phê Tây Nguyên" },
                    { 13, "TP. Thái Nguyên, tỉnh Thái Nguyên", "lienhe.trathainguyen@gmail.com", "02083812345", "Hợp tác xã Trà Thái Nguyên" },
                    { 14, "TP. Cần Thơ", "sales.dacsanmientay@gmail.com", "02923812345", "Công ty Đặc sản miền Tây" },
                    { 15, "TP. Hồ Chí Minh", "phanphoi.dacsanviet@gmail.com", "02833812345", "Công ty Phân phối Đặc sản Việt" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Barcode", "BrandId", "CategoryId", "CostPrice", "IsActive", "Price", "ProductName", "StockQuantity", "SupplierId", "Unit" },
                values: new object[,]
                {
                    { 1, "8938501234561", 3, 4, 32000m, true, 45000m, "Bánh đậu xanh Hải Dương 200g", 80, 2, "hộp" },
                    { 2, "8938501234562", 15, 5, 18000m, true, 28000m, "Bánh tráng muối Tây Ninh 250g", 120, 6, "gói" },
                    { 3, "8938501234563", 1, 6, 85000m, true, 115000m, "Khô bò miếng đặc biệt 200g", 35, 1, "gói" },
                    { 4, "8938501234564", 1, 7, 145000m, true, 185000m, "Mực khô loại ngon 250g", 25, 7, "gói" },
                    { 5, "8938501234565", 8, 8, 45000m, true, 65000m, "Xoài sấy dẻo 250g", 60, 9, "gói" },
                    { 6, "8938501234566", 4, 9, 70000m, true, 95000m, "Hạt điều rang muối 300g", 50, 10, "hộp" },
                    { 7, "8938501234567", 14, 4, 28000m, true, 42000m, "Kẹo dừa Bến Tre 300g", 90, 14, "gói" },
                    { 8, "8938501234568", 7, 10, 37000m, true, 55000m, "Ô mai mơ Hà Nội 200g", 45, 3, "hộp" },
                    { 9, "8938501234569", 6, 11, 15000m, true, 25000m, "Muối tôm Tây Ninh 100g", 100, 6, "hũ" },
                    { 10, "8938501234570", 11, 12, 90000m, true, 125000m, "Cà phê rang xay Tây Nguyên 500g", 40, 12, "gói" },
                    { 11, "8938501234571", 12, 12, 60000m, true, 85000m, "Trà Thái Nguyên đặc sản 200g", 55, 13, "gói" },
                    { 12, "8938501234572", 14, 4, 55000m, true, 78000m, "Bánh pía sầu riêng 4 bánh", 40, 14, "hộp" },
                    { 13, "8938501234573", 13, 13, 35000m, true, 52000m, "Bánh phồng tôm 500g", 65, 14, "gói" },
                    { 14, "8938501234574", 9, 8, 25000m, true, 38000m, "Chuối sấy giòn 200g", 75, 11, "gói" },
                    { 15, "8938501234575", 10, 6, 47000m, true, 68000m, "Khô gà lá chanh 250g", 50, 15, "hũ" },
                    { 16, "8938501234576", 4, 9, 20000m, true, 32000m, "Đậu phộng rang tỏi ớt 200g", 85, 15, "gói" },
                    { 17, "8938501234577", 1, 14, 270000m, true, 350000m, "Hộp quà đặc sản ba miền", 15, 15, "hộp" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedAt", "Email", "FullName", "IsActive", "PasswordHash", "Phone", "RoleId", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2026, 1, 5, 8, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", "Quản trị hệ thống", true, "$2b$11$Kce6ZlNDqAZeWGjWjezVDuvhT5YGuqyxFMjEc6g8Zx1VbYe0Rq7B.", "0900000001", 1, "admin" },
                    { 2, new DateTime(2026, 1, 6, 8, 0, 0, 0, DateTimeKind.Unspecified), "warehouse01@gmail.com", "Nguyễn Thị Mai", true, "$2b$11$Kce6ZlNDqAZeWGjWjezVDuvhT5YGuqyxFMjEc6g8Zx1VbYe0Rq7B.", "0900000002", 2, "warehouse01" },
                    { 3, new DateTime(2026, 1, 6, 8, 30, 0, 0, DateTimeKind.Unspecified), "warehouse02@gmail.com", "Trần Văn Điều", true, "$2b$11$Kce6ZlNDqAZeWGjWjezVDuvhT5YGuqyxFMjEc6g8Zx1VbYe0Rq7B.", "0900000003", 2, "warehouse02" },
                    { 4, new DateTime(2026, 2, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "cashier01@gmail.com", "Lê Thị Thu Ngân", true, "$2b$11$Kce6ZlNDqAZeWGjWjezVDuvhT5YGuqyxFMjEc6g8Zx1VbYe0Rq7B.", "0900000004", 3, "cashier01" },
                    { 5, new DateTime(2026, 2, 1, 8, 10, 0, 0, DateTimeKind.Unspecified), "cashier02@gmail.com", "Phạm Văn Ngân", true, "$2b$11$Kce6ZlNDqAZeWGjWjezVDuvhT5YGuqyxFMjEc6g8Zx1VbYe0Rq7B.", "0900000005", 3, "cashier02" },
                    { 6, new DateTime(2026, 2, 1, 8, 20, 0, 0, DateTimeKind.Unspecified), "cashier03@gmail.com", "Hoàng Thị Ngân", true, "$2b$11$Kce6ZlNDqAZeWGjWjezVDuvhT5YGuqyxFMjEc6g8Zx1VbYe0Rq7B.", "0900000006", 3, "cashier03" },
                    { 7, new DateTime(2026, 2, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), "cashier04@gmail.com", "Võ Minh Ngân", true, "$2b$11$Kce6ZlNDqAZeWGjWjezVDuvhT5YGuqyxFMjEc6g8Zx1VbYe0Rq7B.", "0900000007", 3, "cashier04" },
                    { 8, new DateTime(2026, 2, 10, 8, 10, 0, 0, DateTimeKind.Unspecified), "cashier05@gmail.com", "Đặng ThịNgân", true, "$2b$11$Kce6ZlNDqAZeWGjWjezVDuvhT5YGuqyxFMjEc6g8Zx1VbYe0Rq7B.", "0900000008", 3, "cashier05" },
                    { 9, new DateTime(2026, 3, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "cashier06@gmail.com", "Bùi Văn Ngân", true, "$2b$11$Kce6ZlNDqAZeWGjWjezVDuvhT5YGuqyxFMjEc6g8Zx1VbYe0Rq7B.", "0900000009", 3, "cashier06" },
                    { 10, new DateTime(2026, 3, 1, 8, 10, 0, 0, DateTimeKind.Unspecified), "cashier07@gmail.com", "Ngô Thị Thu Ngân", true, "$2b$11$Kce6ZlNDqAZeWGjWjezVDuvhT5YGuqyxFMjEc6g8Zx1VbYe0Rq7B.", "0900000010", 3, "cashier07" },
                    { 11, new DateTime(2026, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), "cashier08@gmail.com", "Đỗ Văn Ngân", true, "$2b$11$Kce6ZlNDqAZeWGjWjezVDuvhT5YGuqyxFMjEc6g8Zx1VbYe0Rq7B.", "0900000011", 3, "cashier08" },
                    { 12, new DateTime(2026, 4, 1, 8, 10, 0, 0, DateTimeKind.Unspecified), "cashier09@gmail.com", "Lý Thị Thu Ngân", false, "$2b$11$Kce6ZlNDqAZeWGjWjezVDuvhT5YGuqyxFMjEc6g8Zx1VbYe0Rq7B.", "0900000012", 3, "cashier09" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CashierId", "CreatedAt", "CustomerId", "Discount", "OrderCode", "PaymentMethod", "Status", "Subtotal", "Total" },
                values: new object[,]
                {
                    { 1, 4, new DateTime(2026, 9, 1, 9, 15, 0, 0, DateTimeKind.Unspecified), 1, 0m, "HD0001", "CASH", "PAID", 82000m, 82000m },
                    { 2, 4, new DateTime(2026, 9, 2, 10, 30, 0, 0, DateTimeKind.Unspecified), 2, 10000m, "HD0002", "MOMO", "PAID", 221000m, 211000m },
                    { 3, 5, new DateTime(2026, 9, 3, 11, 0, 0, 0, DateTimeKind.Unspecified), 6, 0m, "HD0003", "CASH", "PAID", 173000m, 173000m },
                    { 4, 5, new DateTime(2026, 9, 4, 14, 20, 0, 0, DateTimeKind.Unspecified), 7, 20000m, "HD0004", "CARD", "PAID", 400000m, 380000m },
                    { 5, 6, new DateTime(2026, 9, 5, 16, 45, 0, 0, DateTimeKind.Unspecified), 4, 23000m, "HD0005", "BANK_TRANSFER", "PAID", 467000m, 444000m },
                    { 6, 6, new DateTime(2026, 9, 6, 8, 40, 0, 0, DateTimeKind.Unspecified), 8, 0m, "HD0006", "CASH", "PAID", 158000m, 158000m },
                    { 7, 7, new DateTime(2026, 9, 7, 9, 5, 0, 0, DateTimeKind.Unspecified), 3, 0m, "HD0007", "CASH", "PAID", 126000m, 126000m },
                    { 8, 7, new DateTime(2026, 9, 8, 17, 10, 0, 0, DateTimeKind.Unspecified), 10, 12000m, "HD0008", "MOMO", "PAID", 237000m, 225000m },
                    { 9, 8, new DateTime(2026, 9, 9, 18, 30, 0, 0, DateTimeKind.Unspecified), 5, 0m, "HD0009", "CARD", "PAID", 151000m, 151000m },
                    { 10, 8, new DateTime(2026, 9, 10, 12, 0, 0, 0, DateTimeKind.Unspecified), 11, 0m, "HD0010", "CASH", "CANCELLED", 129000m, 129000m },
                    { 11, 9, new DateTime(2026, 9, 11, 15, 25, 0, 0, DateTimeKind.Unspecified), 9, 12000m, "HD0011", "BANK_TRANSFER", "PAID", 262000m, 250000m },
                    { 12, 9, new DateTime(2026, 9, 12, 19, 0, 0, 0, DateTimeKind.Unspecified), 12, 0m, "HD0012", "MOMO", "PAID", 258000m, 258000m }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderItemId", "LineTotal", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 50000m, 1, 1, 2, 25000m },
                    { 2, 32000m, 1, 2, 1, 32000m },
                    { 3, 65000m, 2, 3, 1, 65000m },
                    { 4, 156000m, 2, 5, 2, 78000m },
                    { 5, 89000m, 3, 7, 1, 89000m },
                    { 6, 84000m, 3, 8, 2, 42000m },
                    { 7, 145000m, 4, 9, 1, 145000m },
                    { 8, 120000m, 4, 10, 1, 120000m },
                    { 9, 135000m, 4, 17, 1, 135000m },
                    { 10, 338000m, 5, 12, 2, 169000m },
                    { 11, 129000m, 5, 11, 1, 129000m },
                    { 12, 104000m, 6, 13, 2, 52000m },
                    { 13, 54000m, 6, 16, 3, 18000m },
                    { 14, 48000m, 7, 14, 1, 48000m },
                    { 15, 78000m, 7, 15, 2, 39000m },
                    { 16, 95000m, 8, 4, 1, 95000m },
                    { 17, 110000m, 8, 6, 2, 55000m },
                    { 18, 32000m, 8, 2, 1, 32000m },
                    { 19, 126000m, 9, 8, 3, 42000m },
                    { 20, 25000m, 9, 1, 1, 25000m },
                    { 21, 129000m, 10, 11, 1, 129000m },
                    { 22, 130000m, 11, 3, 2, 65000m },
                    { 23, 96000m, 11, 14, 2, 48000m },
                    { 24, 36000m, 11, 16, 2, 18000m },
                    { 25, 89000m, 12, 7, 1, 89000m },
                    { 26, 169000m, 12, 12, 1, 169000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Brands_BrandName",
                table: "Brands",
                column: "BrandName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Categories_CategoryName",
                table: "Categories",
                column: "CategoryName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Customers_PhoneNumber",
                table: "Customers",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CashierId",
                table: "Orders",
                column: "CashierId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_OrderCode",
                table: "Orders",
                column: "OrderCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_Barcode",
                table: "Products",
                column: "Barcode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Products_BrandId",
                table: "Products",
                column: "BrandId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_RefreshTokens_UserId",
                table: "RefreshTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Email",
                table: "Users",
                column: "Email",
                unique: true,
                filter: "[Email] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_Username",
                table: "Users",
                column: "Username",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "RefreshTokens");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Brands");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
