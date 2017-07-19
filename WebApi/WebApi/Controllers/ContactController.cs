using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;
using WebApi.Extension;

namespace WebApi.Controllers
{

    public class ContactController : ApiController
    {
        // GET api/contact
        public string Get([FromUri]SearchStructure searchStructure)
        {
            try
            {
                var contacts = GetContactStubs(); //Contacts from DB stubs

                contacts = contacts.Filter(searchStructure);

                var trContacts = TransformContacts(contacts);

                string contacts_json = JsonConvert.SerializeObject(trContacts);

                return contacts_json;
            }
            catch
            {
                return "Server error. Please contact the System Administrator of this site.";
            }
        }

        // GET api/contact/5
        public string Get(int id)
        {
            return "contact";
        }

        // POST api/contact
        public string Post(ContactForResponse contact_object)

        {
            try
            {
                var continent = Int32.Parse(contact_object.Continent);
                var gender = Int32.Parse(contact_object.Gender);

                Contact contact = new Contact
                {
                    Continent = (Continent)continent,
                    Gender = (Gender)gender,
                    IsAdult = contact_object.IsAdult,
                    Name = contact_object.Name,
                    Sername = contact_object.Sername
                };

                //Add item to DataBase like
                //Db.Contacts.Add(contact);
                //Db.SaveChanges();

                return "Successfully added";
            }
            catch
            {
                return "Server error. Please contact the System Administrator of this site.";
            }
        }

        // PUT api/contact/5
        public void Put(int id, [FromBody]string contact)
        {
        }

        // DELETE api/contact/5
        public void Delete(int id)
        {
        }

        private IEnumerable<Contact> GetContactStubs()
        {
            #region STUBS

            Contact[] contacts = {
                new Contact {
                    id = 1,
                    Name = "John",
                    Sername = "Smith",
                    Gender = Gender.Male,
                    IsAdult = true,
                    Continent = Continent.Africa
                },
                  new Contact {
                    id = 2,
                    Name = "Eric",
                    Sername = "Smith",
                    Gender = Gender.Male,
                    IsAdult = false,
                    Continent = Continent.North_America
                },
                    new Contact {
                    id = 3,
                    Name = "Katrine",
                    Sername = "White",
                    Gender = Gender.Female,
                    IsAdult = true,
                    Continent = Continent.Antarctica
                },
                      new Contact {
                    id = 4,
                    Name = "Lana",
                    Sername = "White",
                    Gender = Gender.Female,
                    IsAdult = false,
                    Continent = Continent.Eurasia
                },
                        new Contact {
                    id = 5,
                    Name = "John",
                    Sername = "Black",
                    Gender = Gender.Male,
                    IsAdult = true,
                    Continent = Continent.Eurasia
                }
                };
            #endregion

            return contacts;
        }

        private IEnumerable<ContactForResponse> TransformContacts(IEnumerable<Contact> contacts)
        {
            return contacts.Select(el =>
                new ContactForResponse
                {
                    id = el.id,
                    Continent = ((Continent)el.Continent).ToString(),
                    Gender = ((Gender)el.Gender).ToString(),
                    IsAdult = el.IsAdult,
                    Name = el.Name,
                    Sername = el.Sername
                });
        }
    }
}
