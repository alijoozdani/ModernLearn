using ModernLearns.DataLayer.Entities.Course;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModernLearns.Core.DTOs.Course
{
    public class CourseCommentViewModel
    {
        public List<CourseComment> CourseComments { get; set; }
        public List<CourseComment> AnswerComments { get; set; }
        public int CurrentPage { get; set; }
        public int PageCount { get; set; }
        public int StartPage { get; set; }
        public int EndPage { get; set; }
        public int CommentsCount { get; set; }
    }
}
