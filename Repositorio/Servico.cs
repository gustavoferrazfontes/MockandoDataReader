using System.Collections.Generic;
using System.Data;

namespace Repositorio
{
    public class Servico
    {

        private readonly IRepositorioCustomerADO _repositorio;
        public Servico(IRepositorioCustomerADO repositorio)
        {
            _repositorio = repositorio;
        }

        public List<Customer> ObterTodos()
        {
            List<Customer> lst = new List<Customer>();
            using (IDataReader item = _repositorio.ObterTodos())
            {
                lst.Add(new Customer((int)item["CustomerID"], (int)item["PersonID"], (int)item["StoreID"], (int)item["TerritoryID"], item["AccountNumber"].ToString()));
            }

            return lst;
        }
    }
}
