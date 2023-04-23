using Dapper;
using Microsoft.Data.Sqlite;
using StorageAssessment.Databse;
using StorageAssessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageAssessment.Repository
{
    public class FileRepository : IFileRepository
    {
        private readonly DatabaseConfig databaseConfig;

        public FileRepository(DatabaseConfig databaseConfig)
        {
            this.databaseConfig = databaseConfig;
        }

        public async Task Create(FileModel fileModel)
        {
            using var connection = new SqliteConnection(databaseConfig.Name);

            await connection.ExecuteAsync("INSERT INTO FileName (Name,Location,Type)" +
                "VALUES (@Name,@Location,@Type);", fileModel);
        }

        public async Task<bool> EntryExists(string name, string location)
        {
            using var connection = new SqliteConnection(databaseConfig.Name);
            var result = await connection.QueryAsync($"Select * FROM FileName WHERE Name='{name}' AND Location='{location}';");
            if (result.Count()!=0)
            {
                return true;
            }
            return false;
        }
    }
}
