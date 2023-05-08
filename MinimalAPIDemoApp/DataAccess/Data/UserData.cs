using DataAccess.DbAccess;
using DataAccess.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class UserData : IUserData
    {
        private readonly ISqlDataAccess db;

        public UserData(ISqlDataAccess db)
        {
            this.db = db;
        }

        public Task<IEnumerable<UserModel>> GetUsers() =>
            db.LoadData<UserModel, dynamic>("dbo.spUser_GetAll", new { });

        public async Task<UserModel?> GetUser(int id)
        {
            var results = await db.LoadData<UserModel, dynamic>("dbo.spUser_Get", new { Id = id });
            return results.FirstOrDefault();
        }

        public Task InsertUser(UserModel user) =>
            db.SaveData("dbo.spUser_Insert", new { user.FirstName, user.LastName });

        public Task UpdateUser(UserModel userModel) =>
            db.SaveData("dbo.spUser_Update", userModel);

        public Task DeleteUser(int id) =>
            db.SaveData("dbo.spUser_Delete", new { Id = id });
    }
}
