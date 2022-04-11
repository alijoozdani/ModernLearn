using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModernLearns.DataLayer.Entities.Course
{
    public class CourseVote
    {
        [Key]
        public int VoutId { get; set; }
        [Required]
        public int UserId { get; set; }
        [Required]
        public int CourseId { get; set; }
        [Required]
        public bool Vote { get; set; }
        public DateTime VoteDate { get; set; }

        public User.User User { get; set; }
        public Course Course { get; set; }
    }
}
