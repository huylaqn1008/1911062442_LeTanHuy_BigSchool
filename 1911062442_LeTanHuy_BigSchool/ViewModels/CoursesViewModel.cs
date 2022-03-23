using _1911062442_LeTanHuy_BigSchool.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _1911062442_LeTanHuy_BigSchool.ViewModels
{
    public class CoursesViewModel
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }
    }
}