using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Interview.Model
{
    public class Payment
    {
        public Guid Id { get; set; }
        public string ApplicationId { get; set; }
        public string Type { get; set; }
        public string Summary { get; set; }
        public float Amount { get; set; }
        public DateTime PostingDate { get; set; }
        public bool IsCleared { get; set; }
        public DateTime? ClearedDate { get; set; }
    }
}