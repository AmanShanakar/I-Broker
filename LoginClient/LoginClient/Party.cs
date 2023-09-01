using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginClient
{
    public class Party
    {
        public int Id { get; set; }
        public string Party_Name { get; set; }
        public DateTime Due_Date { get; set; }
        public string Progress { get; set; }

        public Party(int id, string party_name, DateTime due_date, string progress)
        {
            this.Id = id;
            this.Party_Name = party_name;
            this.Due_Date = due_date;
            this.Progress = progress;
        }
    }
}
