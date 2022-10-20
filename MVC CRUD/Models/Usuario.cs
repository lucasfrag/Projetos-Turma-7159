using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_CRUD.Models
{
    public class Usuario
    {
        public int id {get; set;}
        public string nome {get; set;}
        public string login {get; set;}
        public string senha {get; set;}
        public int tipo {get; set;}
    }
}