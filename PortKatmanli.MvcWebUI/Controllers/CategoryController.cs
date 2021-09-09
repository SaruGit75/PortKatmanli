using PortKatmanli.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortKatmanli.MvcWebUI.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        private readonly IRuleService _ruleService;

        public CategoryController(IRuleService ruleService)
        {
            _ruleService = ruleService;
        }

        public PartialViewResult List()
        {
            return PartialView(_ruleService.GetCat());
        }
    }
}