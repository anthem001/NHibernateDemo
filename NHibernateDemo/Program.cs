using System;
using System.Reflection;
using NHibernate.Cfg;
using NHibernate.Dialect;
using NHibernate.Driver;

namespace NHibernateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            /* NHibernate Config Object */
            var config = new Configuration();

            /* Configure Database Connection */
            config.DataBaseIntegration(c =>
                {
                    c.ConnectionString =
                        "Server=USER-09167EE968;Database=AdventureWorksLT2008R2;User Id=kelly;Password=test;";
                    c.Driver<SqlClientDriver>();
                    c.Dialect<MsSql2008Dialect>();
                });

            /* Get executing assembly to search for mapping files */
            config.AddAssembly(Assembly.GetExecutingAssembly());

            /* Compile Meta Data To Initialize NHibernate */
            var sessionConnection = config.BuildSessionFactory();

            /* Build a session (database connection) */
            using(var session = sessionConnection.OpenSession())

            /* Begin a new transaction */
            using (var transaction = session.BeginTransaction())
            {
                //run some database stuff
                var customers = session.CreateCriteria<Customers>().List<Customers>();

                //iterate through customers
                foreach (var customer in customers)
                {
                    Console.WriteLine("{0} {1} {2} {3}", customer.Title, customer.FirstName, customer.LastName, customer.Suffix);
                }

                //pause for view
                Console.ReadLine();
                //commit transaction
                transaction.Commit();
            }

        }
    }
}
