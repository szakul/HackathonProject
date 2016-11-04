using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    class Vacancy
    {
        public int Id { get; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Vacancy(string name, string description, int id = -1)
        {
            Name = name;
            Description = Description;
            Id = id;
        }
    }
}
