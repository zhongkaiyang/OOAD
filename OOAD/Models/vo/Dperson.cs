using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OOAD.Models.vo
{
    public class Dperson
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gender { get; set; }
        public class school
        {
            public int ID { get; set; }
            public string Name { get; set; }
        }
        public string Title { get; set; }
        public string Avatar { get; set; }
    }
}
