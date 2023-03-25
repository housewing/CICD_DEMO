using System.Data;
using Microsoft.Data.SqlClient;
using Dapper;

namespace gitlab_demo.Models
{
    public class CustomerModel : ICustomerModel
    {
        private readonly IConfiguration _configuration;

        public CustomerModel(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<Customer> GetCustomers()
        {
            List<Customer> customers;
            using (SqlConnection conn = new SqlConnection(_configuration.GetConnectionString("DefaultConnection")))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }

                string strSql = "SELECT * FROM Customer";
                customers = conn.Query<Customer>(strSql).ToList();
            }

            //var customers = new List<Customer>()
            //{
            //    new Customer()
            //    {
            //        Id = 1,
            //        CusId = "123",
            //        CusName = "qwe"
            //    },
            //    new Customer()
            //    {
            //        Id = 2,
            //        CusId = "456",
            //        CusName = "asd"
            //    },
            //    new Customer()
            //    {
            //        Id = 3,
            //        CusId = "789",
            //        CusName = "zxc"

            //    }
            //};
            return customers;
        }
    }
}
