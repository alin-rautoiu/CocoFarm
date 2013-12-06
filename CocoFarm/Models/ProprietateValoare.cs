using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CocoFarm.Models
{
    public class ProprietateValoare
    {
        public Proprietate Proprietate { get; set; }
        public String Valoare { get; set; }

        public int ProdusId { get; set; }
    }
}