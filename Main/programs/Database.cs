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
        }

        private static void CreateTables(SQLiteConnection conn)
        {

            string createItemsTable = @"
                CREATE TABLE IF NOT EXISTS Items (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Name TEXT NOT NULL,
                    CategoryId INTEGER,
                    Description TEXT,
                    ImagePath TEXT,
                    CreatedAt TEXT DEFAULT CURRENT_TIMESTAMP,
                    FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
                );
            ";

            // Categories table
            string createCategoriesTable = @"
                CREATE TABLE IF NOT EXISTS Categories (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    CategoryName TEXT NOT NULL,
                    Description TEXT
                );
            ";

            // Stores table
            string createStoresTable = @"
                CREATE TABLE IF NOT EXISTS Stores (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    StoreName TEXT NOT NULL,
                    Location TEXT,
                    ContactNumber TEXT,
                    CreatedAt TEXT DEFAULT CURRENT_TIMESTAMP
                );
            ";

            // Prices table
            string createPricesTable = @"
                CREATE TABLE IF NOT EXISTS Prices (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    ItemId INTEGER NOT NULL,
                    StoreId INTEGER NOT NULL,
                    Price REAL NOT NULL,
                    LastUpdated TEXT DEFAULT CURRENT_TIMESTAMP,
                    FOREIGN KEY (ItemId) REFERENCES Items(Id),
                    FOREIGN KEY (StoreId) REFERENCES Stores(Id)
                );
            ";

            // Users table
            string createUsersTable = @"
                CREATE TABLE IF NOT EXISTS Users (
                    Id INTEGER PRIMARY KEY AUTOINCREMENT,
                    Username TEXT NOT NULL UNIQUE,
                    PasswordHash TEXT NOT NULL,
                    FullName TEXT,
                    Role TEXT DEFAULT 'User',
                    Email TEXT,
                    CreatedAt TEXT DEFAULT CURRENT_TIMESTAMP
                );
            ";

            // Execute all
            ExecuteNonQuery(conn, createCategoriesTable);
            ExecuteNonQuery(conn, createItemsTable);
            ExecuteNonQuery(conn, createStoresTable);
            ExecuteNonQuery(conn, createPricesTable);
            ExecuteNonQuery(conn, createUsersTable);

        }

        private static void ExecuteNonQuery(SQLiteConnection conn, string sql)
        {
            using var cmd = new SQLiteCommand(sql, conn);
            cmd.ExecuteNonQuery();
        }
    }
}