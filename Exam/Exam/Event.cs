using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Event
    {
        public int Id { get; set; }
        public DateTime EventDate { get; set; }
        public string Title { get; set; }
        public string Text { get; set; }
        public List<City> Cities { get; set; }

        public Event()
        {
            Cities = new List<City>();
        }
    }
}
