using System;
using System.Collections.Generic;
using System.Text;
//using System.Data.SqlClient;

namespace FoodEmperor.Model
{
    class pizzadb
    {
        //[PrimaryKey]
        public string Klucz { get; set; }
        public string NazwaPizzy { get; set; }
        public string CenaMalej { get; set; }
        public string CenaSredniej { get; set; }
        public string CenaDuzej { get; set; }
    }
}
