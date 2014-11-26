using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WifiReveal
{
    class GeneratorsManager
    {
        private static GeneratorsManager instance = null;

        private List<GeneratorPlugin> _plugins = new List<GeneratorPlugin>();

        private GeneratorsManager()
        {
            List<GeneratorPlugin> potentialPlugins = new List<GeneratorPlugin>();

            // Cargamos los plugins locales
            var plugl = from t in System.Reflection.Assembly.GetExecutingAssembly().GetTypes() where (t.IsClass && !t.IsAbstract && t.GetInterface(typeof(GeneratorPlugin).Name) != null) select ((GeneratorPlugin)Activator.CreateInstance(t));
            potentialPlugins.AddRange(plugl);

            // Cargamos la carpeta de plugins
            try
            {
                String[] files = Directory.GetFiles(Environment.CurrentDirectory + "\\generators", @"*.dll", SearchOption.TopDirectoryOnly);
                foreach (String file in files)
                {
                    try
                    {
                        var plug = from t in System.Reflection.Assembly.LoadFrom(file).GetTypes() where (t.IsClass && !t.IsAbstract && t.GetInterface(typeof(GeneratorPlugin).Name) != null) select ((GeneratorPlugin)Activator.CreateInstance(t));
                        potentialPlugins.AddRange(plug);
                    }
                    catch (Exception)
                    {
                        System.Diagnostics.Debug.WriteLine("Error while load " + file + " plugin file.");
                    }
                }
            }
            catch (Exception)
            {
                System.Diagnostics.Debug.WriteLine("Can't load the plugins.");
            }

            // Elegimos los plugins
            foreach (GeneratorPlugin pl in potentialPlugins)
            {
                bool add = true;
                GeneratorPlugin oldPlug = null;

                foreach (GeneratorPlugin pl2 in this._plugins)
                {
                    if (pl.Name == pl2.Name)
                    {
                        if (pl.Version > pl2.Version)
                            oldPlug = pl2;
                        else
                            add = false;
                    }
                }

                if (oldPlug != null)
                    this._plugins.Remove(oldPlug);

                if (add)
                    this._plugins.Add(pl);
            }
        }

        public Boolean CanGenerate(WifiInfo info)
        {
            foreach (GeneratorPlugin pl in this._plugins)
            {
                if (pl.CanGenerate(info))
                    return true;
            }

            return false;
        }

        public String Generate(WifiInfo info)
        {
            foreach (GeneratorPlugin pl in this._plugins)
            {
                if (pl.CanGenerate(info))
                    return pl.Generate(info);
            }

            return String.Empty;
        }

        public static GeneratorsManager Instance
        {
            get
            {
                if (instance == null)
                    instance = new GeneratorsManager();
                return instance;
            }
        }

        public List<GeneratorPlugin> Plugins
        {
            get { return this._plugins; }
        }
    }
}
