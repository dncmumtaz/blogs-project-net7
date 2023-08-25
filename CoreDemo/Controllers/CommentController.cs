﻿using BusinessLayer.Concrete;
using DataAccessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
	public class CommentController : Controller
	{
		private Context _dbContext;
		private readonly CommentManager _commentManager;

		public CommentController( Context dbContext )
		{
			_dbContext = dbContext;
			_commentManager = new CommentManager(new EfCommentRepository(_dbContext));
		}

		public IActionResult Index()
		{
			return View();
		}

		public PartialViewResult PartialAddComment()
		{
			return PartialView();
		}

		public PartialViewResult CommentListByBlog(int id)
		{
			var values = _commentManager.GetList(id);
			return PartialView(values);
		}
	}
}