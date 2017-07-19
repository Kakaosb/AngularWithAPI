using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApi.Models;

namespace WebApi.Extension
{
    public static class ContactExt
    {
        public static IEnumerable<Contact> Filter(this IEnumerable<Contact> contacts, SearchStructure filters)
        {

            if (filters.Gender != "null" && filters.Gender != "Both")
            {
                var gender = Enum.Parse(typeof(Gender), filters.Gender);

                var g = (Gender)gender;

                contacts = contacts.Where(el => el.Gender == g);
            }

            if (filters.Continent != "null")
            {
                var continent = Enum.Parse(typeof(Continent), filters.Continent);

                var c = (Continent)continent;

                contacts = contacts.Where(el => el.Continent == c);
            }

            if (filters.IsAdult != "null" && filters.IsAdult != "Both")
            {
                var isAdult = Boolean.Parse(filters.IsAdult);

                contacts = contacts.Where(el => el.IsAdult == isAdult);
            }

            if (filters.Name != null)
                contacts = contacts.Where(el => el.Name == filters.Name);

            if (filters.Sername != null)
                contacts = contacts.Where(el => el.Sername == filters.Sername);        
            
            return contacts;
        }
    }
}