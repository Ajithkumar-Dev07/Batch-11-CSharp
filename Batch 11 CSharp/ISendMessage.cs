using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp
{
    internal interface ISendMessage
    {
        void SendMessage(string message);
    }

    class Notification : ISendMessage
    {
        public void SendMessage(string msg)
        {
            Console.WriteLine( "Your Message from Interface = "+ msg);
        }
    }

    class SendMessage
    {
        static void Main()
        {
            ISendMessage obj = new Notification();

            obj.SendMessage("Implementing function");
        }

    }
}
