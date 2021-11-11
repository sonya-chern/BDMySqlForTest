using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BDMySqlForTest.ModelsDto
{
    [Table("test")]
    public class Test
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Status StatusId { get; set; }
        public string MethodName { get; set; }
        public Project ProjectId { get; set; }
        public Session SessionId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public string Env { get; set; }
        public string Browser { get; set; }
        public Author AuthorId { get; set; }
    }
}
