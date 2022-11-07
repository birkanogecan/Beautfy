using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beautfy.Models.DataModels
{
    public class RutinEntity
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsAssigned { get; set; }
        public int Period { get; set; }
        public int Cycle { get; set; }
    }
}
