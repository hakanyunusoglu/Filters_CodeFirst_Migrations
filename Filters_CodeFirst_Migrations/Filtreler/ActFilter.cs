using Filters_CodeFirst_Migrations.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Filters_CodeFirst_Migrations.Filtreler
{
    public class ActFilter : FilterAttribute, IActionFilter
    {
        DatabaseContext db = new DatabaseContext();
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            db.Logs.Add(new Log() { 
            Username="System",
            ActionName=filterContext.ActionDescriptor.ActionName,
            ControllerName=filterContext.ActionDescriptor.ControllerDescriptor.ControllerName,
            Date=DateTime.Now,
            Info="Action Çalıştı"});
            db.SaveChanges();
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            throw new NotImplementedException();
        }
    }
}