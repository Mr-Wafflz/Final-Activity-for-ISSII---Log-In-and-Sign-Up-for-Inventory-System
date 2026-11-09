using System;
using System.Data.OleDb;
using System.IO;

namespace Ohtsuka_Act
{
    public class DBConnection
    {
        private static readonly string dbPath =
            Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Database",
                "InventoryDB.accdb"
            );

        private static readonly string connectionString =
            "Provider=Microsoft.ACE.OLEDB.12.0;" +
            "Data Source=" + dbPath + ";" +
            "Persist Security Info=False;";

        public static OleDbConnection GetConnection()
        {
            if (!File.Exists(dbPath))
            {
                throw new FileNotFoundException(
                    "InventoryDB.accdb was not found. " +
                    "Please check your Database folder.",
                    dbPath
                );
            }

            return new OleDbConnection(connectionString);
        }
    }
}
