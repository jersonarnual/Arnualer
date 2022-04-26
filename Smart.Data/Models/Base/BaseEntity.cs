using System;

namespace Smart.Data.Models.Base
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpdateTime { get; set; }
    }
}
