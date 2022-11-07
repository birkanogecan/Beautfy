using Beautfy.Models.DataModels;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beautfy.Services
{
    public class RutinService
    {
        SQLiteConnection conn;
        public RutinService()
        {
            conn = new SQLiteConnection(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Rutin.db3"));
            conn.CreateTable<RutinEntity>();
        }
        public int AddRutin(RutinEntity rutin)
        {
            return conn.Insert(rutin);
        }
        public int UpdateRutin(RutinEntity rutin)
        {
            return conn.Update(rutin);
        }
        public RutinEntity GetRutinByID(int rutinId)
        {
            var rutin = conn.Query<RutinEntity>($"Select * From {nameof(RutinEntity)} where Id={rutinId} ");
            return rutin.FirstOrDefault();
        }
        public List<RutinEntity> GetAllRutins()
        {
            return conn.Table<RutinEntity>().ToList();
        }
    }
}
