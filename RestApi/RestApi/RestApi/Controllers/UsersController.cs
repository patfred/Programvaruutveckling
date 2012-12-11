namespace RestApi.Controllers
{
using RestApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;


    public class UsersController : ApiController
    {

        User[] users = new User[] 
        { 
            new User { ID = 1, Email = "test@gmail.com"}, 
            new User { ID = 2, Email = "test@gmail.com"}, 
            new User { ID = 3, Email = "test@gmail.com"} 
        };

        public IEnumerable<User> GetAllUsers()
        {
            return users;
        }
        public User GetUserById(int id)
        {
            var user = users.FirstOrDefault((p) => p.ID == id);
            if (user == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return user;
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
