using System;
using System.Collections.Generic;

namespace ePF.portal.Entities
{
    public partial class Users
    {
        public Users()
        {
            InverseCreatedByNavigation = new HashSet<Users>();
            UserAccessLockingCreatedByNavigation = new HashSet<UserAccessLocking>();
            UserAccessLockingUser = new HashSet<UserAccessLocking>();
            UserPasswordCreatedByNavigation = new HashSet<UserPassword>();
            UserPasswordUser = new HashSet<UserPassword>();
        }

        public int UserId { get; set; }
        public byte UserTypeId { get; set; }
        public string LoginId { get; set; }
        public string UserName { get; set; }
        public string GdsAccessCodeAgent { get; set; }
        public Guid? UniqueCorporateGuid { get; set; }
        public Guid? UniqueProfileGuid { get; set; }
        public string SourcePageName { get; set; }
        public DateTime CreatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public string Ipaddress { get; set; }

        public virtual Users CreatedByNavigation { get; set; }
        public virtual Profiles UniqueProfileGu { get; set; }
        public virtual UserType UserType { get; set; }
        public virtual ICollection<Users> InverseCreatedByNavigation { get; set; }
        public virtual ICollection<UserAccessLocking> UserAccessLockingCreatedByNavigation { get; set; }
        public virtual ICollection<UserAccessLocking> UserAccessLockingUser { get; set; }
        public virtual ICollection<UserPassword> UserPasswordCreatedByNavigation { get; set; }
        public virtual ICollection<UserPassword> UserPasswordUser { get; set; }
    }
}
