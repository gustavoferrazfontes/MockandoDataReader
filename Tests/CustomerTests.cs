using Moq;
using NBehave.Spec.NUnit;
using NUnit.Framework;
using Repositorio;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Tests
{
    public class DadoUmCustomer : SpecBase
    {
        protected Mock<IDataReader> _mockDataReader;
        protected Mock<IRepositorioCustomerADO> _mockRepositorioCustomer;

        protected override void Establish_context()
        {
            _mockDataReader = new Mock<IDataReader>();
            _mockRepositorioCustomer = new Mock<IRepositorioCustomerADO>();
        }
    }

    public class QuandoForObterTodosOsRegistros : DadoUmCustomer
    {
        bool pronto = true;
        List<Customer> actual;
        Servico servico;

        protected override void Establish_context()
        {
            base.Establish_context();
            servico = new Servico(_mockRepositorioCustomer.Object);
            _mockDataReader.Setup(_ => _.Read()).Returns(() => pronto).Callback(() => pronto = false);
            _mockDataReader.Setup(_ => _["CustomerID"]).Returns(1);
            _mockDataReader.Setup(_ => _["PersonID"]).Returns(1);
            _mockDataReader.Setup(_ => _["StoreID"]).Returns(1);
            _mockDataReader.Setup(_ => _["TerritoryID"]).Returns(1);
            _mockDataReader.Setup(_ => _["AccountNumber"]).Returns("XPTO1234");

            _mockRepositorioCustomer.Setup(_ => _.ObterTodos()).Returns(_mockDataReader.Object);
        }



        protected override void Because_of()
        {
            base.Because_of();
            actual = servico.ObterTodos();
        }



        [Test]
        public void EntaoGarantoQueUmaListaDeCustomerRetorne()
        {
            actual.Count().ShouldBeGreaterThan(0);
        }
    }
}
