using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge.Models
{
    public class Compensation
    {
        public String CompensationId { get; set; }
        public double Salary { get; set; }
        public DateTime EffectiveDate { get; set; }

        [ForeignKey("Employee")]
        public String EmployeeId { get; set; }
        public Employee Employee { get; set; }
    }
}
