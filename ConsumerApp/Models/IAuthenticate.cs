using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsumerApp.Models
{
    public interface IAuthenticate
    {
        public string isValidUser(Employee emp);
    }
}
