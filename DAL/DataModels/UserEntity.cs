﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL.DataModels
{
    [Table("tbl_users")]
    public class UserEntity
    {
        public int Id { get; set; }  
        public string UserName { get; set; }  
        public string Email { get; set; }  
        public string PasswordHash { get; set; } 
    }
}
