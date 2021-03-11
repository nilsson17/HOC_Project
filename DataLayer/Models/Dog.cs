using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class Dog
    {
        public int DogId { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public Person Person { get; set; }

    }
}
