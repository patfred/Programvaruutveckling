using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Test.Repository.Abstract;
using Test.Models;
using Test.Repository;
using RestApi.Models;

namespace Test.Controllers
{
    public class CompanyController : ApiController
    {
        readonly IRepository<Company> _companyRepo;

        public CompanyController()
        {
            this._companyRepo = new Repository<Company>();
        }

        public CompanyController(IRepository<Company> _companyRepo)
        {
            this._companyRepo = _companyRepo;
        }

        // GET api/values
        public IEnumerable<Company> Get()
        {
            var users = _companyRepo.FindAll();
            return users;
        }

        // GET api/values/5
        public User Get(int id)
        {
            return _companyRepo.FindAll().First(u => u.ID == id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            User user = new User();
            _companyRepo.Save(user);
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