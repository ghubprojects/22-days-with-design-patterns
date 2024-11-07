namespace AbstractFactory;

public class DBClient(IDBFactory factory) {
    private readonly IDBConnection _connection = factory.CreateConnection();
    private readonly IDBCommand _command = factory.CreateCommand();

    public void ExecuteQuery(string query) => _command.Execute(query, _connection);
}