using System;
using MySql.Data.MySqlClient;

class Connection
{
    private string server;
    private string database;
    private string user;
    private string password;

    private MySqlConnection connection;

    public Connection(string server, string database, string user, string password)
    {
        // "Server=localhost;Database=test;Uid=usuario;Pwd=senha"
        this.server = server;
        this.database = database;
        this.user = user;
        this.password = password;
    }

    public void Connect()
    {
        if (this.connection != null && this.IsOpen())
        {
            Console.WriteLine("The connection is already open!");

            return;
        }

        string connectionUrl = $"Server={this.server};Database={this.database};Uid={this.user};Pwd={this.password}";

        connection = new MySqlConnection(connectionUrl);

        try
        {
            this.connection.Open();

            Console.WriteLine("Successfully connected!");
        }
        catch (MySqlException ex)
        {
            Console.WriteLine("Occurred an error while connecting to the database...");
            Console.WriteLine($"  Server: {this.server}");
            Console.WriteLine($"  Database: {this.database}\n");
            Console.WriteLine($"  Error: {ex}");
        }
    }

    public void Disconnect()
    {
        if (!IsOpen())
        {
            Console.WriteLine("The connection is not open!");

            return;
        }

        try
        {
            this.connection.Close();

            Console.WriteLine("Successfully disconnected!");
        }
        catch (MySqlException ex)
        {
            Console.WriteLine("Occurred an error while disconnecting to the database...");
            Console.WriteLine($"  Server: {this.server}");
            Console.WriteLine($"  Database: {this.database}\n");
            Console.WriteLine($"  Error: {ex}");
        }
    }

    public bool IsOpen()
    {
        return this.connection.State == System.Data.ConnectionState.Open;
    }

    public MySqlCommand Command(params string[] query)
    {
        MySqlCommand command = this.connection.CreateCommand();
        command.CommandText = String.Concat(query);

        return command;
    }

    public MySqlDataReader Execute(params string[] query)
    {
        MySqlCommand command = this.Command(query);

        Console.WriteLine($"Executing query: {String.Concat(query)}");

        return command.ExecuteReader();
    }

    public int ExecuteNonQuery(params string[] query)
    {
        MySqlCommand sqlCommand = this.Command(query);

        Console.WriteLine($"Executing non-query: {String.Concat(query)}");

        int affectedRows = -1;

        try
        {
            affectedRows = sqlCommand.ExecuteNonQuery();

            Console.WriteLine($"  Affected rows: {affectedRows}");
        }
        catch (MySqlException ex)
        {
            Console.WriteLine($"  Occurred an error: {ex}");
        }

        return affectedRows;
    }
}
