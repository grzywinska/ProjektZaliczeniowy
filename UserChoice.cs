using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary
{
    public class UserChoice
    {
        public List<PersonModel> User { get; set; } = new List<PersonModel>();
        public string UserName { get; set; }
        public string OwnerName { get; set; }
        /// <summary>
        /// Wersja passwd do rozbudowania - potrzebne do stworzenia logowania dla menagera. 
        /// </summary>
        public string Password { get; set; }
    }
}
