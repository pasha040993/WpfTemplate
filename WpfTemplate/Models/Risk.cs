using System;
using System.Collections.Generic;
using System.Text;

namespace WpfTemplate.Models
{
    public class Risk
    {
        public string Id { get; set; }
        public string GenBlockId { get; set; }
        public string Value { get; set; }
        public int RowNumber { get; set; }
        //public List<> MustReviewEquipments { get; set; }
        public bool NeedReview { get; set; }
        public bool IsDraft { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string LastModifiedBy { get; set; }
        public DateTime LastModifiedDate { get; set; }
    }
}
