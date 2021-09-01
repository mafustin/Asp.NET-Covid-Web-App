using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Covid19WebApp.Models
{
    public class Covid
    {
        public int Id { get; set; }
        public int Oib { get; set; }
        public string ImePrezime { get; set; }
        public string rezultatiTesta { get; set; }

        public Covid()
        {

        }
    }
}
