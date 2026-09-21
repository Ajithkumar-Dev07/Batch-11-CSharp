using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Batch_11_CSharp.Encapsulation
{
    public class Account
    {
        private double Balance = 10000;

        public double ammount { get; set; }

        //public double Getbalance()
        //{
        //    return Balance;
        //}

        //public void Setbalance(int amount)
        //{
        //    Balance += amount;
        //}


        public double AccBalance
        {
            get { return Balance; }

            set {
                if (value > 1000)
                {
                    Balance += value;
                }
                else
                {
                    Console.WriteLine("Your amount must greater than 1000");
                }
            }
        }

        public void DisplayBalance()
        {
            Console.WriteLine("Balance = "+ Balance);
        }
    }
    internal class EncapsulationDemo : Account
    {
        static void Main()
        {

     
            Account obj = new Account();

           
            Console.WriteLine("Account Balance: "+  obj.AccBalance);

           // accBalance = obj.Getbalance();

           // Console.WriteLine(accBalance);

            Console.WriteLine("Enter the amount to Deposit: ");

            int amount = int.Parse(Console.ReadLine());

            obj.AccBalance = amount;

            Console.WriteLine(obj.AccBalance);

           // obj.Setbalance(amount);

          // accBalance = obj.Getbalance();

           // Console.WriteLine(accBalance);

            Console.WriteLine("\n Original balance");

            obj.DisplayBalance();

        }
    }
}
