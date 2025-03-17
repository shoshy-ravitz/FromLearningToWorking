using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromLearningToWorking.Core.Entities
{
    public class Manager
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; } 
        public string Email { get; set; } 
        public string PasswordHash { get; set; }


        //public List<User> Users { get; set; }

    }
}
