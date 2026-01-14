using System.Text;
using Microsoft.EntityFrameworkCore;

namespace DynamicData.Web.Config.After.Data;

public class InitializeDatabase
{
    public static void SeedData(ApplicationDbContext db)
    {
        db.Database.EnsureCreated();
        db.Database.ExecuteSqlRaw(DbScript());
    }

    private static string DbScript()
    {
        var sql = new StringBuilder();

        sql.AppendLine("IF(NOT EXISTS (SELECT * ");
        sql.AppendLine("               FROM sys.objects ");
        sql.AppendLine("               WHERE object_id=OBJECT_ID(N'[dbo].[UserData]')AND type IN (N'U'))) BEGIN ");
        sql.AppendLine("    CREATE TABLE [dbo].[UserData] ([Id] [INT] IDENTITY(1, 1) NOT NULL, ");
        sql.AppendLine("    [FirstName] [VARCHAR](150) NOT NULL, ");
        sql.AppendLine("    [LastName] [VARCHAR](150) NOT NULL, ");
        sql.AppendLine("    [City] [VARCHAR](50) NOT NULL, ");
        sql.AppendLine("    [USState] [VARCHAR](2) NOT NULL, ");
        sql.AppendLine("    [Age] [SMALLINT] NULL ");
        sql.AppendLine(
            "    CONSTRAINT [PK_UserData] PRIMARY KEY CLUSTERED([Id] ASC)WITH(PAD_INDEX=OFF, STATISTICS_NORECOMPUTE=OFF, IGNORE_DUP_KEY=OFF, ALLOW_ROW_LOCKS= ON, ALLOW_PAGE_LOCKS=ON, OPTIMIZE_FOR_SEQUENTIAL_KEY=OFF)ON [PRIMARY])ON [PRIMARY]; ");

        sql.AppendLine("    SET IDENTITY_INSERT [dbo].[UserData] ON; ");
        sql.AppendLine("    INSERT [dbo].[UserData]([Id], [FirstName], [LastName], [City], [USState], [Age]) ");
        sql.AppendLine("    VALUES(1, N'Nicole', N'Bartlett', N'Denver', N'RI', 27); ");
        sql.AppendLine("    INSERT [dbo].[UserData]([Id], [FirstName], [LastName], [City], [USState], [Age]) ");
        sql.AppendLine("    VALUES(2, N'Christine', N'Rubio', N'Columbus', N'MN', 55); ");
        sql.AppendLine("    INSERT [dbo].[UserData]([Id], [FirstName], [LastName], [City], [USState], [Age]) ");
        sql.AppendLine("    VALUES(3, N'Pablo', N'Werner', N'Norfolk', N'KY', 32); ");
        sql.AppendLine("    INSERT [dbo].[UserData]([Id], [FirstName], [LastName], [City], [USState], [Age]) ");
        sql.AppendLine("    VALUES(4, N'Darnell', N'Calderon', N'Richmond', N'WI', 19); ");
        sql.AppendLine("    INSERT [dbo].[UserData]([Id], [FirstName], [LastName], [City], [USState], [Age]) ");
        sql.AppendLine("    VALUES(5, N'Desiree', N'Farmer', N'Greensboro', N'KY', 47); ");
        sql.AppendLine("    INSERT [dbo].[UserData]([Id], [FirstName], [LastName], [City], [USState], [Age]) ");
        sql.AppendLine("    VALUES(6, N'Holly', N'Fernandez', N'San Die', N'WA', 28); ");
        sql.AppendLine("    INSERT [dbo].[UserData]([Id], [FirstName], [LastName], [City], [USState], [Age]) ");
        sql.AppendLine("    VALUES(7, N'Chadwick', N'Trevino', N'San Die', N'MT', 38); ");
        sql.AppendLine("    INSERT [dbo].[UserData]([Id], [FirstName], [LastName], [City], [USState], [Age]) ");
        sql.AppendLine("    VALUES(8, N'Julie', N'Moreno', N'Rochester', N'FL', 70); ");
        sql.AppendLine("    INSERT [dbo].[UserData]([Id], [FirstName], [LastName], [City], [USState], [Age]) ");
        sql.AppendLine("    VALUES(9, N'Daphne', N'Dudley', N'Houston', N'DE', 18); ");
        sql.AppendLine("    INSERT [dbo].[UserData]([Id], [FirstName], [LastName], [City], [USState], [Age]) ");
        sql.AppendLine("    VALUES(10, N'Jean', N'Trevino', N'Fort Wayne', N'LA', 21); ");

        sql.AppendLine("    SET IDENTITY_INSERT [dbo].[UserData] OFF; ");
        sql.AppendLine("END; ");

        sql.AppendLine("IF(NOT EXISTS (SELECT * ");
        sql.AppendLine("               FROM sys.objects ");
        sql.AppendLine("               WHERE object_id=OBJECT_ID(N'[dbo].[Product]')AND type IN (N'U'))) BEGIN ");
        sql.AppendLine("    CREATE TABLE [dbo].[Product] ([ProductID] [INT] IDENTITY(1, 1) NOT NULL, ");
        sql.AppendLine("    [Name] varchar(150) NOT NULL, ");
        sql.AppendLine("    [ProductNumber] [NVARCHAR](25) NOT NULL, ");
        sql.AppendLine("    [StandardCost] [MONEY] NOT NULL, ");
        sql.AppendLine("    [ListPrice] [MONEY] NOT NULL, ");
        sql.AppendLine(
            "    CONSTRAINT [PK_Product_ProductID] PRIMARY KEY CLUSTERED([ProductID] ASC)WITH(PAD_INDEX=OFF, STATISTICS_NORECOMPUTE=OFF, IGNORE_DUP_KEY=OFF, ALLOW_ROW_LOCKS= ON, ALLOW_PAGE_LOCKS=ON, OPTIMIZE_FOR_SEQUENTIAL_KEY=OFF)ON [PRIMARY])ON [PRIMARY]; ");
        sql.AppendLine("    ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('LL Mountain Seat Assembly', 'SA-M198', 133.34, 98.77); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('ML Mountain Seat Assembly', 'SA-M237', 147.14, 108.99); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('HL Mountain Seat Assembly', 'SA-M687', 196.92, 145.87); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('LL Road Seat Assembly', 'SA-R127', 133.34, 98.77); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('ML Road Seat Assembly', 'SA-R430', 147.14, 108.99); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('HL Road Seat Assembly', 'SA-R522', 196.92, 145.87); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('LL Touring Seat Assembly', 'SA-T467', 133.34, 98.77); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('ML Touring Seat Assembly', 'SA-T612', 147.14, 108.99); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('HL Touring Seat Assembly', 'SA-T872', 196.92, 145.87); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('HL Road Frame - Black, 58', 'FR-R92B-58', 1431.50, 1059.31); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('HL Road Frame - Red, 58', 'FR-R92R-58', 1431.50, 1059.31); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('Sport-100 Helmet, Red', 'HL-U509-R', 34.99, 13.09); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('Sport-100 Helmet, Black', 'HL-U509', 34.99, 13.09); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('Mountain Bike Socks, M', 'SO-B909-M', 9.50, 3.40); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('Mountain Bike Socks, L', 'SO-B909-L', 9.50, 3.40); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('Sport-100 Helmet, Blue', 'HL-U509-B', 34.99, 13.09); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('AWC Logo Cap', 'CA-1098', 8.99, 6.92); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('Long-Sleeve Logo Jersey, S', 'LJ-0192-S', 49.99, 38.49); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('Long-Sleeve Logo Jersey, M', 'LJ-0192-M', 49.99, 38.49); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('Long-Sleeve Logo Jersey, L', 'LJ-0192-L', 49.99, 38.49); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('Long-Sleeve Logo Jersey, XL', 'LJ-0192-X', 49.99, 38.49); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('HL Road Frame - Red, 62', 'FR-R92R-62', 1431.50, 868.63); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('HL Road Frame - Red, 44', 'FR-R92R-44', 1431.50, 868.63); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('HL Road Frame - Red, 48', 'FR-R92R-48', 1431.50, 868.63); ");
        sql.AppendLine("    INSERT INTO dbo.Product([Name], ProductNumber, StandardCost, ListPrice) ");
        sql.AppendLine("    VALUES('HL Road Frame - Red, 52', 'FR-R92R-52', 1431.50, 868.63); ");
        sql.AppendLine("END; ");

        return sql.ToString();
    }
}