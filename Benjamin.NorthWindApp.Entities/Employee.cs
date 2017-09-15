using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Benjamin.NorthWindApp.Entities
{
    public class Employee
    {
        public Employee
            (int employeeID, 
            string lastName, 
            string firstName, 
            string title, 
            string titleOfCourtesy, 
            DateTime birthDate, 
            DateTime hireDate, 
            string address, 
            string city, 
            string region, 
            string postalCode, 
            string country, 
            string homePhone, 
            string extension, 
            /*??? photo,*/
            int reportsTo, 
            string photoPath)
        {
            try
            {
                EmployeeID = employeeID;
                LastName = lastName;
                FirstName = firstName;
                Title = title;
                TitleOfCourtesy = titleOfCourtesy;
                BirthDate = birthDate;
                HireDate = hireDate;
                Address = address;
                City = city;
                Region = region;
                PostalCode = postalCode;
                Country = country;
                HomePhone = homePhone;
                Extension = extension;
                /* Photo = photo;*/
                ReportsTo = reportsTo;
                PhotoPath = photoPath;
            }
            catch( ArgumentException )
            {
                throw;
            }
        }


        public int EmployeeID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Title { get; set; }
        public string TitleOfCourtesy { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime HireDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Region { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }
        public string HomePhone { get; set; }
        public string Extension { get; set; }
        //public ??? Photo { get; set; }
        public string Notes { get; set; }
        public int ReportsTo { get; set; }
        public string PhotoPath { get; set; }

    }
}
