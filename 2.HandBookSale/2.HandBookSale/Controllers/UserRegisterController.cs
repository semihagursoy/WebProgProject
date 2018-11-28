﻿using _2.HandBookSale.Models.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _2.HandBookSale.Controllers
{
    public class UserRegisterController : Controller
    {
        // GET: UserRegister
        public ActionResult Index(string user_name, string user_email, string user_phone, string user_address)
        {
            BookSaleEntities db = new BookSaleEntities();
            var user = new users();
            user.user_name = user_name;
            user.user_email = user_email;
            user.user_address = user_address;
            user.user_registration_date = DateTime.Now;

            db.users.Add(user);
            db.SaveChanges();

            return View();
        }
    }
}