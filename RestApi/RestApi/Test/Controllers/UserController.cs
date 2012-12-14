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
        public  User Get(int id)
        {
            return _userRepo.FindAll().First(u => u.ID == id);
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            User user = new User();
            _userRepo.Save(user);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
            var user = _userRepo.FindAll().First(u => u.ID == id);
            _userRepo.Save(user);
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            var user = _userRepo.FindAll().First(u => u.ID == id);
            _userRepo.Delete(user);
        }
    }
}