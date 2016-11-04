using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Model
{
    class Application
    {
        private readonly int id;
        private Candidate candidate;
        private Vacancy vacancy;
        private string cvPath;

        public Candidate Candidate
        {
            get { return candidate; }
            set { candidate = value; }
        }

        public Vacancy Vacancy
        {
            get { return vacancy; }
            set { vacancy = value; }
        }

        public string CvPath
        {
            get { return cvPath;}
            set { cvPath = value;}
        }

        public Application(Candidate candidate, Vacancy vacancy, string cvPath, int id = -1)
        {
            this.candidate = candidate;
            this.vacancy = vacancy;
            this.cvPath = cvPath;
            this.id = id;
        }





    }
}
