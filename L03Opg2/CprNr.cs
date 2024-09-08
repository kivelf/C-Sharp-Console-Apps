using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

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

        public string BirthDate
        {
            get { return this.birthDate; }
            set { this.birthDate = value; }
        }

        public override string ToString()
        {
            return this.birthDate + "-" + this.sequenceNumber;
        }
    }
}
