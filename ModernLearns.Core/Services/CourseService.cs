using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using ModernLearns.Core.Convertors;
using ModernLearns.Core.DTOs.Course;
using ModernLearns.Core.Generator;
using ModernLearns.Core.Security;
using ModernLearns.Core.Services.Interfaces;
using ModernLearns.DataLayer.Context;
using ModernLearns.DataLayer.Entities.Course;

namespace ModernLearns.Core.Services
{
    public class CourseService : ICourseService
    {
        private ModernLearnsDBContext _context;
        private IUserService _userService;
        public CourseService(ModernLearnsDBContext context,IUserService userService)
        {
            _context = context;
            _userService = userService;
        }

        public CourseComment AddComment(CourseComment comment)
        {
            comment.CreateDate = DateTime.Now;
            _context.CourseComments.Add(comment);
            _context.SaveChanges();
            return GetCommentById(comment.CommentId);
        }

        public int AddCourse(Course course, IFormFile imgCourse, IFormFile courseDemo)
        {
            course.CreateDate = DateTime.Now;
            course.CourseImageName = "no-photo.jpg";
            //TODO Cheack Image
            if (imgCourse != null && imgCourse.IsImage())
            {
                course.CourseImageName = NameGenerator.GenerateUniqCode() + Path.GetExtension(imgCourse.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/image", course.CourseImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgCourse.CopyTo(stream);
                }

                ImageConvertor imgResizer = new ImageConvertor();
                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/thumb", course.CourseImageName);

                imgResizer.Image_resize(imagePath, thumbPath, 150);
            }

            if (courseDemo != null)
            {
                course.DemoFileName = NameGenerator.GenerateUniqCode() + Path.GetExtension(courseDemo.FileName);
                string demoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/demoes", course.DemoFileName);
                using (var stream = new FileStream(demoPath, FileMode.Create))
                {
                    courseDemo.CopyTo(stream);
                }
            }
            _context.Add(course);
            _context.SaveChanges();

            return course.CourseId;
        }

        public int AddEpisode(CourseEpisode episode, IFormFile episodeFile)
        {
            episode.EpisodeFileName = episodeFile.FileName;

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/courseFiles", episode.EpisodeFileName);
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                episodeFile.CopyTo(stream);
            }

            _context.CourseEpisodes.Add(episode);
            _context.SaveChanges();
            return episode.EpisodeId;
        }

        public void AddGroup(CourseGroup group)
        {
            _context.CourseGroups.Add(group);
            _context.SaveChanges();
        }

        public void AddVote(int userId, int courseId, bool vote)
        {
            var userVote = _context.CourseVotes.FirstOrDefault(v => v.UserId == userId && v.CourseId == courseId);
            if (userVote != null)
            {
                userVote.Vote = vote;
            }
            else
            {
                userVote = new CourseVote()
                {
                    UserId = userId,
                    CourseId = courseId,
                    Vote = vote
                };
                _context.Add(userVote);
            }
            _context.SaveChanges();
        }

