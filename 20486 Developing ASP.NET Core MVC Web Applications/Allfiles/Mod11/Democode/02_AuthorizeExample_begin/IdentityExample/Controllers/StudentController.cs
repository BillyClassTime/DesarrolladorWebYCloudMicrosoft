﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using IdentityExample.Data;
namespace IdentityExample.Controllers
{
    public class StudentController : Controller
    {
        private StudentContext _studentContext;

        public StudentController(StudentContext student)
        {
            _studentContext = student;
        }

        [Authorize]
        public IActionResult Index()
        {
            /*if (!this.User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }*/
            return View();
        }

        [AllowAnonymous]
        public IActionResult CourseDetails()
        {
            return View(_studentContext.Courses.ToList());
        }
    }
}