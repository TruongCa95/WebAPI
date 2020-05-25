using System;
using System.Collections.Generic;
using System.Text;

namespace WebAPI.Data.Model
{
   public class BaseEntity
    {
        public Guid id { get; set; }
        public string CreateBy { get; set; }
        public string UpdateBy { get; set; }
        public DateTime CreateTime { get; set; }
        public DateTime UpadateTime { get; set; }
    }
}
