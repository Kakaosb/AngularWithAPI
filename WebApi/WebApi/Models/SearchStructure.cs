using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    public class SearchStructure
    {
        public string Name { get; set; }
        public string Sername { get; set; }
        public string Gender { get; set; }
        public string IsAdult { get; set; }
        public string Continent { get; set; }
    }
}