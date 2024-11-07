using System.Text.Json;

namespace Prototype;

public class Person {
    public required string Name { get; set; }
    public required int Age { get; set; }
    public required Address Address { get; set; }

    public Person ShallowCopy() => (Person)MemberwiseClone();

    public Person DeepCopy() => JsonSerializer.Deserialize<Person>(JsonSerializer.Serialize(this)) ?? throw new InvalidOperationException("Deserialization returned null");
}

public class Address {
    public required string Street { get; set; }
    public required string City { get; set; }
    public required string State { get; set; }
}