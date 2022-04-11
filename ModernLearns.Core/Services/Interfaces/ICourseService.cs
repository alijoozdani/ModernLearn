using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;
using ModernLearns.Core.DTOs.Course;
using ModernLearns.DataLayer.Entities.Course;

namespace ModernLearns.Core.Services.Interfaces
{
    public interface ICourseService
    {
        #region Group
        List<CourseGroup> GetAllGroup();
        List<SelectListItem> GetGroupForManageCourse();
        List<SelectListItem> GetSubGroupForManageCourse(int groupId);
        List<SelectListItem> GetTeachers();
        List<SelectListItem> GetLevels();
        List<SelectListItem> GetStatues();
        CourseGroup GetGroupById(int groupId);
        string GetGroupTitle(int groupId);
        void AddGroup(CourseGroup group);
        void UpdateGroup(CourseGroup group);
        bool DeleteGroup(int groupId);
        #endregion

        #region Course

        Tuple<List<ShowCourseForAdminViewModel>,int> GetCourseForAdmin(int pageId=1,string filter="");
        int AddCourse(Course course, IFormFile imgCourse, IFormFile courseDemo);
        Course GetCourseById(int id);
        void UpdateCourse(Course course, IFormFile imgCourse, IFormFile courseDemo);
        Tuple<List<ShowCourseListItemViewModel>,int> GegCourse(int pageId = 1, string filter = ""
            , string getType = "all", string orderByType = "date", int startPrice = 0
            , int endPrice = 0, List<int> selectedGroups = null, int take = 0);

        Course GetCourseForShow(int courseId);

        List<ShowCourseListItemViewModel> GetPopularCourse();
        List<ShowUserCourse> GetUserCourses(int userId);

        bool IsFree(int courseId);
        bool DeleteCourse(int courseId);
        #endregion

        #region Episode
        List<CourseEpisode> GetCourseEpisodes(int courseId);
        int AddEpisode(CourseEpisode episode, IFormFile episodeFile);
        bool CheckExistFile(string fileName);
        CourseEpisode GetEpisodeById(int episodeId);

        void EditEpisode(CourseEpisode episode, IFormFile episodeFile);

        #endregion

        #region Comment

        CourseCommentViewModel GetCourseComments(int pageId, int take, int courseId);
        List<CourseComment> GetCommentsForHome(int take);
        CourseComment GetCommentById(int commentId);
        void DeleteComment(CourseComment comment);
        CourseComment AddComment(CourseComment comment);
        void EditComment(CourseComment comment);
        #endregion

        #region Vote
        void AddVote(int userId, int courseId, bool vote);
        Tuple<int, int> GetCourseVote(int courseId);

        #endregion
    }
}
