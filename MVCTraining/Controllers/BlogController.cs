﻿using Microsoft.AspNetCore.Mvc;
using MVCTraining.Models.BlogModel;
using MVCTraining.Models.RequestForm;
using MVCTraining.Repositorys.Blog;
using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace MVCTraining.Controllers
{
    public class BlogController : BaseController
    {
        private readonly BlogService _blogService;

        public BlogController(BlogService blogService)
        {
            _blogService = blogService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetAllBlog()
        {
            BlogDataRequestModel model = new BlogDataRequestModel();
            BlogResponseFilter responseModel = new BlogResponseFilter();
            var requestData = GetFormRequest();
            model.DataTablesRequest = requestData;
            var blogList = _blogService.GetAllBlog(model.DataTablesRequest);
            return ToJson(requestData.Draw, blogList.RequestTotal, blogList.RequestFilter, blogList.BlogList);
        }
    }
}
