using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace null_UPDATE
{
    class Internet
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReverseedValue);

        public static bool BaglantiKontrol() //İnternet Kontrol
        {
            int Desc;
            return InternetGetConnectedState(out Desc, 0);
        }

        public static bool VersiyonKontrol(string versiyon,Uri url)
        {
            using (System.Net.WebClient wc_indir = new System.Net.WebClient())
            {
                string _versiyon = wc_indir.DownloadString(url);
                if(!string.IsNullOrEmpty(_versiyon))
                {
                    if(double.Parse(versiyon)>double.Parse(_versiyon))
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }
}
