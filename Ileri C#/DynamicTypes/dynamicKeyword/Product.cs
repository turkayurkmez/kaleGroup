using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dynamicKeyword
{
    public class Product
    {

        public dynamic DataSource { get; set; }

        public dynamic GetSource()
        {
            return new string[] {"A","B","C"};
        }
    }
}
