using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Interface
{ 
    class Program
    {
      static void Main(string[] args)
    {
            RegistraOcorrencia regConsole = new RegistraOcorrencia(new RegistraConsole());
            regConsole.Registrar("Mesangem no console");

            RegistraOcorrencia regDisco = new RegistraOcorrencia(new RegistraNoDisco(@"C:\Users\Jean\Desktop\Nova pasta"));
            regDisco.Registrar("Mesangem no disco");

            Console.ReadKey();
    }

    }


}