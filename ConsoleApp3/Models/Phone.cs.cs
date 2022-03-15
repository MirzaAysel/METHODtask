using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3.Models
{
    class Phone
    {
        public string name;
        public string producer;
        public int year;
        public string version;
        public string ram;


        public Phone(string name, string producer)
            { 
            this.name = name;
            this.producer = producer;
             }
        public Phone(string name, string producer, int year, string version): this (name,producer)
            {
            this.year = year;
            this.version = version;
            }

        public Phone(string name, string producer, int year, string version, string ram) : this(name, producer, year, version)
        {
            this.ram = ram;
        }
         public string GetPhoneFullField()
        {
            return $"I have a Phone. It's name {this.name}. It's produces {this.producer}. It's year {this.year}. It's version {this.version}.";
        }




    }


}


       






