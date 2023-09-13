using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMasterApp
{
    public class InvalidArmorExcepition : Exception
    {
        public InvalidArmorExcepition() { }

        public InvalidArmorExcepition(string message) : base(message) { }

        public InvalidArmorExcepition(string message, Exception innerException) : base(message, innerException) { }
    }
}
