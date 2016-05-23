using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;

namespace Rukyou_Chat.Model.MySQL
{
    abstract class MySQL_Ancestor
    {

        protected string connectionString;
        protected MySqlConnection connection;
        protected MySqlCommand command;
        protected MySqlDataAdapter adapter;
        protected CommandType type;

        public MySQL_Ancestor(string connString, CommandType Type)
        {
            connectionString = connString;
            type = Type;
            verify();
        }

        public bool verify()
        {
            bool OK = true;

            using (connection = new MySqlConnection(connectionString))
                try
                {
                    connection.Open();
                }
                catch (MySqlException err)
                {
                    OK = false;
                    throw new System.Exception(err.Message);
                }
                catch (Exception err)
                {
                    OK = false;
                    throw new System.Exception(err.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            return (OK);
        }

        public DataTable runQuery(string sql, List<MySqlParameter> paramList)
        {
            DataTable table = new DataTable();

            command = new MySqlCommand();
            adapter = new MySqlDataAdapter();
            using (connection = new MySqlConnection(connectionString))
                try
                {
                    command.Connection = connection;
                    command.CommandText = sql;
                    command.CommandType = type;

                    foreach (MySqlParameter LeParam in paramList)
                    {
                        command.Parameters.Add(LeParam);
                    }

                    adapter.SelectCommand = command;
                    connection.Open();
                    adapter.Fill(table);
                    connection.Close();
                }
                catch (MySqlException err)
                {
                    throw new System.Exception(err.Message);
                }
                catch (Exception err)
                {
                    throw new System.Exception(err.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
            return (table);
        }

        public void runNonQuery(string sql, List<MySqlParameter> paramList)
        {
            command = new MySqlCommand();
            using (connection = new MySqlConnection(connectionString))
                try
                {
                command.Connection = connection;
                command.CommandText = sql;
                command.CommandType = type;

                foreach (MySqlParameter LeParam in paramList)
                {
                    command.Parameters.Add(LeParam);
                }

                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
                }
                catch (MySqlException err)
                {
                    throw new Exception(err.Message);
                }
                catch (Exception err)
                {
                    throw new Exception(err.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                        connection.Close();
                }
        }
    }
}
