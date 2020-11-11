using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductAPI.Models
{
    public class TodoItem
    {
        public long ID { get; set; }

        public  string name{ get; set; }

        public bool IsComplete{ get; set; }
    }
}
