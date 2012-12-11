namespace RestApi.Controllers
{
using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RestApi.Repository.Abstract;

    public class UsersController : ApiController
    {
        private IRepository<User> _userRepo;

        public UsersController(IRepository<User> users)
        {
            _userRepo = users;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _userRepo.FindAll();
        }

        public User GetUserById(int id)
        {
            var user = _userRepo.FindByID(id);
            if (user == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return user;
        }

        public IEnumerable<User> GetUsersByAdmin(string admin)
        {
            return _userRepo.FindAll().Where(u => u.Admin == 1);
        }
        /*
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Update(int id)
        {
            return View();
        }
        public ActionResult Delete(int id)
        {
            return View();
        }
        public ActionResult LogOn(string email, string password)
        {
            return View();
        }
        public ActionResult LogOn(string email)
        {
            return View();
        }*/
    }
}
