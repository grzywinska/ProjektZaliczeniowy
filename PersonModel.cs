using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelLibrary
{
    public class PersonModel
    {
        /// <summary>
        /// Dane które pobiera od użytkownika będącego potencjalnym gościem hotelu.
        /// </summary>
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public string CellphoneNumber { get; set; }

    }
}
