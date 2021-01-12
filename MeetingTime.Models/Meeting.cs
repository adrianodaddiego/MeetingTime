using System;
using System.Collections.Generic;

namespace MeetinTime.Models
{
    public class Meeting
    {
        public DateTime Date{ get; set; }

        public List<MeetingRow> Rows { get; set; }
    }
}
