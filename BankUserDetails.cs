using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace UserManagementService
{
    [DataContract]
    public class BankUserDetails
    {
        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public string EmailAddress { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string UserStatus { get; set; }

        [DataMember]
        int UserID { get; set; }
    }
}
