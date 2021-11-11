using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace BDMySqlForTest.ModelsDto
{
    [Table("session")]
    public class Session
    {
        public int Id { get; set; }
        public string SessionKey { get; set; }
        public DateTimeOffset CreatedTime { get; set; }
        public long BuildNumber { get; set; }

    }
}
