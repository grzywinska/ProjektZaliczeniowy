using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary
{
    public class ModelRezerwacji
    {
        //public string NazwaApartamentu { get; set; }
        public decimal Zaliczka { get; set; }
        public List<Uzytkownik> Klient { get; set; } = new List<Uzytkownik>();
        public List<CenaApartamentu> Cena { get; set; } = new List<CenaApartamentu>();

    }
}
