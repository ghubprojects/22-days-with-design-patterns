namespace Facade;

public class CPU {
    public void Start() => Console.WriteLine("CPU is starting...");
    public void ExecuteBootLoader() => Console.WriteLine("CPU is executing the boot loader...");
}

public class Memory {
    public void Initialize() => Console.WriteLine("Memory is initializing...");
    public void LoadOS() => Console.WriteLine("Loading operating system into memory...");
}

public class HardDrive {
    public void ReadBootSector() => Console.WriteLine("Reading boot sector...");
    public bool FindBootSector() {
        Console.WriteLine("Searching for boot sector...");
        return true; // Assuming the boot sector has been found
    }
}