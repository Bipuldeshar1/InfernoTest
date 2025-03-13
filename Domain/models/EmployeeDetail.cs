using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.models
{
    public class EmployeeDetail
    {
        public string EmployeeType {  get; set; }
        public string Title { get; set; }
        public string JoinDate { get; set; }
        public string Country { get; set; }
        public string District { get; set; }
        public long PhoneNumber { get; set; }

        
    }
}
