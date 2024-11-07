using Prototype;

var originalPerson = new Person {
    Name = "Steve Doe",
    Age = 21,
    Address = new() {
        Street = "123 Main St.",
        City = "Anytown",
        State = "AB"
    }
};
var shallowPerson = originalPerson.ShallowCopy();
var deepPerson = originalPerson.DeepCopy();

originalPerson.Name = "Jack Swallow";
originalPerson.Address.Street = "456 Elmo St.";

Console.WriteLine($"Original Name: {originalPerson.Name} - Original Street: {originalPerson.Address.Street}");
Console.WriteLine($"Shallow Name: {shallowPerson.Name} - Shallow Street: {shallowPerson.Address.Street}");
Console.WriteLine($"Deep Name: {deepPerson.Name} - Deep Street: {deepPerson.Address.Street}");
