using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Interface
{
     class RegistraNoDisco : IRegistra
    {
        private string NomeArquivo { get; set; }

        public RegistraNoDisco(string nomeArquivo)
        {
            NomeArquivo = nomeArquivo;
        }

        public void RegistraInfo(string mensagem)
        {
            using (StreamWriter arquivo = new StreamWriter(NomeArquivo))
            {
                arquivo.WriteLine(mensagem);
            }
        }
    }
}

