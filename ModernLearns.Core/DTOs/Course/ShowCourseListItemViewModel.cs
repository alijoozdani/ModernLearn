using ModernLearns.DataLayer.Entities.Course;
using ModernLearns.DataLayer.Entities.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace ModernLearns.Core.DTOs.Course
{
    public class ShowCourseListItemViewModel
    {
        public int CourseId { get; set; }
        public string CourseTitle { get; set; }
        public string Description { get; set; }
        public string GroupTitle { get; set; }
        public string ImageName { get; set; }
        public string Teacher { get; set; }
        public int Price { get; set; }
        //episodes
        public List<CourseEpisode> CourseEpisodes { get; set; }
    }
    public class ShowUserCourse
    {
        public int CourseId { get; set; }
        public string Title { get; set; }
        public string ImageName { get; set; }
    }
}
