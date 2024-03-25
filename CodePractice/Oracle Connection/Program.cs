
using Oracle.ManagedDataAccess.Client;

using System;

class Programe

{

    static void Main(string[] args)

    {

        // Configuration settings in JSON-like format

        var configuration = new

        {

            ConnectionStrings = new

            {

                OracleConnection = "User Id=your_username;Password=your_password;Data Source=your_tns_entry;"

            },

            OracleConfiguration = new

            {

                TnsAdminPath = @"C:\path_to_tnsnames_directory"

            }

        };

        string connectionString = configuration.ConnectionStrings.OracleConnection;

        string tnsAdminPath = configuration.OracleConfiguration.TnsAdminPath;

        // Set the TNS_ADMIN environment variable to the directory containing the tnsnames.ora file

        Environment.SetEnvironmentVariable("TNS_ADMIN", tnsAdminPath);

        // Create a new OracleConnection object with the connection string

        using (OracleConnection connection = new OracleConnection(connectionString))

        {

            try

            {

                // Open the connection

                connection.Open();

                Console.WriteLine("Connected to Oracle database.");

            }

            catch (Exception ex)

            {

                Console.WriteLine("Error connecting to Oracle database: " + ex.Message);

            }

        }

    }

}