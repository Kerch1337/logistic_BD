using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logistic_BD.Models
{
    public class Organization
    {
        public int OrganizationId { get; set; }

        public string Inn { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string Phone { get; set; }
    }
}
