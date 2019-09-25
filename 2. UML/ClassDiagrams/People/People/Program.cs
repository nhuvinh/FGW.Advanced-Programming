using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace People
{
    abstract class Person
    {
        string Name;
        int PhoneNumber;
        string EmailAddress;
        Address Address;

        public Person(string name, Address address)
        {
            Name = name;
            Address = address;
        }

        public abstract bool PurchaseParkingPass();
    }

    class Student : Person
    {
        int StudentNumber;
        double AverageMark;

        public Student(string name, Address address) : base(name, address) { }

        bool IsEligibleToEnroll()
        {
            return false;
        }

        void GetSeminarsTaken()
        {

        }

        public override bool PurchaseParkingPass()
        {
            return false;
        }
    }

    class Professor : Person
    {
        double Salary;

        public Professor(string name, Address address) : base(name, address) { }

        public override bool PurchaseParkingPass()
        {
            return false;
        }
    }

    class Address
    {
        string Street;
        string City;
        string State;
        int PostalCode;
        string country;

        bool Validate()
        {
            return false;
        }

        string OutputAsLabel()
        {
            return "To be implemented";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
