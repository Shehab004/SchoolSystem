using System;

namespace SchoolSystem.Core.Entities
{
    public class Teacher
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public int Age { get; private set; }
        public string Subject { get; private set; }
        public string PhoneNumber { get; private set; }

        public int Salary { get; private set; }

        public Teacher(string name, int age, string subject, string phoneNumber, int salary)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Teacher name cannot be empty.", nameof(name));

            if (age <= 0)
                throw new ArgumentException("Age must be a positive integer.", nameof(age));

            if (string.IsNullOrWhiteSpace(subject))
                throw new ArgumentException("Subject cannot be empty.", nameof(subject));

            if (string.IsNullOrWhiteSpace(phoneNumber))
                throw new ArgumentException("Phone number cannot be empty.", nameof(phoneNumber));

            Name = name;
            Age = age;
            Subject = subject;
            PhoneNumber = phoneNumber;
            Salary = salary;
        }
      
    }
}
