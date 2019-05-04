using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6autproekt
{
    public class ThirdPartParameters
    {
        [Key]
        public int Id { get; set; }
        public double LengthOfFoundation { get; set; }
        public double WidthOfFoundation { get; set; }
        public double HeightOfFoundation { get; set; }

        public double HeightOfMainPart { get; set; }

        public double WidthOfCut { get; set; }
        public double HeightOfCut { get; set; }

        public double RadiuesOfInnerCircle { get; set; }
    }
}
