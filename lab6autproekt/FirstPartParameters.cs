using System.ComponentModel.DataAnnotations;

namespace lab6autproekt
{
    public class FirstPartParameters
    {
        [Key]
        public int Id { get; set; }

        public double LengthOfMainPart { get; set; }
        public double WidthOfMainPart { get; set; }
        public double HeightOfMainPart { get; set; }

        public double HeightOfFirst { get; set; }
        public double LengthOfFirst { get; set; }

        public double LengthOfExtrusion { get; set; }
        public double WidthOfExtrusion { get; set; }
    }
}
