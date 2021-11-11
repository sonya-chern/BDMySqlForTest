using System.ComponentModel.DataAnnotations.Schema;

namespace BDMySqlForTest.ModelsDto
{
    [Table("project")]
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
