using CocoFarm.DataAccess;
using System.Collections.Generic;

namespace CocoFarm.Models
{
    public class Produs : IEntityWithId
    {
        public int Id { get; set; }
        public string Denumire { get; set; }
        public string Cod { get; set; }
        public string Descriere { get; set; }
        public decimal Pret { get; set; }
        public List<ProprietateValoare> Proprietati { get; set; }

        public Produs()
        {
            Id = 0;
            Denumire = "";
            Cod = "";
            Descriere = "";
            Pret = 0;
            Proprietati = new List<ProprietateValoare>();
        }
    }
}