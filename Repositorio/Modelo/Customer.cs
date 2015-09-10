namespace Repositorio
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public int PersonID { get; set; }
        public int StoreID { get; set; }
        public int TerritoryID { get; set; }
        public string AccountNumber { get; set; }

        public Customer(int customerID, int personID, int storeID, int territoryID, string accountNumber)
        {
            CustomerID = customerID;
            PersonID = personID;
            StoreID = storeID;
            TerritoryID = territoryID;
            AccountNumber = accountNumber;

        }
    }
}