using System;
using System.Collections.Generic;

namespace SP_IPChanger
{
    public class Settings
    {
        public String adapter = "";
        public List<PBXEntry> entries = new List<PBXEntry>();
        public List<ProgramPath> programPaths = new List<ProgramPath>()
        {
            new ProgramPath() { Name = "Browser" },
            new ProgramPath() { Name = "Panasonic" },
            new ProgramPath() { Name = "Slican"},
            new ProgramPath() { Name = "Micra"},
            new ProgramPath() { Name = "Optima"},
            new ProgramPath() { Name = "Libra" },
        };

        public class PBXEntry
        {
            public String Name;
            public String IP;
            public String Program;
            public String login;
            public String password;
        }

        public class ProgramPath
        {
            public String Name;
            public String Path;
        }
    }


}
