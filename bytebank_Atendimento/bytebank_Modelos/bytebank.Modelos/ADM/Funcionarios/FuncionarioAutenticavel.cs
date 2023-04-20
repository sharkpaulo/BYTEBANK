using bytebank.Modelos.ADM.SistemaInterno;
using bytebank_Modelos.bytebank.Modelos.ADM.Utilitario;

namespace bytebank.Modelos.ADM.Funcionarios
{
    public abstract class FuncionarioAutenticavel : Funcionario, IAutenticavel
    {
        public string Senha { get; set; }

        public FuncionarioAutenticavel(double salario, string cpf)
            : base(salario, cpf)
        {

        }

        private AutenticavelUtil autentificador = new AutenticavelUtil();
        public bool Autenticar(string senha)
        {
            
            return autentificador.AutenticacaoUtil(Senha, senha);
        }
    }
}
