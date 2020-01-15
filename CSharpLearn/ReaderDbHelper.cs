using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Text;

namespace CSharpLearn
{
    class ReaderDbHelper
    {
        public const string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;
                                 Initial Catalog=Learn;Integrated Security=True;";
        private DbConnection longConnection;
        public DbConnection LongConnection
        {
            get
            {
                //if (connection==null)
                //{
                //    connection = new SqlConnection();
                //}
                //return connection;
#if MSSQL
                longConnection = longConnection ?? new SqlConnection(connectionString);
#elif MySQL
                 connection=connection??new MySqlConnection(connectionString);
#endif
                //connection.ConnectionString = connectionString;
                return longConnection;
            }
        }
        public int ExecuteNonQuery(string commandText, DbConnection connection,string name)
        {
            //using (connection)
            //{
            //if (connection.State == ConnectionState.Closed)
            //{
                connection.Open();
            //}
            //DbCommand command = new SqlCommand();
            //command.CommandText = commandText;
            //command.Connection = connection;
            DbCommand command = Execute(commandText, connection,name);
            return command.ExecuteNonQuery();
            //}
        }
        public object ExecuteScalar(string commandText,DbConnection connection,string name)
        {
            connection.Open();

            //DbCommand command = new SqlCommand();
            //command.CommandText = commandText;
            //command.Connection = connection;
            DbCommand command = Execute(commandText, connection,name);
            return command.ExecuteScalar();
        }

        public SqlDataReader ExecuteReader(string commandText, DbConnection connection,string name)
        {
            connection.Open();
            DbCommand command= Execute(commandText,connection,name);
            return (SqlDataReader)command.ExecuteReader();
        }

        private static DbCommand Execute(string commandText, DbConnection connection,string name)
        {
            DbCommand command = new SqlCommand();
            command.CommandText = commandText;
            command.Connection = connection;
            DbParameter pName = new SqlParameter("@Name", name);
            command.Parameters.Add(pName);
            return command;
        }
    }
}
