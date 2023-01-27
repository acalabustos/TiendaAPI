using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Entities
{
    public class UserItem
    {
        public UserItem() { }
        public int IdUser { get; set; }
        public string Email { get; set; }
        private string EncryptedPassword { get; set; }


    }
}
