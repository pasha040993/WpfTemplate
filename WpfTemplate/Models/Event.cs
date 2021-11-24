using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WpfTemplate.Models
{
    public enum StateModes
    {
        Info,
        Warning,
        Error
    }

    class Event
    {
        public string Id { get; set; }
        public DateTime DateTime { get; set; }
        public string UniqueHash { get; set; }
        public int TotalCount { get; set; }
        public string SubstationId { get; set; }
        public string SubstationName { get; set; }
        public StateModes State { get; set; }
        public string Source { get; set; }

        public List<Generator> Generators { get; set; }
        public List<Equipment> Equipment { get; set; }

        public string MsgoTableId { get; set; }
        public string GenBlockId { get; set; }
        public string SubstationStateHistoryId { get; set; }
        public List<Directive> Directives { get; set; }

        public List<Risk> Risks { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
