using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HandsOnEmployee.Models


{

    
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int Salary { get; set; }

        public bool Permanent { get; set; }

        //public Department Department { get; set; }

       // public List<Skill> Skills { get; set; }

        public DateTime DateOfBirth { get; set; }
    }

   
}
