using System;
using System.Collections.Generic;

namespace ePF.portal.Entities
{
    public partial class TravelAgents
    {
        public int Id { get; set; }
        public string GdsAccessCodeAgent { get; set; }
        public string AgentName { get; set; }
        public string PrimeGdsCode { get; set; }
        public string PrimePseudoCity { get; set; }
        public string TelephoneCityCode { get; set; }
        public short RowStatus { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string Ipaddress { get; set; }
    }
}
