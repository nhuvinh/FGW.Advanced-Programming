using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    class SimpleCoffee : ICoffee
    {
        public int GetCost()
        {
            return 5;
        }

        public string GetDescription()
        {
            return "Simple Coffee";
        }
    }
}
