using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MiniSupermarket.API.Migrations
{
    /// <inheritdoc />
    public partial class _001 : Migration
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
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
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
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Address = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    RewardPoints = table.Column<int>(type: "int", nullable: true),
                    MembershipRank = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
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
                    RoleName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
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
                    ContactName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(15)", maxLength: 15, nullable: true),
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
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StockQuantity = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    BrandId = table.Column<int>(type: "int", nullable: true),
                    SupplierId = table.Column<int>(type: "int", nullable: true),
                    Barcode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Brands_BrandId",
                        column: x => x.BrandId,
                        principalTable: "Brands",
                        principalColumn: "BrandId");
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId");
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId");
                    table.ForeignKey(
                        name: "FK_Orders_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RefreshTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Expires = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RefreshTokens", x => x.Id);
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
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
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
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Brands",
                columns: new[] { "BrandId", "BrandName", "Description" },
                values: new object[,]
                {
                    { 1, "Nutri Mart Clean", "Thương hiệu độc quyền chuẩn Eat Clean Nutri Mart" },
                    { 2, "Dalat Eco Organic", "Rau củ quả tươi sạch đạt chứng nhận VietGAP/GlobalGAP" },
                    { 3, "VietOrganic Natural", "Gia vị và dầu ăn thực vật hữu cơ tự nhiên" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Rau củ quả hữu cơ", "Rau xanh, củ quả tươi đạt chuẩn Organic, VietGAP" },
                    { 2, "Ngũ cốc & Hạt dinh dưỡng", "Yến mạch, hạt chia, hạnh nhân, óc chó, mác ca" },
                    { 3, "Sữa hạt & Sữa chua hữu cơ", "Sữa hạnh nhân, sữa đậu nành, sữa chua Hy Lạp" },
                    { 4, "Thực phẩm Eat Clean", "Ức gà, cơm gạo lứt, salad đóng gói ăn liền" },
                    { 5, "Gia vị & Dầu thực vật tự nhiên", "Dầu oliu, mật ong nguyên chất, muối hồng Himalaya" },
                    { 6, "Trái cây tươi xuất nhập khẩu", "Táo Envy, dâu tây Đà Lạt, việt quất, cam vàng" },
                    { 7, "Trà & Thức uống thực dưỡng", "Trà dưỡng nhan, kombucha, trà xanh matcha, nước ép tươi" },
                    { 8, "Đồ khô & Bánh ăn kiêng", "Bánh biscotti, thanh hạt năng lượng, bún chùm ngây, mì gạo lứt" },
                    { 9, "Thịt & Hải sản tươi sạch", "Thịt heo ăn chay, cá hồi măng tây, tôm sinh thái" },
                    { 10, "Thực phẩm đông lạnh hữu cơ", "Rau củ hỗn hợp đông lạnh, chả chay organic, dumpling thực dưỡng" },
                    { 11, "Bánh kẹo & Snack Healthy", "Snack chuối sấy lạnh, kẹo dẻo vitamin, rong biển sấy giòn" },
                    { 12, "Thực phẩm bổ sung & Detox", "Bột cần tây sấy lạnh, bột chlorella, collagen thực vật" },
                    { 13, "Nước ép & Smoothie đóng chai", "Nước ép cần tây củ dền, smoothie bơ chuối, nước dừa tươi" },
                    { 14, "Gạo & Các loại đậu hữu cơ", "Gạo lứt đỏ, gạo st25 organic, đậu đen xanh lòng, đậu chickpea" },
                    { 15, "Sản phẩm thuần chay (Vegan)", "Pate thuần chay, giò nấm, nước mắm chay cốt đậu nành" }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Address", "CreatedAt", "Email", "FullName", "MembershipRank", "PhoneNumber", "RewardPoints" },
                values: new object[,]
                {
                    { 1, "123 Lê Lợi, Q.1, TP.HCM", new DateTime(2026, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "nam.nguyen@gmail.com", "Nguyễn Hoàng Nam", "Bạc", "0987654321", 150 },
                    { 2, "456 Nguyễn Thị Minh Khai, Q.3, TP.HCM", new DateTime(2026, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "mai.pham@gmail.com", "Phạm Thị Mai", "Vàng", "0978123456", 520 },
                    { 3, "789 Điện Biên Phủ, Q.Bình Thạnh, TP.HCM", new DateTime(2026, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "minh.tran@gmail.com", "Trần Văn Minh", "Kim Cương", "0912345678", 1200 },
                    { 4, "12 Trần Hưng Đạo, Q.5, TP.HCM", new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "thanh.le@gmail.com", "Lê Thị Thanh", "Đồng", "0903112233", 45 },
                    { 5, "88 Nguyễn Trãi, Q.5, TP.HCM", new DateTime(2026, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "tuan.hoang@gmail.com", "Hoàng Anh Tuấn", "Bạc", "0934556677", 230 },
                    { 6, "15 Nguyễn Đình Chiểu, Q.3, TP.HCM", new DateTime(2026, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "thao.dang@gmail.com", "Đặng Thu Thảo", "Vàng", "0967889900", 680 },
                    { 7, "102 Cách Mạng Tháng 8, Q.10, TP.HCM", new DateTime(2026, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "bao.vu@gmail.com", "Vũ Quốc Bảo", "Đồng", "0981122334", 80 },
                    { 8, "234 Phan Xích Long, Q.Phú Nhuận, TP.HCM", new DateTime(2026, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "ngoc.bui@gmail.com", "Bùi Thị Ngọc", "Bạc", "0945667788", 310 },
                    { 9, "56 Võ Văn Tần, Q.3, TP.HCM", new DateTime(2026, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "khoa.do@gmail.com", "Đỗ Duy Khoa", "Đồng", "0922334455", 15 },
                    { 10, "77 Hoàng Văn Thụ, Q.Phú Nhuận, TP.HCM", new DateTime(2026, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "phuong.ngo@gmail.com", "Ngô Bích Phương", "Vàng", "0918776655", 950 },
                    { 11, "301 Lý Thường Kiệt, Q.11, TP.HCM", new DateTime(2026, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "linh.duong@gmail.com", "Dương Khánh Linh", "Bạc", "0938990011", 110 },
                    { 12, "45 Lê Văn Sỹ, Q.3, TP.HCM", new DateTime(2026, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "triet.ly@gmail.com", "Lý Minh Triết", "Kim Cương", "0971223344", 1500 },
                    { 13, "89 Nam Kỳ Khởi Nghĩa, Q.1, TP.HCM", new DateTime(2026, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "thuong.phan@gmail.com", "Phan Hoài Thương", "Đồng", "0908771122", 60 },
                    { 14, "142 Phạm Văn Đồng, Q.Thủ Đức, TP.HCM", new DateTime(2026, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "truong.trinh@gmail.com", "Trịnh Xuân Trường", "Bạc", "0961445566", 420 },
                    { 15, "67 Cộng Hòa, Q.Tân Bình, TP.HCM", new DateTime(2026, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nhi.vo@gmail.com", "Võ Tuyết Nhi", "Vàng", "0949887766", 880 }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RoleId", "Description", "RoleName" },
                values: new object[,]
                {
                    { 1, "Quản trị viên (Toàn quyền quản lý kho, nhập hàng, nhân sự và báo cáo doanh thu POS)", "Admin" },
                    { 2, "Nhân viên bán hàng / POS (Quét mã vạch, lập hóa đơn, tích điểm khách hàng)", "Thu Ngân" },
                    { 3, "Tài khoản khách hàng (Tra cứu điểm thưởng, hạng thành viên, lịch sử mua hàng)", "Khách Hàng" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierId", "Address", "ContactName", "PhoneNumber", "SupplierName" },
                values: new object[,]
                {
                    { 1, "Phường 11, TP. Đà Lạt, Lâm Đồng", "Nguyễn Văn An", "0901234567", "Nông Trại Xanh Dalat Organic Farm" },
                    { 2, "KCN Tân Bình, Tân Phú, TP.HCM", "Trần Thị Bích", "0912345678", "Công ty TNHH Thực Phẩm Sạch NutriLife" },
                    { 3, "Huyện Củ Chi, TP.HCM", "Lê Văn Cường", "0923456789", "Hợp Tác Xã Gia Vị & Nông Sản Việt" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Barcode", "BrandId", "CategoryId", "Price", "ProductName", "StockQuantity", "SupplierId" },
                values: new object[,]
                {
                    { 1, "8938501234561", 2, 1, 25000m, "Rau cải bó xôi hữu cơ 300g", 30, 1 },
                    { 2, "8938501234562", 2, 1, 32000m, "Cà chua bí đỏ hữu cơ 500g", 40, 1 },
                    { 3, "8938501234563", 2, 1, 45000m, "Bông cải xanh Đà Lạt Organic 500g", 25, 1 },
                    { 4, "8938501234564", 1, 2, 65000m, "Yến mạch nguyên hạt Quaker 500g", 30, 2 },
                    { 5, "8938501234565", 1, 2, 95000m, "Hạt hạnh nhân rang Mỹ 250g", 25, 2 },
                    { 6, "8938501234566", 1, 2, 75000m, "Hạt chia hữu cơ Úc 200g", 35, 2 },
                    { 7, "8938501234567", 1, 3, 78000m, "Sữa hạnh nhân Nutri 1L", 15, 2 },
                    { 8, "8938501234568", 1, 3, 55000m, "Sữa chua Hy Lạp không đường 500g", 20, 2 },
                    { 9, "8938501234569", 1, 3, 42000m, "Sữa đậu nành hữu cơ 1L", 30, 2 },
                    { 10, "8938501234570", 1, 4, 89000m, "Ức gà tươi đông lạnh 1kg", 50, 2 },
                    { 11, "8938501234571", 1, 4, 42000m, "Cơm gạo lứt đóng hộp ăn liền 250g", 45, 2 },
                    { 12, "8938501234572", 1, 4, 48000m, "Salad ức gà xốt chanh dây đóng gói 200g", 18, 2 },
                    { 13, "8938501234573", 3, 5, 145000m, "Dầu oliu nguyên chất Extra Virgin 500ml", 20, 3 },
                    { 14, "8938501234574", 3, 5, 120000m, "Mật ong hoa rừng nguyên chất 350ml", 18, 3 },
                    { 15, "8938501234575", 3, 5, 38000m, "Muối hồng Himalaya nguyên chất 500g", 40, 3 }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "FullName", "PasswordHash", "RoleId", "Username" },
                values: new object[,]
                {
                    { 1, "Quản Lý Nutri Mart", "admin123", 1, "admin" },
                    { 2, "Thu Ngân Ca Sáng (Nguyễn Thu Hà)", "123456", 2, "thungan01" },
                    { 3, "Thu Ngân Ca Chiều (Lê Hoàng Nam)", "123456", 2, "thungan02" },
                    { 4, "Nguyễn Hoàng Nam", "123456", 3, "khachhang01" },
                    { 5, "Phạm Thị Mai", "123456", 3, "khachhang02" }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "CustomerId", "OrderDate", "Status", "TotalAmount", "UserId" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2026, 3, 1, 10, 30, 0, 0, DateTimeKind.Unspecified), "Completed", 143000m, 2 },
                    { 2, 2, new DateTime(2026, 3, 2, 14, 15, 0, 0, DateTimeKind.Unspecified), "Completed", 120000m, 2 }
                });

            migrationBuilder.InsertData(
                table: "OrderItems",
                columns: new[] { "OrderItemId", "OrderId", "ProductId", "Quantity", "UnitPrice" },
                values: new object[,]
                {
                    { 1, 1, 3, 1, 65000m },
                    { 2, 1, 5, 1, 78000m },
                    { 3, 2, 10, 1, 120000m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerId",
                table: "Orders",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
                column: "UserId");

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
                name: "IX_Users_RoleId",
                table: "Users",
                column: "RoleId");
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
