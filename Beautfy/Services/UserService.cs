using Beautfy.Models.DataModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beautfy.Services
{
    public class UserService
    {
        SQLiteConnection conn;
        public UserService()
        {
            conn = new SQLiteConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "User.db3"));
            conn.CreateTable<UserEntity>();
        }
        public int AddUser(UserEntity user)
        {
            return conn.Insert(user);
        }

        //public async Task<int> DeleteUser(UserEntity user)
        //{
        //    return await _dbConnection.DeleteAsync(user);
        //}
        //public async Task<int> UpdateUser(UserEntity user)
        //{
        //    return await _dbConnection.UpdateAsync(user);
        //}
        public async Task<List<UserEntity>> GetAllUser()
        {
            return conn.Table<UserEntity>().ToList();
        }

        //public async Task<UserEntity> GetUserByID(int userId)
        //{
        //    var user = await _dbConnection.QueryAsync<UserEntity>($"Select * From {nameof(UserEntity)} where UserId={userId} ");
        //    return user.FirstOrDefault();
        //}

    }
}
