using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beautfy.Models.DataModels
{
    public class UserEntity
    {
        [PrimaryKey]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string SkinType { get; set; }
        public string  Gender { get; set; }

    }
}
