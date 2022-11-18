using MaintenanceAdapter.Application.ViewModels.MessageIntegration.Requests;
using Microsoft.Azure.ServiceBus;
using System.Text;

namespace MaintenanceAdapter.Infra
{
    public class ServiceBusMessageClient
    {
      
       public bool SendMessage(String QueueAccessKey, String message)
       {
            ServiceBusConnectionStringBuilder conStr;
            QueueClient client;

            try
            {
                conStr = new ServiceBusConnectionStringBuilder(QueueAccessKey);
                client = new QueueClient(conStr);
                Message msg = new Message();
                msg.Body = Encoding.UTF8.GetBytes(message);
                client.SendAsync(msg).Wait();
                return true;

            } catch(Exception ex)
            {
                Console.WriteLine("{0}", ex.Message);
                return false;
            }
       }
    }
}