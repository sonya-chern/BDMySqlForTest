using System.ComponentModel.DataAnnotations.Schema;

namespace BDMySqlForTest.ModelsDto
{
    [Table("status")]
    public class Status
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
