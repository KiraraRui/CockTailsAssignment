using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CockTailAssignment
{
    public enum UnitType
    {
        Ml = 1, 
        Tps,
        Dash,
        Segment,
        Slice,
        Cubes
    }
}
