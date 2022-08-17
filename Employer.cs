using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestGittHub_Repasitory.Enums;

namespace TestGittHub_Repasitory
{
    public class Employer : Person
    {
        public LevelEnum Level { get; set; }
        public PositionEnum Position { get; set; }
    }
}
