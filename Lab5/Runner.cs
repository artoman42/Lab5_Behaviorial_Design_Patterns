using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL;
namespace UIL
{
    public class Runner : IRunner
    {
        public void Run()
        {
            var baseChain = new XSSValidator().SetNext(new SQLInjectionValidator());
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter FullName :");
                    baseChain.SetNext(new FullNameValidator());
                    while(!baseChain.Validate(Console.ReadLine())) Console.WriteLine("FullName is incorrect!");
                    Console.WriteLine("Enter Phone:");
                    baseChain.SetNext(new PhoneValidator());
                    while(!baseChain.Validate(Console.ReadLine())) Console.WriteLine("Phone is incorrect");
                    baseChain.SetNext(new MailValidator());
                    Console.WriteLine("Enter E-Mail :");
                    while (!baseChain.Validate(Console.ReadLine())) Console.WriteLine("E-Mail is incorrect");
                    baseChain.SetNext(new DeliveryAddressValidator());
                    Console.WriteLine("Enter DeliveryAdress :");
                    while (!baseChain.Validate(Console.ReadLine())) Console.WriteLine("DelieveryAdress is incorrect");
                    baseChain.SetNext(new DeliveryTypeValidator());
                    Console.WriteLine("Enter DeliveryType :");
                    while (!baseChain.Validate(Console.ReadLine())) Console.WriteLine("DelieveryType is incorrect");
                    baseChain.SetNext(new PostOfficeBranchValidator());
                    Console.WriteLine("Enter PostOfficeBranch :");
                    while (!baseChain.Validate(Console.ReadLine())) Console.WriteLine("PostOfficeBranch is incorrect");


                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
    }
}
