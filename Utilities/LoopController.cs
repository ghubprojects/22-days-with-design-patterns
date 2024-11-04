namespace Utilities;

using System;
using System.Threading;

public class LoopController(Action action, int delayMilliseconds = 100) {
    private readonly Action _action = action;
    private readonly int _delayMilliseconds = delayMilliseconds;

    public void StartLoop() {
        Console.WriteLine("Press ESC to exit the program.");

        while (true) {
            // Execute the specified action in each iteration
            _action.Invoke();

            // Check if ESC key is pressed to break the loop
            if (Console.KeyAvailable && Console.ReadKey(intercept: true).Key == ConsoleKey.Escape) {
                Console.WriteLine("Exiting program...");
                break;
            }

            // Delay to reduce CPU usage
            Thread.Sleep(_delayMilliseconds);
        }
    }
}
