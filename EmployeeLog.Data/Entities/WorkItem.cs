﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLog.Data.Entities
{
    public class WorkItem
    {
        public int WorkItemID { get; set; }

        public string Description { get; set; }

        public int ProjectID { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime ExpectedEndDate { get; set; }

        public int WorkItemStatusID { get; set; }

        public int TotalWorkHours { get; set; }

        public Project Project { get; set; }

        public WorkItemStatus WorkItemStatus { get; set; }
    }
}
