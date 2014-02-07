using System;
using System.ComponentModel;
using iZet.DC.VIP.Annotations;
using iZet.DC.VIP.Attributes;

namespace iZet.DC.VIP.Models
{
    public class Stats : BaseModel<Stats>
    {
        [Magic]
        public Decimal SharedAverage { get; set; }
        
        [Magic]
        public Decimal SharedMax { get; set; }

        [Magic]
        public uint Slots { get; set; }
        
        [Magic]
        public Decimal OnlineHours { get; set; }

        [Magic]
        public DateTime Time { get; set; }

        [Magic]
        public DateTime Registered { get; set; }

        [Magic]
        public decimal Traffic { get; set; }

        [Magic]
        public VIPGroup VIPGroup { get; set; }

    }
}