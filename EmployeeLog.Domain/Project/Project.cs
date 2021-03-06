﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EmployeeLog.Domain.Project
{
    public class Project
    {
        public int ProjectID { get; set; }

        public string Name { get; set; }

        public int ClientID { get; set; }

        public int TeamSize { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime ExpectedEndDate { get; set; }
    }
}
