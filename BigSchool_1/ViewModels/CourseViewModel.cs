using BigSchool_1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
namespace BigSchool_1.ViewModels
{
    public class CourseViewModel
    {
        public IEnumerable<Course> UpcomingCourses { get; set; }
        public bool ShowAction { get; set; }

        public int Id { get; set; }
        [Required]  // Bat buoc nhap du lieu
        public string Place { get; set; }

        [Required]
        [FutureDate]
        public string Date { get; set; }
        [Required]
        [ValidTime]
        public string Time { get; set; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public string Heading { get; set; }
        public string Action
        {
            get { return (Id != 0) ? "Update" : "Create"; }
        }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }
}   