using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyHouse.Models
{
    public class Photo
    {
        public int id { get; set; }
        public string name { get; set; }
        public string[] location { get; set; }
    }
}