using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace projektzaginione.Models
{
    public class LosePeople
    {
        public int Id { get; set; }

        public string Imie { get; set; }

        public string Nazwisko { get; set; }

        public int Wiek { get; set; }

        public string Opis { get; set; }
        [DisplayName("Data zaginiecia")]
        public string Data_zaginiecia { get; set; }
        [DisplayName("Znaki szczegolne")]
        public string Znaki_szczegolne { get; set; }

        public string Lokalizacja { get; set; }

    }
}