using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProMvc4.Models
{
    public class Product
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
    }
}