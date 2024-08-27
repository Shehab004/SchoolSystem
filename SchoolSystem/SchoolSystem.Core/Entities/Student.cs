using System;

namespace SchoolSystem.Core.Entities
{
    public class Student
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public string PhoneNumber { get; private set; }
        public string ParentNumber { get; private set; }
        public string Address { get; private set; }

        public decimal Degree { get; private set; }

        public Student(string name, string phoneNumber, string parentNumber, string address, decimal degree)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Student name cannot be empty.", nameof(name));

            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("Phone number cannot be empty.", nameof(phoneNumber));

            if (string.IsNullOrWhiteSpace(parentNumber))
                throw new ArgumentException("Parent number cannot be empty.", nameof(parentNumber));

            if (string.IsNullOrWhiteSpace(address))
                throw new ArgumentException("Address cannot be empty.", nameof(address));

            if(degree < 0)
                throw new ArgumentException("Degree can not be negative", nameof(degree));
            if(Degree > 100)
                throw new ArgumentException("Degree cano not be greater than 100", nameof(Degree));

            Name = name;
            PhoneNumber = phoneNumber;
            ParentNumber = parentNumber;
            Address = address;
            Degree = degree;
        }




    }
}
