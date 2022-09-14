using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Interface
{
     class RegistraConsole : IRegistra
    {
        public void RegistraInfo(string mensagem)
        {
            //Console.WriteLine("Mensagem no console:");
            Console.WriteLine(mensagem);
            Console.ReadKey();
        }
    }
}
