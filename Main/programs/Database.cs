using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO; 
using System.Text;

namespace Presyong_Ka_Piyu.Main.programs
{

    public static class Database
    {
        // Path to your existing database file
        private static string dbPath = @"C:\Users\conel\Downloads\Programs\Projects\Presyong_Ka-Piyu\Main\data\Presyong_Ka-Piyu_Database.db";

        public static SQLiteConnection GetConnection()
        {
            // Classic System.Data.SQLite syntax — works with installed interop
            return new SQLiteConnection("Data Source=" + dbPath + ";Version=3;");
        }

        // Initialize tables if they do not exist
        public static void Initialize()
        {
            using var conn = GetConnection();
            conn.Open();

            CreateTables(conn);
            SeedDefaultLocations(conn);
        }

        private static void CreateTables(SQLiteConnection conn)
        {
            // Locations Tables
            string createLocationsTable = @"
    CREATE TABLE IF NOT EXISTS Locations (
        Id INTEGER PRIMARY KEY AUTOINCREMENT,
        LocationName TEXT NOT NULL UNIQUE,
        CreatedAt TEXT DEFAULT CURRENT_TIMESTAMP
    );
";


            // Products table
            string createProductsTable = @"
    CREATE TABLE IF NOT EXISTS Products (
        Id INTEGER PRIMARY KEY AUTOINCREMENT,
        Name TEXT NOT NULL,
        CategoryId INTEGER NOT NULL,
        Description TEXT,
        ImagePath TEXT,
        Rating REAL DEFAULT 0,
        IsFavorite INTEGER DEFAULT 0,
        CreatedAt TEXT DEFAULT CURRENT_TIMESTAMP,
        FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
    );
";

            // Categories table
            string createCategoriesTable = @"
                CREATE TABLE IF NOT EXISTS Categories (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    CategoryName TEXT NOT NULL,
                    CategoryType TEXT NOT NULL CHECK (CategoryType IN ('Product', 'Store')),
                    Description TEXT
                );
            ";

            // Stores table
            string createStoresTable = @"
    CREATE TABLE IF NOT EXISTS Stores (
        Id INTEGER PRIMARY KEY AUTOINCREMENT,
        Name TEXT NOT NULL,
        LocationId INTEGER NOT NULL,
        Contact TEXT,
        ImagePath TEXT,
        Description TEXT,
        Rating REAL DEFAULT 0,
        CategoryId INTEGER NOT NULL,
        IsFavorite INTEGER DEFAULT 0,
        CreatedAt TEXT DEFAULT CURRENT_TIMESTAMP,
        FOREIGN KEY (CategoryId) REFERENCES Categories(Id),
        FOREIGN KEY (LocationId) REFERENCES Locations(Id)
    );
";
            // Prices table
            string createPricesTable = @"
                CREATE TABLE IF NOT EXISTS Prices (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ProductId INTEGER NOT NULL,
                    StoreId INTEGER NOT NULL,
                    Price REAL NOT NULL,
                    CreatedAt TEXT DEFAULT CURRENT_TIMESTAMP,
                    FOREIGN KEY (ProductId) REFERENCES Products(Id),
                    FOREIGN KEY (StoreId) REFERENCES Stores(Id)
                );
            ";

            // Users table
            string createUsersTable = @"
            CREATE TABLE IF NOT EXISTS Users (
                AccountId INTEGER PRIMARY KEY AUTOINCREMENT,
                Username TEXT NOT NULL UNIQUE,
                PasswordHash TEXT NOT NULL,
                FullName TEXT,
                Role TEXT DEFAULT 'User',
                Email TEXT,
                SchoolID TEXT UNIQUE,
                Bio TEXT,
                Course TEXT,
                Department TEXT,
                ContactNumber TEXT,
                ContactFacebook TEXT,
                ContactInsta TEXT,             
                DateOfBirth TEXT,
                Address TEXT,
                ProfilePicture TEXT,
                CreatedAt TEXT DEFAULT CURRENT_TIMESTAMP
                );
            ";

            // Execute all
            ExecuteNonQuery(conn, createCategoriesTable);
            ExecuteNonQuery(conn, createProductsTable);
            ExecuteNonQuery(conn, createStoresTable);
            ExecuteNonQuery(conn, createPricesTable);
            ExecuteNonQuery(conn, createUsersTable);
            ExecuteNonQuery(conn, createLocationsTable);

        }

        private static void SeedDefaultLocations(SQLiteConnection conn)
        {
            string[] defaultLocations = { "Cafeteria 1", "Cafeteria 2", "Print Shop 1", "Print Shop 2", "BAO", "GATE1", "GATE2", "Activity Center", "CCS", "CAS", "CIT", "CCJE", "CBAA", "CTE", "CIHTM", "CONAH", "COE", "Automotive", "Hotel", "Church", "Admin", "Library", "Court", "The Gears", "OPEN FIELD", "GRAND STAND"};

            foreach (var location in defaultLocations)
            {
                using var cmd = new SQLiteCommand(@"
                    INSERT OR IGNORE INTO Locations (LocationName) 
                    VALUES (@LocationName);", conn);
                cmd.Parameters.AddWithValue("@LocationName", location);
                cmd.ExecuteNonQuery();
            }
        }


        private static void ExecuteNonQuery(SQLiteConnection conn, string sql)
        {
            using var cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}