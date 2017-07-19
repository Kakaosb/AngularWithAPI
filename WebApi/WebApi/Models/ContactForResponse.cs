using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class ContactForResponse
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Sername { get; set; }
        public string Gender { get; set; }
        public bool IsAdult { get; set; }
        public string Continent { get; set; }
    }
}