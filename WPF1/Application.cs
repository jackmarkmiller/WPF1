using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1
{
    class Apps
    {
        public string Name { set; get; }
        public string Address { set; get; }
        public int ZipCode { set; get; }

        public Apps ()
        {
            Name = "";
            Address = "";
            ZipCode = 0;
        }

        public Apps (string name, string address, int zipCode)
        {
            Name = name;
            Address = address;
            ZipCode = zipCode;

        }
        public override string ToString()
        {
            return Name + " lives at " + Address + "," + ZipCode;
        }
    }

}

