using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace ConsumerApp.Models
{
    public class Authenticate : IAuthenticate
    {
        private IConfiguration _configuration;
        public Authenticate(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public string isValidUser(Employee emp)
        {
            string Url = _configuration["EmployeeAPI"];
            Uri uri = new Uri(Url);

            WebClient client = new WebClient();
            client.Headers["content-type"] = "application/json";

            var request = emp;
            var response = client.UploadString(uri, JsonConvert.SerializeObject(request));

            return response;
        }
    }
}
