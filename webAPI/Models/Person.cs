using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webAPI.Models
{
    public abstract class Person
    {
        public string name { get; set; } = "";
        public string surname { get; set; } = "";
    }
}