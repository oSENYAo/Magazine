﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyCompany.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCompany.Controllers
{
    public class HomeController : Controller
    {
        private readonly DataManager manager;
        public HomeController(DataManager manager)
        {
            this.manager = manager;
        }
        public ActionResult Index()
        {
            return View(manager.TextFieldsRepository.GetTextFieldByCodeWord("PageIndex"));
        }
        public ActionResult Contacts()
        {
            return View(manager.TextFieldsRepository.GetTextFieldByCodeWord("PageContacts"));
        }
    }
}
