using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimeApp
{
    public class Duration
    {
        public int hours { get; set; }
        public int minutes { get; set; }
        public int seconds { get; set; }
        public Duration(int Hours, int Minutes, int Seconds)
        {
            hours = Hours;
            minutes = Minutes;
            seconds = Seconds;
        }
        public Duration(int Seconds)
        {
            hours = Seconds / 3600;
            minutes = (Seconds - (hours * 3600)) /60 ;
            seconds = (Seconds - (hours * 3600) - (minutes * 60));
        }
        public string PrintDuration()
        {
            return $"Hours: {hours}, Minutes: {minutes}, Seconds: {seconds}";
        }
    }
}
