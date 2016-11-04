using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Recruiter
    {
        private readonly int id;
        private string name;
        private string surname;
        private string profession;

        public Recruiter(string name, string surname, string profession, int id = -1)
        {
            this.name = name;
            this.surname = surname;
            this.profession = profession;
            this.id = id;
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Surname
        {
            get
            {
                return surname;
            }

            set
            {
                surname = value;
            }
        }

        public string Profession
        {
            get
            {
                return profession;
            }

            set
            {
                profession = value;
            }
        }


    }
}
