using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display.SDK
{
    [Serializable]
    public class Plug
    {
        //Kare, Daire gibi kullanıcının anlayacağı isim...

        [Required]
        public string Name { get; set; }
        //.dll dosyası nerede?
        public string Path { get; set; }
        //System.String gibi namespace ile birlikte class name:
        public string FullName { get; set; }

    }
}
