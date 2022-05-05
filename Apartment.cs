using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary
{
    public class Apartment
    {
        public List<ModelRezerwacji> NazwaApartamentu { get; set; } = new List<ModelRezerwacji> { };
        public List<IloscMiejsc> LiczbaMiejsc { get; set; } = new List<IloscMiejsc>();

    }
}
