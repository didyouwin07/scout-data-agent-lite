using System.Runtime.InteropServices;
using System.Diagnostics;

namespace Processes
{
    public class ForegroundProcesses
    {

        [DllImport("user32.dll")]
        static extern IntPtr GetForegroundWindow();
        [DllImport("user32.dll", SetLastError = true)]
        static extern uint GetWindowThreadProcessId(IntPtr hWnd, out int processId);
        public static string GetForegroundProcessName()
        {
            IntPtr hWnd = GetForegroundWindow();
            GetWindowThreadProcessId(hWnd, out int processId);
            Process process = Process.GetProcessById(processId);
            return process.ProcessName;
        }
    }

}