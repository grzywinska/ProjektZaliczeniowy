using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary
{
    public class Uzytkownik
    {
        public List<PersonModel> Member { get; set; } = new List<PersonModel>();
        public string MemberName { get; set; }
    }
}
