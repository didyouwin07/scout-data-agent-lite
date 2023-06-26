using System;
using Processes;
using KeyBindings;

public static class Program
{
    static void Main()
    {
        /**
            Checking if the mouse left button is pressed.
            In case, it is pressed then we are finding the coordinates for the mouse cursor.
            Also, finding the process name if the left mouse button is pressed.
        */
        while (true)
        {
            if (KeyBindings.Mouse.IsMouseButtonPressed(KeyBindings.Mouse.MouseButton.LeftMouseButton))
            {
                KeyBindings.Mouse.POINT mousePosition = KeyBindings.Mouse.GetMousePosition();
                string processName = Processes.ForegroundProcesses.GetForegroundProcessName();
                Console.WriteLine($"{processName}.exe:{{X={mousePosition.x},Y={mousePosition.y}}}");
            }

            System.Threading.Thread.Sleep(200);
        }
    }
}