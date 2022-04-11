﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModernLearns.DataLayer.Entities.Order
{
   public class OrderDetail
    {
        [Key]
        public int DetailId { get; set; }
        [Required]
        public int OrderId { get; set; }
        [Required]
        public int CourseId { get; set; }
        [Required]
        public int Count { get; set; }
        [Required]
        public int Price { get; set; }

        public virtual Order Order { get; set; }
        public virtual Course.Course Course { get; set; }
    }
}
