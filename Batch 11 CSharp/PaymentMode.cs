using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp
{
    abstract class Payment
    {
        public int amount;

        public string TransactionStatus;

        public abstract void Transcationprocess(); 
    }
    interface IPayment
    {
        void SendMoney(int amount);
        
    }
    interface IUPI
    {
        void UPI();
    }
    interface INetBanking
    {
        void NetBanking();
    }

    internal class PaymentMode : Payment, IPayment, IUPI, INetBanking
    {
        
        public void SendMoney(int amount)
        {
            this.amount = amount;
            Console.WriteLine("your Cash Rs "+ amount+ " is Transfered");
        }

        public void UPI()
        {
            Console.WriteLine("Transtion done through UPI");
        }

        public void NetBanking()
        {
            Console.WriteLine("Transtion done through NetBanking");
        }

        public override void Transcationprocess()
        {
            Console.WriteLine("Transation strated...");
            Console.WriteLine("Trantion status: "+ TransactionStatus);
        }


        static void Main()
        {
            Console.WriteLine("Select your Payment Option");
            Console.WriteLine("1, UPI");
            Console.WriteLine("1, NetBanking");

            IPayment pay = new PaymentMode();
            
           int choice =  int.Parse(Console.ReadLine());
            switch(choice)
            {
                case 1:
                    IUPI obj = new PaymentMode();

                    obj.UPI();
                    pay.SendMoney(3000);
                    break;
                case 2:
                    INetBanking obj2 = new PaymentMode();
                    obj2.NetBanking();
                    pay.SendMoney(5000);
                    break;
            }



        }
    }
}
