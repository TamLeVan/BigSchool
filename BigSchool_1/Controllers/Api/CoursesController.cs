using BigSchool_1.Models;
using BigSchool_1.ViewModels;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;


namespace BigSchool_1.Controllers.Api
{
    public class CoursesController
    {
        public  ApplicationDbContext _dbContext { get; set; }
        public  CoursesController()
        {
            _dbContext = new ApplicationDbContext();
        }
       // [HttpDelete]
       // public IHttpActionResult Cancel(int id)
        //{
          // var userId = 
       // }
    }
}