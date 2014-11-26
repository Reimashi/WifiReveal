using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WifiReveal
{
    public interface GeneratorPlugin
    {
        Boolean CanGenerate(WifiInfo info);
        String Generate(WifiInfo info);

        String Name { get; }
        Version Version { get; }
        String Author { get; }
        String WebPage { get; }
    }
}
