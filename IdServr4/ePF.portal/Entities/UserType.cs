using System;
using System.Collections.Generic;

namespace ePF.portal.Entities
{
    public partial class UserType
    {
        public UserType()
        {
            Users = new HashSet<Users>();
        }

        public byte UserTypeId { get; set; }
        public string UserTypeName { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
