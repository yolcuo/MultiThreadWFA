using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiThreadingApp.Models
{
    public class Data
    {
        public int ID { get; set; }
        public int Number { get; set; }
        public DateTime ModifiedDate { get; set; } = DateTime.Now;
    }
}
