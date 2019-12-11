using System;
using System.Collections.Generic;

namespace ePF.portal.Entities
{
    public partial class UserAccessLocking
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public byte TriesLeft { get; set; }
        public string IpaddressFailed { get; set; }
        public DateTime? AccessFailedDate { get; set; }
        public DateTime? LastAccessedDate { get; set; }
        public short RowStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string Ipaddress { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual Users User { get; set; }
    }
}
