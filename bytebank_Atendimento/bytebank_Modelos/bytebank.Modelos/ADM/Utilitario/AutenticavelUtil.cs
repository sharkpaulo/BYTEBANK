using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bytebank_Modelos.bytebank.Modelos.ADM.Utilitario
{
    internal class AutenticavelUtil
    {
        public bool AutenticacaoUtil(string senhaVerdadeira,string senhaTentativa)
        {
            return senhaTentativa.Equals(senhaVerdadeira);
        }
    }
}
