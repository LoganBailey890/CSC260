using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Validation.Models
{
    public class Address : ValidationAttribute
    {
        [Required(ErrorMessage = "Hey you need a first name")]
        public string firstName { get; set; }
        [Required(ErrorMessage = "Hey you need a Last name")]
        public string lastName { get; set; }
        [Range(5, 100, ErrorMessage = "Hey you need to put in the age between 5 - 100")]
        public int Age { get; set; }

        public string streetAddress { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int zipCode { get; set; }


        public Address()
        {

        }

        public Address(string firstName, string lastName, int age,string streetaddress,string city,string state, int zipcode)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.Age = age;
            this.streetAddress = streetAddress;
            this.City = city;
            this.State = state;
            this.zipCode = zipCode;
        }

        public override string ToString()
        {
            return $" { firstName } - { lastName } - { Age } \n" +
                $"Address: {streetAddress} - { City } - { State } - { zipCode }";
        }
    }

}
