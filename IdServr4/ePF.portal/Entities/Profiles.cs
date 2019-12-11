using System;
using System.Collections.Generic;

namespace ePF.portal.Entities
{
    public partial class Profiles
    {
        public Profiles()
        {
            Users = new HashSet<Users>();
        }

        public Guid UniqueProfileGuid { get; set; }
        public Guid UniqueCorporateGuid { get; set; }
        public string IdNumber { get; set; }
        public string Remarks { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string Ipaddress { get; set; }

        public virtual ICollection<Users> Users { get; set; }
    }
}
