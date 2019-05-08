using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Epidemosite.Models.Blocks;
using EPiServer;
using EPiServer.Core;
using EPiServer.Web;
using EPiServer.Web.Mvc;
using EPiServer.Web.Routing;

namespace Epidemosite.Controllers
{
    public class EditorialBlockController : BlockController<EditorialBlock>
    {
        private IPageRouteHelper _pageRouteHelper;
        public EditorialBlockController(IPageRouteHelper pageRouteHelper)
        {
            _pageRouteHelper = pageRouteHelper;
        }
        public override ActionResult Index(EditorialBlock currentBlock)
        {
            var hostingPage = _pageRouteHelper.Page;
            ViewBag.pageName = hostingPage.Name;
            return PartialView(currentBlock);
        }
    }
}
