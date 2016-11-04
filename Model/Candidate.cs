using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Candidate
    {
        private readonly int id;
        private string name;
        private string surname;
        private string telephoneNumber;
        private DateTime birthDate;

        public Candidate()
        {
            id = -1;
            name = surname = telephoneNumber = "brak";
            birthDate = new DateTime(1900, 1, 1, 0, 0, 0);
        }

        public Candidate(string name, string surname, string telephoneNumber,
            ushort day, ushort month, int year, int hours, int minutes, int seconds, int id = -1)
        {
            this.id = id;
            this.name = name;
            this.surname = surname;
            this.telephoneNumber = telephoneNumber;
            this.birthDate = new DateTime(year, month, day, hours, minutes, seconds);
        }

        public int Id
        {
            get
            {
                return id;
            }
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

        public string TelephoneNumber
        {
            get
            {
                return telephoneNumber;
            }
            set
            {
                telephoneNumber = value;
            }
        }

        public DateTime BirthDate
        {
            get
            {
                return birthDate;
            }
            set
            {
                birthDate = value;
            }
        }

    }
}
