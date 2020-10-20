using Cosmos.System.Graphics;
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace NetOS
{
    public class Kernel : Sys.Kernel
    {
        protected override void BeforeRun()
        {
            Sys.PCSpeaker.Beep();
            //FileSystem.fileSystem.CreateDirectory(FileSystem.currentDirectory);
            StartOS.SetStyle();
            StartOS.Welcome();
        }

        protected override void Run()
        {
            //SystemOut.Print($"Current directory: {FileSystem.fileSystem.GetDirectory(FileSystem.currentDirectory)}");
            //FileSystem.RegisterFS();
            M:
            SystemOut.Print(String.Empty);
            String command = Console.ReadLine().ToString();
            if (command.StartsWith("Echo"))
            {
                command = command.TrimEnd();
                SystemOut.DefaultPrint(command.Substring(5));
            }

            else
            {
                switch (command)
                {
                    case "Help":
                        Commands.Help();
                        break;
                    case "SystemInfo":
                        Commands.SystemInfo();
                        break;
                    case "Shutdown":
                        Commands.Shutdown();
                        break;
                    case "Reboot":
                        Commands.Reboot();
                        break;
                    default:
                        SystemOut.ErrorPrint("Command not found, use Help()");
                        break;
                }
            }
            goto M;
        }
    }
}
