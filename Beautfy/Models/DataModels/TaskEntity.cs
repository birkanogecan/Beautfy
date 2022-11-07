using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beautfy.Models.DataModels
{
    public class TaskEntity
    {
        [PrimaryKey]
        public int Id { get; set; }
        public int RutinId { get; set; }
        public string Description { get; set; }
        public bool IsDone { get; set; }
    }
}
