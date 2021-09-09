using Ninject;
using PortKatmanli.Bll.Concrete;
using PortKatmanli.Dal.Abstract;
using PortKatmanli.Dal.Concrete.EntityFramework;
using PortKatmanli.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace PortKatmanli.MvcWebUI.Infrastructure
{
    public class NinjectControllerFactory : DefaultControllerFactory
    {
        private readonly IKernel _ninjectKernel;

        public NinjectControllerFactory()
        {
            _ninjectKernel = new StandardKernel();
            AddBllBindings();
        }

        private void AddBllBindings()
        {
            _ninjectKernel.Bind<IRuleService>().To<RuleManager>().WithConstructorArgument("ruleDal", new EfRuleDal(new PortKatmanliContext()));      //eger bizden birisi IRuleService isterse ona RuleManager'i ver.
            _ninjectKernel.Bind<IAllEventDal>().To<EfAllEventDal>().WithConstructorArgument("allEventDal", new EfRuleDal(new PortKatmanliContext()));      //eger bizden birisi IRuleService isterse ona RuleManager'i ver.
            _ninjectKernel.Bind<ICategoryDal>().To<EfCategoryDal>().WithConstructorArgument("categoryDal", new EfRuleDal(new PortKatmanliContext()));
        }


        protected override IController GetControllerInstance(RequestContext requestContext, Type controllerType)
        {
            return controllerType == null ? null : (IController)_ninjectKernel.Get(controllerType);
        }
    }
}