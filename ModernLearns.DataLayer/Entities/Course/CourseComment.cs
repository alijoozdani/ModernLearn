using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ModernLearns.DataLayer.Entities.Course
{
    public class CourseComment
    {
        [Key]
        public int CommentId { get; set; }
        public int CourseId { get; set; }
        public int UserId { get; set; }

        [Required(ErrorMessage = "لطفا دیدگاهتان را بنویسید")]
        [MaxLength(700)]
        public string Comment { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsDelete { get; set; }
        public bool IsAdminReade { get; set; }
        public int? Answer { get; set; }

        public User.User User { get; set; }
        public Course Course { get; set; }
    }
}
