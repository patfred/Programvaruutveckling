using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test.Repository.Abstract;
using Test.Models;
using Test.Repository;

namespace Test.Controllers
{
    public class ContactController : ApiController
    {
        readonly IRepository<Contact> _contactRepo;

        public ContactController()
        {
            this._contactRepo = new Repository<Contact>();
        }

        public ContactController(IRepository<Contact> _contactRepo)
        {
            this._contactRepo = _contactRepo;
        }

        // GET api/values
        public IEnumerable<Contact> Get()
        {
            var users = _contactRepo.FindAll();
            return users;
        }

        // GET api/values/5
        public User Get(int id)
        {
            return _contactRepo.FindAll().First(u => u.ID == id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            Contact contact = new Contact();
            _contactRepo.Save(contact);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            var user = _companyRepo.FindAll().First(u => u.ID == id);
            _companyRepo.Save(user);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var user = _companyRepo.FindAll().First(u => u.ID == id);
            _companyRepo.Delete(user);
        }
    }
}