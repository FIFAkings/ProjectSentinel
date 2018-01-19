using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectSentinel
{
    public class Address
    {

        private string street, city, country;
        private ushort houseNumber;
        private uint zipcode;
        private ulong addressId;


        public Address(string str, string cty, string ctry, ushort numb, uint zip)
        {
            // this.addressId = Ovaj dio koda ću nadopuniti naknadno
            this.street = str;
            this.city = cty;
            this.country = ctry;
            this.houseNumber = numb;
            this.zipcode = zip;
        }

        public void changeAddress(string str, string cty, string ctry, ushort numb, uint zip)
        {
            this.street = str;
            this.city = cty;
            this.country = ctry;
            this.houseNumber = numb;
            this.zipcode = zip;
        }



    }
}
