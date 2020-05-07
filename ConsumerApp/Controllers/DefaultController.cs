using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsumerApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace ConsumerApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DefaultController : Controller
    {
        private IAuthenticate _authenticate;
        public DefaultController(IAuthenticate authenticate)
        {
            _authenticate = authenticate;
        }

        [HttpPost]
        public string Index(Employee emp)
        {
            return _authenticate.isValidUser(emp);
            //return View();
        }
    }
}