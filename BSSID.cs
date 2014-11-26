using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WifiReveal
{
    public class BSSID
    {
        private byte[] _data;

        public BSSID(byte[] address)
        {
            this._data = address;
        }

        public byte[] Address
        {
            get { return this._data; }
        }

        public String AdressString
        {
            get { return BitConverter.ToString(this._data).Replace("-", string.Empty).Replace(":", string.Empty); }
        }

        public Boolean SameManufacturer(byte[] dir)
        {
            return ((dir.Length >= 3) && (dir.Take<byte>(3).ToArray<byte>() == this._data.Take<byte>(3).ToArray<byte>()));
        }
    }
}
