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
        public ViewResult Index(int page = 1, int category = 0)
        {
            List<Rules> rules = _ruleService.GetAll().Where(t => t.CategoryId == category || category == 0).ToList();


            return View(new RuleViewModel
            {
                RuleSkip = rules.Skip((page - 1) * pageSize).Take(3).ToList(),
                PagingInfo = new PagingInfo
                {
                    SayfaBasiItem = pageSize,
                    ToplamItem = rules.Count,
                    SuAnkiSayfa = page,
                }
            });
        }


        public ActionResult Add()
        {
            return View(new Rules());
        }


        [HttpPost]
        public ActionResult Add(Rules rules)
        {
            if (ModelState.IsValid)
            {
                _ruleService.Add(rules);
                return RedirectToAction("Index");
            }

            return View(rules);
        }

        //public ActionResult Bul()
        //{
        //    return View();
        //}

        //[HttpPost]
        //public ActionResult Bul(int unitId)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _ruleService.Get(unitId);
        //        return
        //    }
        //}

    }
}