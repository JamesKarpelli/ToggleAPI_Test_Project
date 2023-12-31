﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace  Data.Entities
{
    public class State
    {
        [Key]
        public Guid Identifier { get; set; }
        public bool IsActive { get; set; }
        [ForeignKey("Toggle")]
        public Guid IdToggle { get; set; }
        public virtual Toggle Toggle { get; set; }
       
    }
}