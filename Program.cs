using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using achmadFadjryAdlilFaqihModul4103022300159;

namespace achmadFadjryAdlilFaqihModul4103022300159;

class MainClass
{
    static void Main()
    {
        KodeProduk kodeProdukObj = new KodeProduk();

        Console.WriteLine("Masukkan nama produk");
        string input = Console.ReadLine()?.Trim() ?? "";

        string kode = kodeProdukObj.GetKodeProduk(input);

        if (kode != "")
        {
            Console.WriteLine($"Kode Produk dari {input} adalah {kode}");
        } else
        {
            Console.WriteLine("Kode Produk tidak di temukan.");
        }


    }

}
