using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using WifiReveal;

namespace WifiReveal.Generators
{
    public class WlanxxxxGenerator : WifiReveal.GeneratorPlugin
    {
        private static String _name = "Wlan_XXXX";
        private static Version _version = new Version(0, 1);
        private static String _author = "Reimashi";
        private static String _webpage = "http://github.com/Reimashi";

        public String Name { get { return _name; } }
        public Version Version { get { return _version; } }
        public String Author { get { return _author; } }
        public String WebPage { get { return _webpage; } }

        public Boolean CanGenerate(WifiInfo info)
        {
            return (info.Name.ToUpperInvariant().StartsWith("WLAN_") && info.Name.Length == 9);
        }

        public String Generate(WifiInfo info)
        {
            MD5CryptoServiceProvider md5encripter = new MD5CryptoServiceProvider();
            String password = String.Empty;

            // Si es un ZyXEL
            if (info.BSSID.SameManufacturer(new byte[] { 0x00, 0x13, 0x49 }) ||
                info.BSSID.SameManufacturer(new byte[] { 0x00, 0x19, 0xcb }) ||
                info.BSSID.SameManufacturer(new byte[] { 0x00, 0xa0, 0xc5 }) ||
                info.BSSID.SameManufacturer(new byte[] { 0x40, 0x4a, 0x03 }) ||
                info.BSSID.SameManufacturer(new byte[] { 0x50, 0x67, 0xf0 }) ||
                info.BSSID.SameManufacturer(new byte[] { 0xb0, 0xb2, 0xdc }) ||
                info.BSSID.SameManufacturer(new byte[] { 0xc8, 0x6c, 0x87 }) ||
                info.BSSID.SameManufacturer(new byte[] { 0xcc, 0x5d, 0x4e }) ||
                info.BSSID.SameManufacturer(new byte[] { 0xec, 0x43, 0xf6 }) ||
                info.BSSID.SameManufacturer(new byte[] { 0xfc, 0xf5, 0x28 }) ||
                info.BSSID.SameManufacturer(new byte[] { 0x00, 0x23, 0xf8 }))
            {
                byte[] tohash = ASCIIEncoding.Default.GetBytes((info.BSSID.AdressString.Substring(0, 8) + info.Name.Substring(info.Name.Length - 4, 4)).ToLowerInvariant());
                password = BitConverter.ToString(md5encripter.ComputeHash(tohash)).Replace("-", string.Empty).Replace(":", string.Empty).Substring(0, 20).ToUpperInvariant();
            }
            else
            {
                byte[] tohash = ASCIIEncoding.Default.GetBytes("bcgbghgg" + ((info.BSSID.AdressString.Substring(0, 8) + info.Name.Substring(info.Name.Length - 4, 4)) + info.BSSID.AdressString).ToUpperInvariant());
                password = BitConverter.ToString(md5encripter.ComputeHash(tohash)).Replace("-", string.Empty).Replace(":", string.Empty).Substring(0, 20).ToLowerInvariant();
            }

            return password;
        }
    }
}
