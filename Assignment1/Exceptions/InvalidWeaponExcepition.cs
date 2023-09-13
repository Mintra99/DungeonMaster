using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DungeonMasterApp
{
    public class InvalidWeaponExcepition : Exception
    {
        public InvalidWeaponExcepition() { }

        public InvalidWeaponExcepition(string message) : base(message) { }

        public InvalidWeaponExcepition(string message, Exception innerException) : base(message, innerException) { }
    }
}