        public bool CheckExistFile(string fileName)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/courseFiles", fileName);
            return File.Exists(path);
        }

        public void DeleteComment(CourseComment comment)
        {
            comment.IsDelete = true;
            _context.Update(comment);
            _context.SaveChanges();
        }

        public bool DeleteCourse(int courseId)
        {
            var course = GetCourseById(courseId);
            course.IsDelete = true;
            _context.Update(course);
            _context.SaveChanges();
            return true;
        }

        public bool DeleteGroup(int groupId)
        {
            var group = GetGroupById(groupId);
            group.IsDelete = true;
            UpdateGroup(group);
            return true;
        }

        public void EditComment(CourseComment comment)
        {
            _context.Update(comment);
            _context.SaveChanges();
        }

        public void EditEpisode(CourseEpisode episode, IFormFile episodeFile)
        {
            if (episodeFile != null)
            {
                string deleteFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/courseFiles", episode.EpisodeFileName);
                File.Delete(deleteFilePath);

                episode.EpisodeFileName = episodeFile.FileName;
                string filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/courseFiles", episode.EpisodeFileName);
                using (var stream = new FileStream(filePath, FileMode.Create))
                {
                    episodeFile.CopyTo(stream);
                }
            }

            _context.CourseEpisodes.Update(episode);
            _context.SaveChanges();
        }

        public Tuple<List<ShowCourseListItemViewModel>, int> GegCourse(int pageId = 1, string filter = ""
            , string getType = "all", string orderByType = "date", int startPrice = 0
            , int endPrice = 0, List<int> selectedGroups = null, int take = 0)
        {
            if (take == 0)
                take = 9;

            IQueryable<Course> result = _context.Courses;

            if (!string.IsNullOrEmpty(filter))
            {
                result = result.Where(c => c.CourseTitle.Contains(filter) || c.Tags.Contains(filter));
            }

            switch (getType)
            {
                case "all":
                    break;

                case "buy":
                    {
                        result = result.Where(c => c.CoursePrice != 0);
                        break;
                    }

                case "free":
                    {
                        result = result.Where(c => c.CoursePrice == 0);
                        break;
                    }
            }

            switch (orderByType)
            {
                case "date":
                    {
                        result = result.OrderByDescending(c => c.CreateDate);
                        break;
                    }
                case "updatedate":
                    {
                        result = result.OrderByDescending(c => c.UpdateDate);
                        break;
                    }
            }

            if (startPrice > 0)
            {
                result = result.Where(c => c.CoursePrice > startPrice);
            }

            if (endPrice > 0)
            {
                result = result.Where(c => c.CoursePrice < endPrice);
            }

            if(selectedGroups!=null && selectedGroups.Any())
            {
                foreach(var groupId in selectedGroups)
                {
                    result = result.Where(c => c.GroupId == groupId || c.SubGroup == groupId);
                }
            }

            int skip = (pageId - 1) * take;

            var query = result.Include(c => c.CourseEpisodes).Select(c => new ShowCourseListItemViewModel()
            {
                CourseId = c.CourseId,
                CourseTitle = c.CourseTitle,
                ImageName = c.CourseImageName,
                Price = c.CoursePrice,
                CourseEpisodes = c.CourseEpisodes,
                Description = c.CourseDescription,
                GroupTitle = c.Group.GroupTitle,
                Teacher= _userService.GetUserById(c.TeacherId).UserName
            });

            var list = query.Skip(skip).Take(take).ToList();
            var pageCount = query.Count() / take;

            return Tuple.Create(list, pageCount);
        }

        public List<CourseGroup> GetAllGroup()
        {
            return _context.CourseGroups.Include(c=>c.CourseGroups).ToList();
        }

        public CourseComment GetCommentById(int commentId)
        {
            return _context.CourseComments.Find(commentId);
        }

        public List<CourseComment> GetCommentsForHome(int take)
        {
            return _context.CourseComments.Include(c=>c.User).Include(c=>c.Course).Where(c => c.IsAdminReade == true).OrderByDescending(c=>c.CreateDate).Take(take).ToList();
        }

        public Course GetCourseById(int id)
        {
            return _context.Courses.Find(id);
        }

        public CourseCommentViewModel GetCourseComments(int pageId, int take, int courseId)
        {
            var comments = _context.CourseComments.Include(c=>c.User).Where(c => c.CourseId == courseId);
            var mainComments = comments.Where(c => c.Answer == null).OrderByDescending(c => c.CreateDate);
            var answerComments = comments.Where(c => c.Answer != null);
            var skip = (pageId - 1) * take;
            var pageCount = (int)Math.Ceiling(mainComments.Count() / (double)take);
            var commentsModel = new CourseCommentViewModel()
            {
                CourseComments = mainComments.Skip(skip).Take(take).ToList(),
                AnswerComments = answerComments.ToList(),
                CurrentPage = pageId,
                PageCount = pageCount,
                StartPage = (pageId - 4 <= 0) ? 1 : pageId - 4,
                EndPage = (pageId + 5 > pageCount) ? pageCount : pageId + 5,
                CommentsCount = comments.Count()
            };
            return commentsModel;
        }

        public List<CourseEpisode> GetCourseEpisodes(int courseId)
        {
            return _context.CourseEpisodes.Where(e => e.CourseId == courseId).ToList();
        }

        public Tuple<List<ShowCourseForAdminViewModel>, int> GetCourseForAdmin(int pageId = 1, string filter = "")
        {
            IQueryable<Course> result = _context.Courses;

            if (!string.IsNullOrEmpty(filter))
            {
                result = result.Where(c => c.CourseTitle.Contains(filter));
            }

            int take = 20;
            int skip = (pageId - 1) * take;
            var query = result.Select(c => new ShowCourseForAdminViewModel()
            {
                CourseId = c.CourseId,
                Title = c.CourseTitle,
                EpisodeCount = c.CourseEpisodes.Count,
                ImageName = c.CourseImageName
            });
            var pageCount= result.Count() / take;
            var list=query.Skip(skip).Take(take).ToList();
            return Tuple.Create(list, pageCount);
        }

        public Course GetCourseForShow(int courseId)
        {
            return _context.Courses.Include(c => c.CourseEpisodes)
                .Include(c => c.CourseStatus).Include(c => c.CourseLevel)
                .Include(c => c.User)
                .FirstOrDefault(c => c.CourseId == courseId);
        }

        public Tuple<int, int> GetCourseVote(int courseId)
        {
            var vote = _context.CourseVotes.Where(c => c.CourseId == courseId).Select(c => c.Vote).ToList();

            return Tuple.Create(vote.Count(c => c), vote.Count(c => !c));
        }

        public CourseEpisode GetEpisodeById(int episodeId)
        {
            return _context.CourseEpisodes.Find(episodeId);
        }

        public CourseGroup GetGroupById(int groupId)
        {
            return _context.CourseGroups.Find(groupId);
        }

        public List<SelectListItem> GetGroupForManageCourse()
        {
            return _context.CourseGroups.Where(g => g.ParentId == null)
                .Select(g => new SelectListItem()
                {
                    Text = g.GroupTitle,
                    Value = g.GroupId.ToString()
                }).ToList();
        }

        public string GetGroupTitle(int groupId)
        {
            return _context.CourseGroups.FirstOrDefault(g => g.GroupId == groupId).GroupTitle;
        }

        public List<SelectListItem> GetLevels()
        {
            return _context.CourseLevels.Select(l => new SelectListItem()
            {
                Value = l.LevelId.ToString(),
                Text = l.LevelTitle
            }).ToList();
        }

        public List<ShowCourseListItemViewModel> GetPopularCourse()
        {
            return _context.Courses.Include(c => c.OrderDetails)
                .Include(c => c.CourseEpisodes)
                .Where(c => c.OrderDetails.Any())
                .OrderByDescending(d => d.OrderDetails.Count)
                .Take(8)
                .Select(c => new ShowCourseListItemViewModel()
                {
                    CourseId = c.CourseId,
                    ImageName = c.CourseImageName,
                    Price = c.CoursePrice,
                    CourseTitle = c.CourseTitle,
                    CourseEpisodes = c.CourseEpisodes
                })
                .ToList();
        }

        public List<SelectListItem> GetStatues()
        {
            return _context.CourseStatuses.Select(s => new SelectListItem()
            {
                Value = s.StatusId.ToString(),
                Text = s.StatusTitle
            }).ToList();
        }

        public List<SelectListItem> GetSubGroupForManageCourse(int groupId)
        {
            return _context.CourseGroups.Where(g => g.ParentId == groupId)
                .Select(g => new SelectListItem()
                {
                    Text = g.GroupTitle,
                    Value = g.GroupId.ToString()
                }).ToList();
        }

        public List<SelectListItem> GetTeachers()
        {
            return _context.UserRoles.Where(r => r.RoleId == 2).Include(r => r.User)
                .Select(u => new SelectListItem()
                {
                    Value = u.UserId.ToString(),
                    Text = u.User.UserName
                }).ToList();
        }

        public List<ShowUserCourse> GetUserCourses(int userId)
        {
            return _context.UserCourses.Include(c => c.Course).Where(c => c.UserId==userId)
                .Select(c=> new ShowUserCourse { 
                CourseId=c.CourseId,
                Title=c.Course.CourseTitle,
                ImageName=c.Course.CourseImageName
                }).ToList();
        }

        public bool IsFree(int courseId)
        {
            return _context.Courses.Where(c => c.CourseId == courseId).Select(c => c.CoursePrice).First() == 0;
        }

        public void UpdateCourse(Course course, IFormFile imgCourse, IFormFile courseDemo)
        {
            course.UpdateDate = DateTime.Now;

            if (imgCourse != null && imgCourse.IsImage())
            {
                if (course.CourseImageName != "no-photo.jpg")
                {
                    string deleteimagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/image", course.CourseImageName);
                    if (File.Exists(deleteimagePath))
                    {
                        File.Delete(deleteimagePath);
                    }

                    string deletethumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/thumb", course.CourseImageName);
                    if (File.Exists(deletethumbPath))
                    {
                        File.Delete(deletethumbPath);
                    }
                }
                course.CourseImageName = NameGenerator.GenerateUniqCode() + Path.GetExtension(imgCourse.FileName);
                string imagePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/image", course.CourseImageName);

                using (var stream = new FileStream(imagePath, FileMode.Create))
                {
                    imgCourse.CopyTo(stream);
                }

                ImageConvertor imgResizer = new ImageConvertor();
                string thumbPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/thumb", course.CourseImageName);

                imgResizer.Image_resize(imagePath, thumbPath, 150);
            }

            if (courseDemo != null)
            {
                if (course.DemoFileName != null)
                {
                    string deleteDemoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/demoes", course.DemoFileName);
                    if (File.Exists(deleteDemoPath))
                    {
                        File.Delete(deleteDemoPath);
                    }
                }
                course.DemoFileName = NameGenerator.GenerateUniqCode() + Path.GetExtension(courseDemo.FileName);
                string demoPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/demoes", course.DemoFileName);
                using (var stream = new FileStream(demoPath, FileMode.Create))
                {
                    courseDemo.CopyTo(stream);
                }
            }

            _context.Courses.Update(course);
            _context.SaveChanges();
        }

        public void UpdateGroup(CourseGroup group)
        {
            _context.CourseGroups.Update(group);
            _context.SaveChanges();
        }
    }
}
