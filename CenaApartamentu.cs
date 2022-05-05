using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelBiznes
{
    public class CenaApartamentu
    {
        public int ApartmentNumber { get; set; }
        public int ApartmentName { get; set; }
        public decimal ApartmentPrize { get; set; } // cena za noc + dodać rabaty + kalendarz wynajmu
        public double Discount { get; set; } //zniżka za wynajem

    }
}
