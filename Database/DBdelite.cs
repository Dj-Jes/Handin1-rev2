using Npgsql;

namespace Database;

public class DBdelite
{ // Obtain connection string information from the portal
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
                "Server={0}; User Id={1}; Port={2}; Password={3};SSLMode=Prefer",
                Host,
                User,
                Port,
                Password);

        using (var conn = new NpgsqlConnection(connString))
        {
            Console.Out.WriteLine("Opening connection");
            conn.Open();

            using (var command = new NpgsqlCommand("DELETE FROM inventory WHERE name = @n", conn))
            {
                command.Parameters.AddWithValue("n", "orange");

                int nRows = command.ExecuteNonQuery();
                Console.Out.WriteLine(String.Format("Number of rows deleted={0}", nRows));
            }
        }

        Console.WriteLine("Press RETURN to exit");
        Console.ReadLine();
    }
}