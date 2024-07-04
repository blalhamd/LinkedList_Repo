using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HahList
{
    internal class phones
    {
        private string name;
        private double price;

        public phones() { this.name = string.Empty; this.price = 0; }
        public phones(string name,double price) { this.name = name;this.price = price; }

        public override string ToString()
        {
            return "\t\tname: " + this.name + "\n\t\tprice: " + this.price + "\n";
        }

        public override bool Equals(object? obj)
        {
            if (obj == null) 
                return false;

            phones phone=(phones)obj;   
            return phone.name==this.name && phone.price==this.price;
        }

        public static bool operator==(phones phone1, phones phone2)=> phone1.Equals(phone2);
        public static bool operator !=(phones phone1, phones phone2) => !phone1.Equals(phone2);




    }
}
