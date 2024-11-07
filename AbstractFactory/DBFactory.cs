namespace AbstractFactory;

public interface IDBFactory {
    IDBConnection CreateConnection();
    IDBCommand CreateCommand();
}

public class SQLServerFactory : IDBFactory {
    public IDBConnection CreateConnection() => new SQLServerDBConnection();
    public IDBCommand CreateCommand() => new SQLServerDBCommand();
}

public class PostgresFactory : IDBFactory {
    public IDBConnection CreateConnection() => new PostgresDBConnection();
    public IDBCommand CreateCommand() => new PostgresDBCommand();
}