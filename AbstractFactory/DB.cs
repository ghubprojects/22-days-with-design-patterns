namespace AbstractFactory;

public interface IDBConnection {
    void Open();
    void Close();
}

public interface IDBCommand {
    void Execute(string query, IDBConnection conn);
}

public class SQLServerDBConnection : IDBConnection {
    public void Open() => Console.WriteLine("Connected to SQL Server database");
    public void Close() => Console.WriteLine("Closed connection to SQL Server database");
}

public class SQLServerDBCommand : IDBCommand {
    public void Execute(string query, IDBConnection conn) {
        conn.Open();
        Console.WriteLine($"Executing SQL Server query: {query}");
        conn.Close();
    }
}

public class PostgresDBConnection : IDBConnection {
    public void Open() => Console.WriteLine("Connected to Postgres database");
    public void Close() => Console.WriteLine("Closed connection to Postgres database");
}

public class PostgresDBCommand : IDBCommand {
    public void Execute(string query, IDBConnection conn) {
        conn.Open();
        Console.WriteLine($"Executing Postgres query: {query}");
        conn.Close();
    }
}