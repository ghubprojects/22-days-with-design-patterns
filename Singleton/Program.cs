using Singleton;

var process1 = new Thread(() => {
    var singleton = DbContext.GetInstance("Foo");
    Console.WriteLine(singleton.Value);
});

var process2 = new Thread(() => {
    var singleton = DbContext.GetInstance("Bar");
    Console.WriteLine(singleton.Value);
});

process1.Start();
process2.Start();

process1.Join();
process2.Join();
