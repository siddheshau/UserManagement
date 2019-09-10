using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace UserManagementService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "UserManagementService" in both code and config file together.
    public class UserManagementService : IUserManagementService
    {
        public string CheckStatus(int id)
        {
            // Based on Unique ID of the BankUSer This Service Will Check and return The Status Of User From DB 
            string status = DBChannel.DBChannel.channel.GetStatusFromDB(id);
            return status;
        }

        public string DisplayUserInformation(int id)
        {
            //After Successfull login of User of the User it will display the logged BankUser Info except Password.
            return "Emoployee Name";
        }

        public bool IsValidToDoTransaction(string status)
        {
            //Based on status of the user this service will notify user that if he or she is allowed to Banking Transaction.
            return true;
        }
    }
}
