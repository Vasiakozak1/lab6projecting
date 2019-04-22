using System.ComponentModel.DataAnnotations;

namespace lab6autproekt
{
    public class TestEntity
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
