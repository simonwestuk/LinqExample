using System;
using System.Collections.Generic;
using System.Text;

namespace LinqExample
{
    class Customer
    {
        public Guid Id { get; set; }
        public string Fname { get; set; }
        public string Sname { get; set; }
        public string Email { get; set; }
        public DateTime Dob { get; set; }
        public string Tel { get; set; }

        public Customer(string fname, string sname, string email, DateTime dob, string tel)
        {
            Id = Guid.NewGuid();
            Fname = fname;
            Sname = sname;
            Email = email;
            Dob = dob;
            Tel = tel;
        }

        public override string ToString()
        {
            return $@"
            ID: {Id}
            Name: {Fname} {Sname}
            Email: {Email}
            DOB: {Dob}
            Tel: {Tel}";

        }
    }
}
