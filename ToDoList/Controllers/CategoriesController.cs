﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using ToDoList.Models;

namespace ToDoList.Controllers
{
    public class CategoriesController : Controller
    {
        [HttpGet("/categories")]
        public ActionResult Index()
        {
            List<Category> allCategories = Category.GetAll();
            return View(allCategories);
        }

        [HttpGet("/categories/new")]
        public ActionResult New()
        {
            return View();
        }
    }
}
