using CocoFarm.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CocoFarm.Models
{
    public class Proprietate : IEntityWithId
    {
        public String Nume { get; set; }
        public String Descriere { get; set; }

        public int Id { get; set; }
    }
}