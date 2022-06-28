using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Display.SDK
{
    public static class PluginHelper
    {
        public static List<Plug> GetPlugs(string folderName)
        {
            if (!Directory.Exists(folderName))
            {
                throw new FileNotFoundException("Belirtilen klasör bulunamadı", folderName);
            }
            
            var files = Directory.GetFiles(folderName,"*.dll", SearchOption.AllDirectories);
        }
    }
}
