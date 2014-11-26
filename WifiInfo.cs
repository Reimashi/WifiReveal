using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WifiReveal
{
    public class WifiInfo
    {
        private BSSID _bssid;
        private Byte[] _essid;

        public WifiInfo(byte[] BSSID, byte[] ESSID)
        {
            this._bssid = new BSSID(BSSID);
            this._essid = ESSID;
        }

        public BSSID BSSID
        {
            get { return this._bssid; }
        }

        public byte[] ESSID
        {
            get { return this._essid; }
        }

        public String Name
        {
            get { return Encoding.ASCII.GetString(this._essid).Trim((char)0x0).Trim(); }
        }
    }
}
