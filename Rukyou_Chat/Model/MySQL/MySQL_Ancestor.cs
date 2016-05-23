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

            using (connection = new MySqlConnection())
                try
                {
                    connection.ConnectionString = connectionString;
                    connection.Open();
                    connection.Close();
                    connection.Dispose();
                }
                catch (MySqlException Erreur)
                {
                    connection.Dispose();
                    OK = false;
                    throw new System.Exception(Erreur.Message);
                }
                catch (Exception Erreur)
                {
                    connection.Dispose();
                    OK = false;
                    throw new System.Exception(Erreur.Message);
                }
                finally
                {
                    if (connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }
                }
            return (OK);
        }

        public DataTable runQuery(string sql, List<MySqlParameter> paramList)
        {
            DataTable table = new DataTable();

            connection = new MySqlConnection();
            command = new MySqlCommand();
            adapter = new MySqlDataAdapter();
            try
            {
                connection.ConnectionString = connectionString;
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
                connection.Dispose();
            }
            catch (MySqlException Erreur)
            {
                throw new System.Exception(Erreur.Message);
            }
            catch (Exception Erreur)
            {
                throw new System.Exception(Erreur.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
            return (table);
        }

        public void runNonQuery(string sql, List<MySqlParameter> paramList)
        {
            connection = new MySqlConnection();
            command = new MySqlCommand();
            try
            {
                connection.ConnectionString = connectionString;
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

                connection.Dispose();
            }
            catch (MySqlException Erreur)
            {
                throw new Exception(Erreur.Message);
            }
            catch (Exception Erreur)
            {
                throw new Exception(Erreur.Message);
            }
            finally
            {
                if (connection.State == ConnectionState.Open)
                {
                    connection.Close();
                }
            }
        }
    }
}
