using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginClient
{
    public class Person
    {
        public string User { get; set; }
        public string Case_Description { get; set; }
        public string Status { get; set; }
        public DateTime Last_Updated { get; set; }
        public string Tracking_Id { get; set; }
        public string Image { get; set; }

        public Person(string user, string case_desp,string status,DateTime last_up , string tracking_id, string image)
        {
            this.User = user;
            this.Case_Description = case_desp;
            this.Status = status;
            this.Last_Updated = last_up;
            this.Tracking_Id = tracking_id;
            this.Image = image;
        }
    }
}
