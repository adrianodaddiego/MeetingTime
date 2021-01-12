using System;

namespace MeetinTime.Models
{
    public class MeetingRow
    {
        public DateTime  Start { get; set; }
        public short Duration { get; set; }
        public DateTime End { get; set; }
        public string  Title { get; set; }
    }
}
