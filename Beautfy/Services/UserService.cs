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
        public int AddUser(UserEntity user)
        {
            SQLiteConnection conn = new SQLiteConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "User.db3"));
            conn.CreateTable<UserEntity>();
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
            SQLiteConnection conn = new SQLiteConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "User.db3"));
            conn.CreateTable<UserEntity>();
            return conn.Table<UserEntity>().ToList();
        }

        //public async Task<UserEntity> GetUserByID(int userId)
        //{
        //    var user = await _dbConnection.QueryAsync<UserEntity>($"Select * From {nameof(UserEntity)} where UserId={userId} ");
        //    return user.FirstOrDefault();
        //}

    }
}
