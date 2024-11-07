using AbstractFactory;

while (true) {
    Console.Write("Enter the type of DB you want to use (SQL Server/Postgres): ");
    var type = (Console.ReadLine() ?? string.Empty).ToLower();
    Console.Write("Enter the SQL query: ");
    var query = Console.ReadLine() ?? string.Empty;

    IDBFactory factory = type switch {
        "sql server" => new SQLServerFactory(),
        "postgres" => new PostgresFactory(),
        _ => throw new Exception("Invalid DB type"),
    };

    var dbClient = new DBClient(factory);
    dbClient.ExecuteQuery(query);

    Console.WriteLine("\n");
    Thread.Sleep(100);
}