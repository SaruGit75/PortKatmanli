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

        public int pageSize = 3;
        public ViewResult Index(int page = 1)
        {
            List<Rules> rules = _ruleService.GetAll();

                //sıkıntı cıkabilir.
            return View(new RuleViewModel
            {
                Rule = rules.Skip((page - 1) * pageSize).Take(3).ToList(),
                PagingInfo = new PagingInfo
                {
                    ItemsPerPage = pageSize,
                    TotalItems = rules.Count,
                    CurrentPage = page
                }
            });
        }
    }
}