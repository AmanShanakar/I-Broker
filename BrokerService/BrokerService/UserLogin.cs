using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrokerService
{
    public class UserLogin
    {
        private int _id;
        private string _name;
        private string _password;
        private string _status;

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Password
        {
            get { return _password; }
            set { _password = value; }
        }
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
