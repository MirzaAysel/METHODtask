using System;
using ConsoleApp3.Models;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region object
            Phone phone = new Phone ( ReadlineStr("please, enter the name"), ReadlineStr("please,enter the producer"),ReadLineInt("please, enter the year"), ReadlineStr("please,enter the version"), ReadlineStr("please,enter the ram"));

            Console.WriteLine(phone.GetPhoneFullField());

            #endregion
        }

           static string ReadlineStr(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }
        static int ReadLineInt(string message) 
        {
        TryAgain:
            string result = ReadlineStr(message);
            try
            {
                return Convert.ToInt32(result);
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("try again!");
                goto TryAgain;
            }




        }



    }      
}           
