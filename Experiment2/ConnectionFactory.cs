using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Experiment2
{
    class ConnectionFactory
    {
        private static SqlConnection sqlConnection = new SqlConnection();
        private static string sqlConnectionString = new Resources().getDatabaseConnectionString();

        public static IDbConnection OpenConnection() {

            try {
                if (sqlConnection.State != System.Data.ConnectionState.Open) {
                    sqlConnection = new SqlConnection(sqlConnectionString);
                    sqlConnection.Open();
                }
                return sqlConnection;
            }
            catch (Exception e) {
                throw e;
            }
        }


        public static IDbConnection CloseConnection() {
            try
            {
                if (sqlConnection.State == System.Data.ConnectionState.Open)
                {
                    sqlConnection.Close();
                }
                return sqlConnection;
            }
            catch (Exception e)
            {
                throw e;
            }

            }
        }


    }



