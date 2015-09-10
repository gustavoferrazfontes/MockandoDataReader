using System.Collections.Generic;
using System.Data;

namespace Repositorio
{
    public interface IRepositorioCustomerADO
    {
        IDataReader ObterTodos();
    }
}
