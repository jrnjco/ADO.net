using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conntecting to DB");
            SqlConnection conObj = new SqlConnection(@"data source = DESKTOP-BEM16JA;database=AdventureWorks2012;Trusted_Connection=True;");
            Console.WriteLine(conObj.State);
            conObj.Open();
            Console.WriteLine(conObj.State);
        }
    }
}
