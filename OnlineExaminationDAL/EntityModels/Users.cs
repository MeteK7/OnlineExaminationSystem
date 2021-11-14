using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineExaminationDAL.EntityModels
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }
        public ICollection<Groups> Groups { get; set; } = new HashSet<Groups>();
    }
}
