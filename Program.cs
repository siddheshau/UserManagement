using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using UserManagementService;

namespace UserManagementServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            if (DBChannel.DBChannel.channel.ISConnected())
            {
                try
                {
                    using (ServiceHost host=new ServiceHost(typeof(UserManagementService.UserManagementService)))
                    {
                        host.Open();
                        //Display and log that service is started successfully..
                    }
                }
                catch (Exception ex)
                {
                    //Log Exception
                }
            }
        }
    }
}
