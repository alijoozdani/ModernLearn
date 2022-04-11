using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ModernLearns.Core.Convertors;
using ModernLearns.Core.Services.Interfaces;
using ModernLearns.DataLayer.Entities.Course;
using SharpCompress.Archives;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ModernLearns.Web.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _courseService;
        private IOrderService _orderService;
        private IUserService _userService;
        public CourseController(ICourseService courseService,IOrderService orderService,IUserService user)
        {
            _courseService = courseService;
            _orderService = orderService;
            _userService = user;
        }
        public IActionResult Index(int pageId = 1, string filter = ""
            , string getType = "all", string orderByType = "date", int startPrice = 0
            , int endPrice = 0, List<int> selectedGroups = null)
        {
            ViewBag.selectedGroups = selectedGroups;
            ViewBag.Groups = _courseService.GetAllGroup();
            ViewBag.pageId = pageId;
            ViewBag.getType = getType;
            if (selectedGroups.Any())
            {
                ViewBag.groupTitle = _courseService.GetGroupTitle(selectedGroups.First());
            }

            return View(_courseService.GegCourse(pageId, filter, getType, orderByType, startPrice, endPrice, selectedGroups,9));
        }
        [Route("ShowCourse/{courseId}")]
        public IActionResult ShowCourse(int courseId, int episode = 0)
        {
            var course = _courseService.GetCourseForShow(courseId);

            if (course == null)
                return NotFound();

            if (episode != 0 && User.Identity.IsAuthenticated)
            {
                if (course.CourseEpisodes.All(e => e.EpisodeId != episode))
                {
                    return NotFound();
                }
                if (!course.CourseEpisodes.First(e => e.EpisodeId == episode).IsFree)
                {
                    if (!_orderService.IsUserInCourse(User.Identity.Name, courseId))
                    {
                        return NotFound();
                    }
                }

                var ep = course.CourseEpisodes.First(e => e.EpisodeId == episode);
                ViewBag.Episode = ep;
                string filePath = "";
                string checkFilePath = "";
                if (ep.IsFree)
                {
                    filePath = "/course/courseOnline/" + ep.EpisodeFileName.Replace(".rar", ".mp4");
                    checkFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/courseOnline",
                        ep.EpisodeFileName.Replace(".rar", ".mp4"));
                }
                else
                {
                    filePath = "/course/CourseFilesOnline/" + ep.EpisodeFileName.Replace(".rar", ".mp4");
                    checkFilePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/CourseFilesOnline",
                        ep.EpisodeFileName.Replace(".rar", ".mp4"));
                }


                if (!System.IO.File.Exists(checkFilePath))
                {
                    string targetPath = Directory.GetCurrentDirectory();
                    if (ep.IsFree)
                    {
                        targetPath = System.IO.Path.Combine(targetPath, "wwwroot/course/courseOnline");
                    }
                    else
                    {
                        targetPath = System.IO.Path.Combine(targetPath, "wwwroot/course/CourseFilesOnline");
                    }

                    string rarPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/courseFiles",
                        ep.EpisodeFileName);
                    var archive = ArchiveFactory.Open(rarPath);

                    var Entries = archive.Entries.OrderBy(x => x.Key.Length);
                    foreach (var en in Entries)
                    {
                        if (Path.GetExtension(en.Key) == ".mp4")
                        {
                            en.WriteTo(System.IO.File.Create(Path.Combine(targetPath, ep.EpisodeFileName.Replace(".rar", ".mp4"))));
                        }
                    }
                }

                ViewBag.FilePath = filePath;
            }

            //پر کردن اولیه بخش نظرات

            ViewData["Comments"] = _courseService.GetCourseComments(1, 5, course.CourseId);
            return View(course);
        }
        [Authorize]
        public IActionResult BuyCourse(int id)
        {
            int orderId = _orderService.AddOrder(User.Identity.Name, id);
            return Redirect("/UserPanel/MyOrders/ShowOrder/" + orderId);
        }

        [Route("DownloadFile/{episodeId}")]
        public IActionResult DownloadFile(int episodeId)
        {
            var episode = _courseService.GetEpisodeById(episodeId);

            string filepath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/course/courseFiles",
                episode.EpisodeFileName);
            string fileName = episode.EpisodeFileName;

            if (episode.IsFree)
            {
                byte[] file = System.IO.File.ReadAllBytes(filepath);
                return File(file, "application/force-download", fileName);
            }

            if (User.Identity.IsAuthenticated)
            {
                if (_orderService.IsUserInCourse(User.Identity.Name, episode.CourseId))
                {
                    byte[] file = System.IO.File.ReadAllBytes(filepath);
                    return File(file, "application/force-download", fileName);
                }
            }
            return Forbid();
        }
        public IActionResult GetCourseComments(int pageId, int courseId)
        {
            var courseComments = _courseService.GetCourseComments(pageId, 5, courseId);
            if (courseComments.CourseComments == null)
            {
                return NotFound();
            }
            return PartialView("Course/_CourseComments", courseComments);
        }

        [Authorize]
        [HttpPost]
        public IActionResult AddComment(CourseComment courseComment)
        {

            courseComment.UserId = _userService.GetUserIdByUserName(User.Identity.Name);
            if (string.IsNullOrEmpty(courseComment.Comment))
            {
                return Content("Error");
            }
            var resultComment = _courseService.AddComment(courseComment);
            var userName = $"{resultComment.User.UserName}";
            var res = $"<div class='commetn-box'><img src='/img/userAvatar/{resultComment.User.UserAvatar}'/><span>{userName}</span><i>ارسال شده در {resultComment.CreateDate.ToShamsi()}</i><p>{courseComment.Comment}</p></div>";
            //اگر این نظر یک پاسخ برای یک نظر دیگه باشد وارد شرط میشه و بعد سمت کلاینت صفحه را رفرش میکنیم
            if (courseComment.Answer != null)
            {
                return Content("Success");
            }
            return Content(res);
        }
        [Authorize]
        public IActionResult DeleteComment(int commentId, int courseId)
        {

            var comment = _courseService.GetCommentById(commentId);
            if (comment != null)
            {
                if (comment.CourseId == courseId)
                {
                    _courseService.DeleteComment(comment);
                    return Content("Deleted");
                }

            }
            return Content("Error");

        }

        public IActionResult CourseVote(int id)
        {
            if (!_courseService.IsFree(id))
            {
                if (!_orderService.IsUserInCourse(User.Identity.Name, id))
                {
                    ViewBag.NotAccess = true;
                }
            }
            return PartialView("Course/_CourseVote",_courseService.GetCourseVote(id));
        }

        [Authorize]
        public IActionResult AddVote(int id, bool vote)
        {
            var userId = _userService.GetUserIdByUserName(User.Identity.Name);
            _courseService.AddVote(userId, id, vote);
            return PartialView("Course/_CourseVote", _courseService.GetCourseVote(id));
        }
    }
}
