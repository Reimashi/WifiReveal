using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;

namespace WifiReveal.Generators
{
    public class JazztelxxxxGenerator : WifiReveal.GeneratorPlugin
    {
        private static String _name = "Jazztel_XXXX";
        private static Version _version = new Version(0, 1);
        private static String _author = "Reimashi";
        private static String _webpage = "http://github.com/Reimashi";

        public String Name { get { return _name; } }
        public Version Version { get { return _version; } }
        public String Author { get { return _author; } }
        public String WebPage { get { return _webpage; } }

        public Boolean CanGenerate(WifiInfo info)
        {
            return (info.Name.ToUpperInvariant().StartsWith("JAZZTEL_") && info.Name.Length == 12);
        }

        public String Generate(WifiInfo info)
        {
            WlanxxxxGenerator gen = new WlanxxxxGenerator();
            return gen.Generate(info);
        }
    }
}
