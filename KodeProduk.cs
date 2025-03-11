using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace achmadFadjryAdlilFaqihModul4103022300159
{
    class KodeProduk
    {
        private Dictionary<string, string> kodeProdukTable = new Dictionary<string, string>
        {
            { "Laptop", "E100" },
            { "Smartphone", "E101" },
            { "Tablet", "E102" },
            { "Headset", "E103" },
            { "Keyboard", "E104" },
            { "Mouse", "E105" },
            { "Printer", "E106" },
            { "Monitor", "E107" },
            { "SmartWatch", "E108" },
            { "Kamera", "E109" },
        };
        public String GetKodeProduk(String inputProduk)
        {
            if (string.IsNullOrEmpty(inputProduk)) return "";

            inputProduk = inputProduk.ToLower();
            foreach (var produk in kodeProdukTable.Keys)
            {
                if (produk.ToLower() == inputProduk)
                {
                    return kodeProdukTable[produk];
                }
            }
            return "";
        }

    }
}

    

