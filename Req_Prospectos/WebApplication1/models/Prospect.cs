using System;
using System.Collections.Generic;

namespace WebApplication1.Models
{
    public partial class Prospect
    {
        public int id { get; set; }
        public string name { get; set; } = null!;
        public string lastName1 { get; set; } = null!;
        public string lastName2 { get; set; } = null!;
        public string street { get; set; } = null!;
        public string number { get; set; } = null!;
        public string colonia { get; set; } = null!;
        public string postalCode { get; set; } = null!;
        public string phone { get; set; } = null!;
        public string rfc { get; set; } = null!;
        public string status { get; set; } = null!;
        public string comments { get; set; } = null!;
    }
}
