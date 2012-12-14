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
    public class UserController : ApiController
    {
        readonly IRepository<User> _userRepo;

        public UserController()
        {
            this._userRepo = new Repository<User>();
        }

        public UserController(IRepository<User> _userRepo)
        {
            this._userRepo = _userRepo;
        }

        // GET api/values
        public IEnumerable<User> Get()
        {
            var users = _userRepo.FindAll();
            return users;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}