using Prueba_azteca.Model;
using System;
using System.Collections.Generic;
using System.Data.OracleClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba_azteca.Data
{
    public class Database
    {
        private string Connectionstring = ("DATA SOURCE = toronto_TVADESA; PASSWORD=toronto_2009;USER ID = toronto");

        public List<Customer> GetCustomers()
        {
            List<Customer> customers = new List<Customer>();
            using (OracleConnection conn = new OracleConnection(Connectionstring))

            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM CUS_CUSTOMERS_M WHERE STA_ID = 11", conn))
                {
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            customers.Add(new Customer
                            {
                                CUS_ID = reader.GetInt32(0),
                                CUS_SHORT_NAME = reader.GetString(1),
                                CUS_NAME = reader.GetString(2),
                                STA_ID = reader.GetInt32(3)
                            });
                        }
                    }
                }
            }
            return customers;
        }

        public List<Contract> GetContracts(int CUS_ID)
        {
            List<Contract> contracts = new List<Contract>();
            using (OracleConnection conn = new OracleConnection(Connectionstring))
            {
                conn.Open();
                using (OracleCommand cmd = new OracleCommand("SELECT * FROM CON_CONTRACTS_M WHERE CUS_ID = :customerId", conn))
                {
                    cmd.Parameters.Add(new OracleParameter(":customerId", CUS_ID));
                    using (OracleDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            contracts.Add(new Contract
                            {
                                CUS_ID = reader.GetInt32(0),
                                CON_ID = reader.GetInt32(1),
                                CON_SHORT_NAME = reader.GetString(2),
                                STA_ID = reader.GetInt32(3),
                                CON_AMOUNT = reader.GetDecimal(4),
                                CON_NAME = reader.GetString(5),
                                CON_BEGIN_DATE = reader.GetDateTime(6)
                            });

                        }
                    }
                }
            }
            return contracts;
        }
    }
}
