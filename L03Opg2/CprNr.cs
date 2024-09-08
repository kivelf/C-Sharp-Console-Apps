using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L03Opg2
{
    public class CprNr
    {
        private string birthDate { get; set; }
        private string sequenceNumber { get; set; }
        public CprNr(string bDate, string sNr) 
        {
            birthDate = bDate;
            sequenceNumber = sNr;
        }

        public string BirthDate {  get birthDate; }

        public string Cpr { return BirthDate;  }
    }
}
