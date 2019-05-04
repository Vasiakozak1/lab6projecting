using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab6autproekt
{
    public class SecondPartParameters
    {
        [Key]
        public int Id { get; set; }
        public double LengthOfMainPart { get; set; }
        public double WidthOfMainPart { get; set; }

        public double LenthOfTop { get; set; }
    }
}
