namespace Facade;

public class ComputerFacade {
    private readonly CPU cpu;
    private readonly Memory memory;
    private readonly HardDrive hardDrive;

    public ComputerFacade() {
        cpu = new CPU();
        memory = new Memory();
        hardDrive = new HardDrive();
    }

    public void StartComputer() {
        cpu.Start();
        memory.Initialize();

        if (hardDrive.FindBootSector()) {
            hardDrive.ReadBootSector();
            cpu.ExecuteBootLoader();
            memory.LoadOS();
            Console.WriteLine("Computer has started successfully.");
        } else {
            Console.WriteLine("Error: Boot sector not found!");
        }
    }
}