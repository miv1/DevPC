namespace Jalasoft.DevBootcamp.Pc.Software
{
using System;
using System.Collections.Generic;

        public class Software
        {
        public string Name { get; set; }

        public string Manufacturer { get; set; }

        public int Version { get; set; }

        public DateTime LastUpdate { get; set; }

        public DateTime Release { get; set; }

        public bool Licensing { get; set; }
        
        public List<User.User> Users { get; set; }

        public bool OpenProgram()
        {
            return false;
        }

        public bool CloseProgram()
        {
            return true;
        }

        public bool AdminPermission()
        {
            return false;
        }

        private decimal MemoryUse()
        {
            return 0;
        }

        private decimal CpuUse()
        {
            return 0;
        }

        private decimal DiskUse()
        {
            return 0;
        }

        private decimal NetworkUse()
        {
            return 0;
        }
    }
}
