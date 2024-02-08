using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5.Entity
{
    public class Debtor
    {
        public Debtor(int id,string fullname, DateTime birthDay, string phone, string email, string address, int debt)
        {
            Id = id;
            FullName = fullname;
            BirthDay = birthDay;
            Phone = phone;
            Email = email;
            Address = address;
            Debt = debt;
        }
        public Debtor()
        {
            
        }
        public int Id { get; set; }
        public string FullName { get; set; }
        public DateTime BirthDay { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Debt { get; set; }
        public override string ToString() { return $"{this.Id } {this.FullName} {this.BirthDay.ToShortDateString()} {this.Phone} {this.Email} {this.Address} {this.Debt}"; }

        
    }

}
