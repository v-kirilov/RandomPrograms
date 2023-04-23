using Dapper;
using Microsoft.Data.Sqlite;
using StorageAssessment.Databse;
using StorageAssessment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StorageAssessment.Provider
{
    public class FileNameProvider : IFileNameProvider
    {
        private readonly DatabaseConfig databaseConfig;
        public FileNameProvider(DatabaseConfig databaseConfig)
        {
            this.databaseConfig = databaseConfig;
        }

        public async Task<IEnumerable<FileModel>> Get()
        {
            using var connection = new SqliteConnection(databaseConfig.Name);
            return await connection.QueryAsync<FileModel>("SELECT * FROM FileModel;");
        }
    }
}
