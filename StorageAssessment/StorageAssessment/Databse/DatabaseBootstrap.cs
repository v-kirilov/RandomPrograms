using Dapper;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageAssessment.Databse
{
    internal class DatabaseBootstrap : IDatabaseBootstrap
    {
        private readonly DatabaseConfig config;
        public DatabaseBootstrap(DatabaseConfig config)
        {
            this.config = config;
        }
        public void Setup()
        {
            using var connection = new SqliteConnection(config.Name);

            var table = connection.Query<string>("SELECT name FROM sqlite_master WHERE type='table' AND name = 'FileName';");
            var tableName = table.FirstOrDefault();
            if (!string.IsNullOrEmpty(tableName) && tableName == "FileName") 
            { 
                return; 
            }
            connection.Execute("Create Table FileName (" +
                "Name VARCHAR(100) NOT NULL," +
                "Location VARCHAR(100) NULL," +
                "Type INTEGER NOT NULL);" );
        }

    }
}
