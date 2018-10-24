using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistryReaderTool
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistryKey key = Registry.LocalMachine.OpenSubKey(@"HARDWARE\DESCRIPTION\System\BIOS");
            if (key != null)
            {
                Console.WriteLine("BIOS Values:");
                foreach (var valuename in key.GetValueNames())
                {
                    Console.WriteLine(valuename + ": " + key.GetValue(valuename).ToString());
                }
                
            }
            Console.ReadLine();
        }
    }
}
