using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using achmad_fadjry_adlil_faqih_modul4_103022300159;
using achmadFadjryAdlilFaqihModul4103022300159;

namespace achmadFadjryAdlilFaqihModul4103022300159;

class MainClass
{
    static void Main()
    {
        KodeProduk kodeProdukObj = new KodeProduk();
        FanLaptop mode = new FanLaptop();

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

        Console.WriteLine("\n============= Simulasi mode==============");

         string command;
        do
        {
            Console.WriteLine("\nPilih Mode(Turbo/Balanced/Quiet):");
            command = Console.ReadLine()?.Trim().ToLower() ?? "";

            if (command == "Turbo")
            {
                mode.ModeTurbo();

            }
            else if (command == "balanced")
            {
                mode.ModeBalanced();
            }
        } while (command!= "Quiet");

        Console.WriteLine("mode menjadi Quiet");
        }
        
    }


