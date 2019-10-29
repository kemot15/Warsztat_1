using System;
using System.Collections.Generic;
using System.Text;

namespace Tasks
{
    class TaskModel
    {
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool? IsAllDayFlag { get; set; }
        public Flag? ImportantFlag { get; set; }

        public TaskModel(string description, DateTime startDate)
        {
            Description = description;
            StartDate = startDate;
        }
    }
}
