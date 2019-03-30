using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data.SqlClient;

namespace poprawiony_dapperek
{
   public class Pracownik
    {
        
        public int id { get; set; }
        public string imie { get; set; }
        public string nazwisko { get;  set; }
        
    }
}
