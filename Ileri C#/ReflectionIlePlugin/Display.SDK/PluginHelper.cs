using System.Reflection;

namespace Display.SDK
{
    public static class PluginHelper
    {
        public static List<Plug> GetPlugs(string folderName)
        {
            if (string.IsNullOrEmpty(folderName))
            {
                throw new ArgumentNullException(nameof(folderName));
            }

            if (!Directory.Exists(folderName))
            {
                throw new FileNotFoundException("Belirtilen klasör bulunamadı", folderName);
            }

            List<Plug> plugs = GetPlugsInPath(folderName);
            return plugs;
        }

        /// <summary>
        /// Belirtilen klasör içerisindeki tüm pluginleri koleksiyon olarak döner.
        /// </summary>
        /// <param name="folderName"></param>
        /// <returns></returns>
        private static List<Plug> GetPlugsInPath(string folderName)
        {
            var dllFiles = Directory.GetFiles(folderName, "*.dll");
            var plugs = new List<Plug>();
            dllFiles?.ToList().ForEach(file => AddReference(file, plugs));
            return plugs;
        }

        /// <summary>
        /// Belirtilen .dll dosyasını projenin referanslarına ekler.
        /// </summary>
        /// <param name="file">Referans olarak eklenecek dll dosyası</param>
        /// <param name="plugs">Plugin'in ekleneceği koleksiyon</param>
        /// <exception cref="NotImplementedException"></exception>
        private static void AddReference(string file, List<Plug> plugs)
        {
            var assembly = Assembly.LoadFrom(file);
            var types = assembly.GetTypes();
            types?.ToList().ForEach(type =>
            {
                Plug plug = handShakeAppAndType(type, file);
                if (plug != null)
                {
                    plugs.Add(plug);
                }
            });
        }

        public static IPlug CreateInstance(Plug active)
        {
            Assembly assembly = Assembly.LoadFrom(active.Path);
            var instance = assembly.CreateInstance(active.FullName);
            return (IPlug)instance;
        }

        private static Plug handShakeAppAndType(Type type, string file)
        {
            Plug plug = null;
            if (type.GetInterface("IPlug") != null)
            {
                plug = new Plug();
                plug.Path = file;
                plug.FullName = type.FullName;

                dynamic instance = Activator.CreateInstance(type);
                //plug.Name = instance.GetType().GetProperty("Name").GetValue(instance).ToString();
                plug.Name = instance.Name;

            }
            return plug;
        }
    }
}
