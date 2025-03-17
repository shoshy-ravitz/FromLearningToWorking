﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FromLearningToWorking.Core.Entities
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Email { get; set; } 
        public string PasswordHash { get; set; } 
        //public int CodeResume { get; set; }

        // קשרים

        //[ForeignKey(nameof(CodeResume))]
        public Resume Resume { get; set; } 
        public List<Interview> Interviews { get; set; }
    }
}
