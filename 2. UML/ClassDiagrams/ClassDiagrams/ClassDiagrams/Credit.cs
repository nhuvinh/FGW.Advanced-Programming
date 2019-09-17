using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassDiagrams
{
    class Credit
    {
        string number;
        string type;
        DateTime expDate;
        public Boolean authorized()
        {
            return true;
        }
    }
}
