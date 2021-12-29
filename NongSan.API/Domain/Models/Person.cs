using System;

namespace NongSan.API.Domain.Models
{
    public class Person : BaseEntity
    {
        public string Email { get; set; }
        public string UserName { get; set; }
        public string Avatar { get; set; }
        public bool Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Person()
        {
        }

    }

    public class Employee : BaseEntity { }
}
