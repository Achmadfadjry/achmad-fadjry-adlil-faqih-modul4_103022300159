using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace achmad_fadjry_adlil_faqih_modul4_103022300159
{
    class FanLaptop
    {
        public enum State { Turbo, balanced }
        public State currentState;

        public FanLaptop()
        {
            currentState = State.Turbo;
            Console.WriteLine("Mode Turbo");

        }

        public void ModeTurbo()
        {
            if (currentState == State.Turbo)
            {
                currentState = State.balanced;
                Console.WriteLine("Mode belum di ubah");
            }
            else
            {
                Console.WriteLine("Mode sudah di ubah menjadi turbo");
            }
        
        }
            public void ModeBalanced()
        {
            if (currentState == State.balanced)
            
                {
                    currentState = State.Turbo;
                    Console.WriteLine("Mode belum di ubah");
                } else
                {
                    Console.WriteLine("Mode sudah di ubah menjadi balanced");
                }
            }
        }
    }

