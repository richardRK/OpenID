using System;
using System.Collections.Generic;

namespace ePF.portal.Entities
{
    public partial class Corporates
    {
        public Guid UniqueCorporateGuid { get; set; }
        public string GdsAccessCodeAgent { get; set; }
        public string CorporateName { get; set; }
        public string DefaultGdsAccessCode { get; set; }
        public bool AllowSelfCreation { get; set; }
        public string SelfCreatePin { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string Ipaddress { get; set; }
    }
}
