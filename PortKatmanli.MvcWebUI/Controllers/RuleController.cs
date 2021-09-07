using PortKatmanli.Bll.Concrete;
using PortKatmanli.Dal.Concrete.EntityFramework;
using PortKatmanli.Entities;
using PortKatmanli.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PortKatmanli.MvcWebUI.Controllers
{
    public class RuleController : Controller
    {
        // GET: Rule

        private readonly IRuleService _ruleService;

        public RuleController(IRuleService ruleService)
        {
            _ruleService = ruleService;
        }

        public ViewResult Index()
        {
            List<Rules> rules = _ruleService.GetAll();
            return View(rules);
        }
    }
}