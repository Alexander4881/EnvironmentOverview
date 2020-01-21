using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace EnvironmentOverview.Model.Classes
{
    public class Database
    {
        // Attrbutes
        private static readonly object Instancelock = new object();
        private static Database instance = null;
        private static SqlConnection sqlConnection;

        // Properties
        public static Database GetInstance
        {
            get
            {
                if (instance == null)
                {
                    lock (Instancelock)
                    {
                        if (instance == null)
                        {
                            instance = new Database();
                        }
                    }
                }
                return instance;
            }

        }
        private static SqlConnection SqlConnection { get => sqlConnection; set => sqlConnection = value; }

        // Constructor
        private Database() 
        {
            SqlConnection = new SqlConnection();
        }

        // Methods
        /// <summary>
        /// open the sql connection to the database
        /// </summary>
        public void Open()
        {

        }

        /// <summary>
        /// close the sql connection to the database
        /// </summary>
        public void Close() 
        { 
        }

        /// <summary>
        /// Execute a Non Query to the database
        /// </summary>
        /// <param name="sqlCommand"> the sql command to execute </param>
        public void ExecuteNonQuery(SqlCommand sqlCommand)
        {

        }

        /// <summary>
        /// Execute a Query to the database
        /// </summary>
        /// <param name="sqlCommand"> the sql command to execute </param>
        /// <returns></returns>
        public DataSet ExecuteQuery(SqlCommand sqlCommand)
        {
            throw null;
        }
    }
}
