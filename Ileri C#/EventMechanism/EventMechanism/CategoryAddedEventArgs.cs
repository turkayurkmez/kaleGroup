using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventMechanism
{
    //4. Olay meydana geldiğinde ihtiyaç duyduğum bilgiler neler:
    public class CategoryAddedEventArgs : EventArgs
    {
        public Category NewCategory { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedBy { get; set; }

    }
}
