using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assessment3
{
    public class SessionData
    {
        private int _accountID;

        public int AccountID { get => _accountID; set => _accountID = value; }

        public SessionData(int accountID)
        {
            _accountID = accountID;
        }
    }
}

        

