using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Using_Interface
{
    class RegistraOcorrencia
    {
        private IRegistra Registra;
        public RegistraOcorrencia(IRegistra registra)
        {
            Registra = registra;
        }

        public void Registrar (string mensagem)
        {
            Registra.RegistraInfo(mensagem);
        }
    }
}
