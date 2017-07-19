using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApi.Models
{
    //Example model in DB
    public class Contact
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Sername { get; set; }
        public Gender Gender { get; set; }
        public bool IsAdult { get; set; }
        public Continent Continent { get; set; }
    }

    public enum Gender
    {
        Male ,
        Female,
        Other
    }

    public enum Continent
    {
        Africa,
        Antarctica,
        Australia, 
        Eurasia,
        North_America,
        South_America
    }
}