using Microsoft.Practices.EnterpriseLibrary.Data;

namespace Repositorio
{
    public class EntLibBase
    {
        public Database Conexao
        {
            get
            {
                return new DatabaseProviderFactory().Create("adventureWorks");
            }
        }
    }
}
