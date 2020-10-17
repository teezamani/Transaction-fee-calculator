using System;

namespace TRANSACTION_FEE_CALCULATOR
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculate();
        }

        public static void Calculate()
            {

             decimal amount;
            Console.WriteLine("Kindly Enter Amount to be transferred");
            //get the amount to be transferred;
            try
            {
                amount = Convert.ToDecimal(Console.ReadLine());
                //compute service charge
                var charge = FeeHelper.computeExpectedCharge(amount);
                
                //Get the equivalent charge for the amount entered
                if (charge != null)
                {
                    Console.WriteLine($"Amount : {amount}");
                    Console.WriteLine($"Bank Charge:  {charge}");
                }
                else
                {
                    Console.WriteLine("Sorry we cannot process your transaction. Try to process another amount");
                    //proceed with any other information
                }
            }
            catch(Exception)
            {
                Console.WriteLine("Enter a Valid Number");
            }
            Console.ReadKey();   
            }
    }
}
