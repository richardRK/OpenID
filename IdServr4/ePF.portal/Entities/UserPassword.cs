using System;
using System.Collections.Generic;

namespace ePF.portal.Entities
{
    public partial class UserPassword
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string UserPassword1 { get; set; }
        public string PasswordQuestion { get; set; }
        public string PasswordAnswer { get; set; }
        public string ActivationTokenId { get; set; }
        public DateTime? PwdTokenIdDateTime { get; set; }
        public string PwdTokenId { get; set; }
        public short RowStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string Ipaddress { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual Users User { get; set; }
    }
}
