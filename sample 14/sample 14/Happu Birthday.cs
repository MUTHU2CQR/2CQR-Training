using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sample_14
{
    class Happybirthday
    {
        public string getMessage(string name)
        {
            return "happy birthday"+name;
        }
        private string birthdaywishes;

        public string  MyProperty
        {
            get { return birthdaywishes; }
            set {  birthdaywishes=value; }
        }

    }
   

}
