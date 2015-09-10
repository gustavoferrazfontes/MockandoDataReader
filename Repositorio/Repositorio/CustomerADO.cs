using System;
using System.Collections.Generic;
using System.Data;

namespace Repositorio
{
    public class CustomerADO : EntLibBase, IRepositorioCustomerADO
    {
        List<Customer> lstCustomer = new List<Customer>();
        public IDataReader ObterTodos()
        {
            string query = "Select top 10 * from Costumer";
            return Conexao.ExecuteReader(CommandType.Text, query);
        }
    }
}
