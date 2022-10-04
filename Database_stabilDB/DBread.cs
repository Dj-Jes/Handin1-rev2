namespace Database;
using System;
using Npgsql;


public class DBread
{
// Obtain connection string information from the portal
//
    private static string Host = DBlogin.Host ;
    private static string User = DBlogin.User;
    private static string Password = DBlogin.Password;
    private static string Port = DBlogin.Port;

static void Main(string[] args)
{
    // Build connection string using parameters from portal
    //
    string connString =
        String.Format(
            "Server={0}; User Id={1};  Port={2}; Password={3};SSLMode=Prefer",
            Host,
            User,
            Port,
            Password);

    using (var conn = new NpgsqlConnection(connString))
    {

        Console.Out.WriteLine("Opening connection");
        conn.Open();


        using (var command = new NpgsqlCommand("SELECT * FROM inventory", conn))
        {

            var reader = command.ExecuteReader();
            while (reader.Read())
            {
                Console.WriteLine(
                    string.Format(
                        "Reading from table=({0}, {1}, {2})",
                        reader.GetInt32(0).ToString(),
                        reader.GetString(1),
                        reader.GetInt32(2).ToString()
                    )
                );
            }
            reader.Close();
        }
    }

    Console.WriteLine("Press RETURN to exit");
    Console.ReadLine();
}
}
