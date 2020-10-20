using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace NetOS
{
    class FileSystem
    {
        static public Sys.FileSystem.CosmosVFS fileSystem;
        static public String currentDirectory = "0:\\";

        public static void RegisterFS()
        {
            fileSystem = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fileSystem);
        }
    }
}
