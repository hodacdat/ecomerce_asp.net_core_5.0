﻿using System;
using System.Collections.Generic;

#nullable disable

namespace PE.Models
{
    public partial class Account
    {
        public Account()
        {
            TbTinTucs = new HashSet<TbTinTuc>();
        }

        public int AccountId { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public bool Active { get; set; }
        public string FullName { get; set; }
        public int? RoleId { get; set; }
        public DateTime? LastLogin { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual Role Role { get; set; }
        public virtual ICollection<TbTinTuc> TbTinTucs { get; set; }
    }
}
