﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ext.Net.MVC.Examples.Areas.GridPanel_Plugins.Models;

namespace Ext.Net.MVC.Examples.Areas.GridPanel_Plugins.Controllers
{
    public class GridFilters_LocalController : Controller
    {
        public ActionResult Index()
        {
            return View(GridFiltersModel.Data);
        }
    }
}
