using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLog.Domain.WorkItems
{
    public class WorkItemDetail
    {
        public int WorkItemID { get; set; }

        public DateTime WorkDate { get; set; }

        public string WorkLog { get; set; }

        public int WorkHours { get; set; }
    }
}
